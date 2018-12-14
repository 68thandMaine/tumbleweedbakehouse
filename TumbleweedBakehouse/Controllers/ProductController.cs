using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TumbleweedBakehouse.Models;

namespace TumbleweedBakehouse.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet("/product")]
        public ActionResult Index()
        {

          List<Product> productList = Product.GetAll();

          List<Product> newList = new List<Product>{};
          newList = Product.GetAll();

          return View(newList);
        }

        [HttpGet("/product/new")]
        public ActionResult New()
        {
          return View();
        }

        [HttpGet("product/{id}")]
        public ActionResult Show(int id)
        {
          Product thisProduct = Product.Find(id);

          return View(thisProduct);
        }

        [HttpPost("/product")]
        public ActionResult Create(string name, string type, string description, string url, bool available, float price,int id)
        {
          Product newProduct = new Product (name,type,description,url,available,price,id);
          newProduct.Save();
          return RedirectToAction("Index");

        }

        [HttpGet("/products/{id}/edit")]
        public ActionResult Edit()
        {

          return View();
        }

        [HttpPost("/products/{id}")]
        public ActionResult Edit(string name, string type, string description, string url, float price)
        {
          Product newProduct = new Product (name,type,description,url,price);
          newProduct.Edit()
          newProduct.Save();
          return RedirectToAction("Show");
        }

    }
}



// Dictionary<string, object> model = new Dictionary<string, object>();
// Category category = Category.Find(categoryId);
// model.Add("category", category);
// Item item = Item.Find(itemId);
// model.Add("item", item);
