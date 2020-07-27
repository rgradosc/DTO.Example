using DTO.Example.DomainModel;
using DTO.Example.TranferObject;

namespace DTO.Example.Mapper
{
    public static class ManualMeetingMapper
    {
        public static MeetingDTO CreateDTO(this Meeting entity)
        {
            MeetingDTO result = new MeetingDTO
            {
                ConfirmedAttendeeCount = entity.ConfirmedAttendees.Count,
                GroupName = entity.Organizer.Name,
                MeetingName = entity.Name,
                UnconfirmedAttendeeCount = entity.UnconfirmedAttendees.Count,
            };

            return result;
        }

        public static Meeting CreateEntity(this MeetingDTO dto)
        {
            Meeting result = new Meeting
            {
                Name = dto.MeetingName,
            };

            return result;
        }
    }
}
