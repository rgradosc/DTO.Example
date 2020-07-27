
using System;
using System.Collections.Generic;

namespace DTO.Example.DomainModel
{
    public class Group
    {
        public Guid GroupId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Meeting> Meetings { get; set; }
    }
}
