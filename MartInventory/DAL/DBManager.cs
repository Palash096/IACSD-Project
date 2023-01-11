namespace DAL;
using BOL;
using MySql.Data.MySqlClient;
public class DBManager
{
    public static string conString=@"server=localhost;port=3306;user=root;password=root123;database=martinventory";
    public static List<Product> GetAllProducts(){
        List<Product> allProducts = new List<Product>();

        MySqlConnection con=new MySqlConnection();
        con.ConnectionString=conString;

        try{
            con.Open();
            MySqlCommand cmd=new MySqlCommand();
            cmd.Connection=con;

            string query="SELECT * FROM Product ";
            cmd.CommandText=query;

            MySqlDataReader reader=cmd.ExecuteReader();
            while(reader.Read()){
                int pid=int.Parse(reader["pid"].ToString());
                string pname=reader["pname"].ToString();
                string description=reader["description"].ToString();
                double mrp=double.Parse(reader["MRP"].ToString());
                double discount=double.Parse(reader["discount"].ToString());
                int pqty=int.Parse(reader["pqty"].ToString());
                DateTime Exp_date=DateTime.Parse(reader["Expiry_Date"].ToString());
                string ptype=reader["ptype"].ToString();

                Product pro = new Product{
                    ProductId = pid,
                    ProductName = pname,
                    Productdesc = description,
                    MRP = mrp,
                    DiscountPrice = discount,
                    Qty = pqty,
                    ExpDate = Exp_date,
                    ProductType = ptype
                };
                allProducts.Add(pro);
            }

        }catch(Exception ee){
            Console.WriteLine(ee.Message);
        }finally{
            con.Close();
        }

        // allProducts.Add(new Product{ ProductId = 11,  ProductName = "Milk",  Productdesc = "Very tasty", MRP = 2,  DiscountPrice = 1,  Qty = 20,  ExpDate = new DateTime(2021/05/05) ,  ProductType = "grocery"});  
        // allProducts.Add(new Product{ ProductId = 12,  ProductName = "Bread",  Productdesc = "Very tasty", MRP = 2,  DiscountPrice = 1,  Qty = 20,  ExpDate = new DateTime(2000/03/05) ,  ProductType = "grocery"});  
        // allProducts.Add(new Product{ ProductId = 13,  ProductName = "Coca Cola",  Productdesc = "Very tasty", MRP = 2,  DiscountPrice = 1,  Qty = 20,  ExpDate = new DateTime(2012/05/05) ,  ProductType = "grocery"});  
        // allProducts.Add(new Product{ ProductId = 14,  ProductName = "Water Bottle",  Productdesc = "Very tasty", MRP = 2,  DiscountPrice = 1,  Qty = 20,  ExpDate = new DateTime(2018/05/05) ,  ProductType = "grocery"});  
        // allProducts.Add(new Product{ ProductId = 15,  ProductName = "Almond",  Productdesc = "Very tasty", MRP = 2,  DiscountPrice = 1,  Qty = 20,  ExpDate = new DateTime(2015/05/05) ,  ProductType = "grocery"});  
        // allProducts.Add(new Product{ ProductId = 16,  ProductName = "Cream Biscuit",  Productdesc = "Very tasty", MRP = 2,  DiscountPrice = 1,  Qty = 20,  ExpDate = new DateTime(2003/05/05) ,  ProductType = "grocery"});  
        return allProducts; 
    }
}
