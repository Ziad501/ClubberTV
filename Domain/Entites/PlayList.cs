namespace Domain.Entites
{
    public class PlayList
    {
        public required string UserId { get; set; } 
        public int MatchId { get; set; }

        public AppUser User { get; set; } = new();
        public Match Match { get; set; } = new();
    }
}
