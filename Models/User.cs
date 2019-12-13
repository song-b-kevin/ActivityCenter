using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActivityCenter.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}

        [Required]
        [MinLength(2, ErrorMessage="Name must be a minimum of 2 characters.")]
        public string Name {get;set;}

        [Required]
        [EmailAddress]
        public string Email {get;set;}

        [Required]
        [MinLength(8, ErrorMessage="Password must be a minimum of 8 characters.")]
        [RegularExpression(@"^(?=.*[a-zA-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$", ErrorMessage="Must contain at least 1 number, 1 letter, and a special character.")]
        [DataType(DataType.Password)]
        public string Password {get;set;}

        public List<ActivityE> CreatedActivity {get;set;}

        public List<ParticipantList> ActivityToAttend {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        [NotMapped]
        [Required]
        [Display(Name="Confirm Password")]
        [Compare("Password", ErrorMessage="Password does not match.")]
        [DataType(DataType.Password)]
        public string ConfirmPW {get;set;}
    }
}