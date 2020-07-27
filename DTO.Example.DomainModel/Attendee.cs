using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO.Example.DomainModel
{
    [Table("Asistentes")]
    public class Attendee
    {
        public Guid AttendeeId { get; set; }

        [Required]
        public Guid MeetingId { get; set; }

        public Meeting Meeting { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
