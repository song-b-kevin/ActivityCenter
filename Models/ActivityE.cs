using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ActivityCenter.Models
{
    public class ActivityE
    {
        [Key]
        public int ActivityId {get;set;}

        [Required]
        public string Title {get;set;}

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date {get;set;}

        [Required]
        [DataType(DataType.Time)]
        public DateTime Time {get;set;}

        [Required]
        [Range(1, 365, ErrorMessage="Duration must be greater than 0.")]
        public int Duration {get;set;}

        [Required]
        public string DurationUnit {get;set;}

        [Required]
        public string Description {get;set;}

        public int UserId {get;set;}

        public User Coordinator {get;set;}

        public List<ParticipantList> Participants {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}