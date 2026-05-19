using SportsLeague.Domain.Enums;

namespace SportsLeague.API.DTO_s.Request
{
    public class GoalRequestDTO
    {
        public int PlayerId { get; set; }
        public int Minute { get; set; }
        public GoalType Type { get; set; }
    }

}
