using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MartInventory.Models;
using BOL;
using BLL;


namespace MartInventory.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Product()
    {
        Catalog manager=new Catalog();
        List<Product> allProducts=manager.GetAllProducts();
        this.ViewData["products"]=allProducts;
        return View();
    }

}
