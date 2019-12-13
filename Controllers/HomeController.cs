using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ActivityCenter.Models;

namespace ActivityCenter.Controllers
{
    public class HomeController : Controller
    {
        public MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("signin")]
        public IActionResult SignIn()
        {
            return View();
        }

        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use.");
                    return View("SignIn");
                }
                else
                {    
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                    dbContext.Users.Add(newUser);
                    dbContext.SaveChanges();
                    var createdUser = dbContext.Users.FirstOrDefault(u => u.Email == newUser.Email);
                    HttpContext.Session.SetInt32("UserId", createdUser.UserId);
                    return RedirectToAction("Home");
                }
            }
            else
            {
                return View("SignIn");
            }
        }

        public IActionResult Login(LoginUser loginUser)
        {
            if(ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == loginUser.LoginEmail);
                if(userInDb == null)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Email/Password.");
                    return View("SignIn");
                }
                else
                {
                    var hasher = new PasswordHasher<LoginUser>();
                    var result = hasher.VerifyHashedPassword(loginUser, userInDb.Password, loginUser.LoginPassword);
                    if(result == 0)
                    {
                        ModelState.AddModelError("LoginEmail", "Invalid Email/Password.");
                        return View("SignIn");
                    }
                    else
                    {
                        HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                        return RedirectToAction("Home");
                    }
                }
            }
            else
            {
                return View("SignIn");
            }
        }

        [HttpGet("home")]
        public IActionResult Home()
        {
            if(HttpContext.Session.GetInt32("UserId") != null)
            {
                List<ActivityE> allActivities = dbContext.Activities.Where(activity => activity.Date > DateTime.Now).Include(act => act.Coordinator).Include(a => a.Participants).ThenInclude(pl => pl.User).OrderBy(ay => ay.Date).ToList();
                ViewBag.User = dbContext.Users.Include(user => user.ActivityToAttend).FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId"));
                return View(allActivities);
            }
            else
            {
                return RedirectToAction("SignIn");
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("SignIn");
        }
    
        [HttpGet("new")]
        public IActionResult NewActivity()
        {
            if(HttpContext.Session.GetInt32("UserId") != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("SignIn");
            }
        }

        [HttpGet("activity/{activityId}/delete")]
        public IActionResult DeleteActivity(int activityId)
        {
            ActivityE currentActivity = dbContext.Activities.SingleOrDefault(activity => activity.ActivityId == activityId);
            dbContext.Activities.Remove(currentActivity);
            dbContext.SaveChanges();
            return RedirectToAction("Home");
        }

        [HttpGet("activity/{activityId}/join")]
        public IActionResult JoinActivity(int activityId)
        {
            ParticipantList participantToAdd = new ParticipantList()
            {
                UserId = (int)HttpContext.Session.GetInt32("UserId"),
                ActivityId = activityId
            };
            dbContext.ParticipantLists.Add(participantToAdd);
            dbContext.SaveChanges();
            return RedirectToAction("Home");
        }

        [HttpGet("activity/{activityId}/viewjoin")]
        public IActionResult ViewJoinActivity(int activityId)
        {
            ParticipantList participantToAdd = new ParticipantList()
            {
                UserId = (int)HttpContext.Session.GetInt32("UserId"),
                ActivityId = activityId
            };
            dbContext.ParticipantLists.Add(participantToAdd);
            dbContext.SaveChanges();
            return RedirectToAction("ViewActivity", new {activityId = activityId});
        }

        [HttpGet("activity/{activityId}/leave")]
        public IActionResult LeaveActivity(int activityId)
        {
            ParticipantList participantToRemove = dbContext.ParticipantLists.Where(participant => participant.ActivityId == activityId).FirstOrDefault(p => p.UserId == HttpContext.Session.GetInt32("UserId"));
            dbContext.ParticipantLists.Remove(participantToRemove);
            dbContext.SaveChanges();
            return RedirectToAction("Home");
        }

        [HttpGet("activity/{activityId}/viewleave")]
        public IActionResult ViewLeaveActivity(int activityId)
        {
            ParticipantList participantToRemove = dbContext.ParticipantLists.Where(participant => participant.ActivityId == activityId).FirstOrDefault(p => p.UserId == HttpContext.Session.GetInt32("UserId"));
            dbContext.ParticipantLists.Remove(participantToRemove);
            dbContext.SaveChanges();
            return RedirectToAction("ViewActivity", new {activityId = activityId});
        }

        public IActionResult CreateActivity(ActivityE newActivity)
        {
            if(ModelState.IsValid)
            {
                if(newActivity.Date > DateTime.Now)
                {
                    newActivity.UserId = (int)HttpContext.Session.GetInt32("UserId");
                    dbContext.Activities.Add(newActivity);
                    dbContext.SaveChanges();
                    var createdActivity = dbContext.Activities.Last();
                    return RedirectToAction("ViewActivity", new {activityId = createdActivity.ActivityId});
                }
                else
                {
                    ModelState.AddModelError("Date", "Activity date must be in the future.");
                    return View("NewActivity");
                }
            }
            else
            {
                return View("NewActivity");
            }
        }

        [HttpGet("activity/{activityId}")]
        public IActionResult ViewActivity(int activityId)
        {
            if(HttpContext.Session.GetInt32("UserId") != null)
            {
                ActivityE currentActivity = dbContext.Activities.Include(act => act.Coordinator).Include(a => a.Participants).ThenInclude(pl => pl.User).FirstOrDefault(activity => activity.ActivityId == activityId);
                ViewBag.User = dbContext.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId"));
                return View(currentActivity);
            }
            else
            {
                return RedirectToAction("SignIn");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
