namespace BOL;

// POCO bitch
public class Product
{
    public int ProductId{get; set;}
    public string ProductName{get; set;}
    public string Productdesc{get; set;}
    public double MRP{get; set;}
    public double DiscountPrice{get; set;}
    public int Qty{get; set;}
    public DateTime ExpDate{get; set;}
    public string ProductType{get; set;}

    public Product(){

    }

    public Product(int pid, string pname, string pdesc, float pmrp, double dicprice, int qty, DateTime expdate, string ptype){
        this.ProductId = pid;
        this.ProductName = pname;
        this.Productdesc = pdesc;
        this.MRP = pmrp;
        this.DiscountPrice = dicprice;
        this.Qty = qty;
        this.ExpDate = expdate;
        this.ProductType = ptype;
    }
}
