using DTO.Example.DomainModel;
using DTO.Example.Mapper;
using DTO.Example.TranferObject;

namespace DTO.Example.UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessOne();
        }

        private static void ProcessOne()
        {
            Meeting meeting = new Meeting
            {

            };

            // Mapper object entity to DTO
            MeetingDTO dto = meeting.CreateDTO();
            //Continue process...
        }

        private static void ProcessTwo()
        {
            MeetingDTO dto = new MeetingDTO
            {

            };

            // Mapper object DTO to entity
            Meeting meeting = dto.CreateEntity();
            //Continue process...
        }
    }
}
