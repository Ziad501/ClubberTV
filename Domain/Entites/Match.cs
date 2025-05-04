namespace Domain.Entites
{
    public class Match : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Competition { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Status { get; set; } = string.Empty;

    }
}
