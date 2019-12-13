using Microsoft.EntityFrameworkCore;

namespace ActivityCenter.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) {}
        public DbSet<User> Users {get;set;}
        public DbSet<ActivityE> Activities {get;set;}
        public DbSet<ParticipantList> ParticipantLists {get;set;}
    }
}