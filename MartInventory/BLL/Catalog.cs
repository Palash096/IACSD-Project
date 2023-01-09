namespace BLL;
using BOL;
using DAL;

using System.Collections.Generic;

public class Catalog
{
    public static List<Product> GetAllProducts(){
        List<Product> allProducts = DBManager.GetAllProducts();
        return allProducts;
    }
}
