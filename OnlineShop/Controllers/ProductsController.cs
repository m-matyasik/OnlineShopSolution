using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
    public class ProductsController : Controller
    {
        private static IList<ProductModel> products = new List<ProductModel>
        {
            new ProductModel()
            {
                Id = 1, 
                productName = "Samsung 970 EVO Plus 2TB M.2", 
                productDescription = "M.2 Super Fast Drive",
                productPrice = 2045.49},
            new ProductModel()
            {
                Id = 2,
                productName = "BenQ GW2270H",
                productDescription = "Standard budget monitor",
                productPrice = 369.99},
            new ProductModel()
            {
                Id = 3,
                productName = "Intel Xeon Gold 5120",
                productDescription = "Best processor for workstations",
                productPrice = 7990.00},
        };
        // GET: ProductsController
        public ActionResult Index()
        {
            return View(products);
        }

        // GET: ProductsController/Details/5
        public ActionResult Details(int id)
        {
            return View(products.FirstOrDefault(x => x.Id == id));
        }

        // GET: ProductsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductModel product)
        {
            product.Id = products.Count + 1;
            products.Add(product);
            return RedirectToAction("Index");
        }

        // GET: ProductsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(products.FirstOrDefault(x => x.Id == id));
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProductModel product)
        {
            ProductModel prod = products.FirstOrDefault(x => x.Id == id);
            prod.productName = product.productName;
            prod.productDescription = product.productDescription;
            prod.productPrice = product.productPrice;

            return RedirectToAction("Index");
        }

        // GET: ProductsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(products.FirstOrDefault(x => x.Id == id));
        }

        // POST: ProductsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ProductModel product)
        {
            products.Remove(products.FirstOrDefault(x => x.Id == id));
            return RedirectToAction("Index");
        }
    }
}
