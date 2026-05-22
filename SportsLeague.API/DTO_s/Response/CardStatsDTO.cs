namespace SportsLeague.API.DTO_s.Response
{
    namespace SportsLeague.API.DTO_s.Response
    {
        public class CardStatsDTO
        {
            public int PlayerId { get; set; }
            public string PlayerName { get; set; } = string.Empty;
            public string TeamName { get; set; } = string.Empty;
            public int YellowCards { get; set; }
            public int RedCards { get; set; }
            public int TotalCards { get; set; }
        }

    }
}
