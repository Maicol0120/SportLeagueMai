namespace SportsLeague.API.DTO_s.Request
{
    public class MatchResultRequestDTO
    {
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }
        public string? Observations { get; set; }
    }

}
