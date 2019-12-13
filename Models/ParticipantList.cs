using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ActivityCenter.Models
{
    public class ParticipantList
    {
        [Key]
        public int ParticipantListId {get;set;}
        public int UserId {get;set;}
        public int ActivityId {get;set;}
        public User User {get;set;}
        public ActivityE Activity {get;set;}
    }
}