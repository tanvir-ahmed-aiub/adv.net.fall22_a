using E_commerce.Models;
using E_commerce.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace E_commerce.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View(ProductRepo.Get());
        }
        public ActionResult addtocart(int id) {
            var p = ProductRepo.Get(id);
            p.Qty = 1;
            List<ProductModel> products = null;
            if (Session["cart"] == null)
            {
                products = new List<ProductModel>();   
            }
            else {
                var json2 = Session["cart"].ToString();
                products = new JavaScriptSerializer().Deserialize<List<ProductModel>>(json2);
                
            }
            products.Add(p);
            var json = new JavaScriptSerializer().Serialize(products);
            Session["cart"] = json;
            TempData["msg"] = "Product Added to Cart";
            return RedirectToAction("Index");
        }
        public ActionResult ShowCart() {
            if (Session["cart"] == null) {
                TempData["msg"] = "Cart is empty";
                return RedirectToAction("Index");
            }
            var json2 = Session["cart"].ToString();
            var products = new JavaScriptSerializer().Deserialize<List<ProductModel>>(json2);
            return View(products);  
        }
        [HttpPost]  
        public ActionResult checkout(int total) {
            var order = new OrderModel();
            order.TotalSum = total;
            order.OrderDate = DateTime.Now;
            order.OrderedBy = 1;
            order.Status = "Ordered";
            var odId =  OrderRepo.Create(order);
            if (odId != 0) {
                var json2 = Session["cart"].ToString();
                var products = new JavaScriptSerializer().Deserialize<List<ProductModel>>(json2);
                foreach (var item in products)
                {
                    OrderDetailRepo.Create(new OrderDetailModel() {
                        ProductId = item.Id,
                        Qty = item.Qty,
                        UnitPrice = item.Price,
                        OrderId = odId
                    });
                }
                Session["cart"] = null;
            }
            TempData["msg"] = "Order Placed Successfully";
            return RedirectToAction("Index");
        }


    }
}