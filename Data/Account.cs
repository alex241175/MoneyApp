namespace MoneyApp.Data
{
    public class Account
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Currency { get; set; }
        public int UserId { get; set; } 
        public float ToBaseExchangeRate {get;set;}  //Base is MYR
        public virtual List<Transaction> Transactions {get;set;}   

    }
}