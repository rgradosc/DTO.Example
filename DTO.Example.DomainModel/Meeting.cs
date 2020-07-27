using System;
using System.Collections.Generic;

namespace DTO.Example.DomainModel
{
    public class Meeting
    {
        public Guid MeetingId { get; set; }

        public string Name { get; set; }

        public Group Organizer { get; set; }

        public List<Attendee> ConfirmedAttendees { get; set; }

        public List<Attendee> UnconfirmedAttendees { get; set; }
    }
}
