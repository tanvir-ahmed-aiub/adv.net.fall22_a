using E_commerce.DB;
using E_commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_commerce.Repo
{
    public class ProductRepo
    {
        public static List<ProductModel>Get() {
            var db = new Entities();
            var products = new List<ProductModel>();
            foreach (var item in db.Products)
            {
                products.Add(new ProductModel() {
                    Id = item.Id,
                    Name = item.Name,   
                    Price = item.Price,
                    Qty = item.Qty,
                    CategoryId = item.CategoryId,

                });
            }
            return products;
        }
        public static ProductModel Get(int id) {
            var db = new Entities();
            var product = new ProductModel();
            var dbpr = db.Products.Find(id);
            product.Id = dbpr.Id;
            product.Name = dbpr.Name;
            product.Qty = dbpr.Qty;
            product.Price = dbpr.Price;
            product.CategoryId = dbpr.CategoryId;
            return product;
        }
        public static void Create(ProductModel dbpr) {
            var product = new Product();
            product.Id = dbpr.Id;
            product.Name = dbpr.Name;
            product.Qty = dbpr.Qty;
            product.Price = dbpr.Price;
            product.CategoryId = dbpr.CategoryId;

            var db = new Entities();
            db.Products.Add(product);
            db.SaveChanges();
        }

    }
}