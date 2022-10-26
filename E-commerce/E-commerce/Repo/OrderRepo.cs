using E_commerce.DB;
using E_commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_commerce.Repo
{
    public class OrderRepo
    {
        public static List<OrderModel> Get() {
            return null;
        }

        public static OrderModel Get(int id) { 
            return null;
        }
        public static int Create(OrderModel model) {
            var db = new Entities();
            var order = new Order()
            {
                OrderDate = model.OrderDate,
                Status = model.Status,
                TotalSum = model.TotalSum,
                OrderedBy = model.OrderedBy
            };
            db.Orders.Add(order);
            if (db.SaveChanges() > 0) {
                return order.Id;
            }
            return 0;
            
        }
    }
}