namespace MoneyApp.Data
{
    public class Category{

        public static List<string> Data = new List<string>(){
            "Food",
            "Salary",
            "Insurance",
            "Interest",
            "Tax",
            "Groceries",
            "Transport",
            "Telecommunication",
            "Utilities",
            "Education",
            "Medical",
            "Leisure",
            "House",
            "Clothing",
            "Other",
            "Adjust",
            "Transfer"
        };

    }

    public enum CategoryEnum
    {
        Salary,
        Insurance,
        Interest,
        Food,
        Groceries,
        Transport,
        Telecommunication,
        Utilities,
        Education,
        Medical,
        Leisure,
        House,
        Clothing,
        Other,
        Adjust,
        Transfer,
    }
}