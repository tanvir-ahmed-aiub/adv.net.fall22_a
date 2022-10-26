using E_commerce.DB;
using E_commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_commerce.Repo
{
    public class OrderDetailRepo
    {
        public static List<OrderDetailModel> Get() {
            return null;
        }
        public static OrderDetailModel Get(int id) { 
            return null;
        }
        public static void Create(OrderDetailModel od) {
            var db = new Entities();
            db.OrderDetails.Add(new OrderDetail() { 
                OrderId = od.OrderId,
                ProductId = od.ProductId,
                UnitPrice = od.UnitPrice,
                Qty = od.Qty,
            });
            db.SaveChanges();
        }

        
    }
}