namespace MoneyApp.Data
{
    public class Transfer
    {    
        public DateTime Date { get; set; }
        public int FromAccountId { get; set; }
        public int ToAccountId { get; set; }
        public float FromAmount { get; set; }
        public float ToAmount{get;set;}
        public string? Description { get; set; }
           
    }
}