namespace MoneyApp.Data
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int AccountId { get; set; }
        public virtual Account? Account {get;set;}
        public string Category { get; set; } = "";
        public string? Description { get; set; }
        public float Amount { get; set; }
        public string? FilePath {get;set;}

    }
}