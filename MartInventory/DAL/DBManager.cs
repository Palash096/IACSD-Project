namespace DAL;
using BOL;
public class DBManager
{
    public static List<Product> GetAllProducts(){
        List<Product> allProducts = new List<Product>();
        allProducts.Add(new Product{ ProductId = 11,  ProductName = "Supari",  Productdesc = "Very tasty", MRP = 2,  DiscountPrice = 1,  Qty = 20,  ExpDate = new DateTime(2022/05/05) ,  ProductType = "grocery"});  
        allProducts.Add(new Product{ ProductId = 11,  ProductName = "Supari",  Productdesc = "Very tasty", MRP = 2,  DiscountPrice = 1,  Qty = 20,  ExpDate = new DateTime(2022/05/05) ,  ProductType = "grocery"});  
        allProducts.Add(new Product{ ProductId = 11,  ProductName = "Supari",  Productdesc = "Very tasty", MRP = 2,  DiscountPrice = 1,  Qty = 20,  ExpDate = new DateTime(2022/05/05) ,  ProductType = "grocery"});  
        allProducts.Add(new Product{ ProductId = 11,  ProductName = "Supari",  Productdesc = "Very tasty", MRP = 2,  DiscountPrice = 1,  Qty = 20,  ExpDate = new DateTime(2022/05/05) ,  ProductType = "grocery"});  
        allProducts.Add(new Product{ ProductId = 11,  ProductName = "Supari",  Productdesc = "Very tasty", MRP = 2,  DiscountPrice = 1,  Qty = 20,  ExpDate = new DateTime(2022/05/05) ,  ProductType = "grocery"});  
        allProducts.Add(new Product{ ProductId = 11,  ProductName = "Supari",  Productdesc = "Very tasty", MRP = 2,  DiscountPrice = 1,  Qty = 20,  ExpDate = new DateTime(2022/05/05) ,  ProductType = "grocery"});  
        return allProducts; 
    }
}
