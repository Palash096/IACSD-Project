namespace BLL;
using BOL;
using DAL;

using System.Collections.Generic;

public class Catalog
{
    public List<Product> GetAllProducts(){
        List<Product> allProducts = new List<Product>();
        allProducts = DBManager.GetAllProducts();
        return allProducts;
    }
}
