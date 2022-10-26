using E_commerce.DB;
using E_commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_commerce.Repo
{
    public class CategoryRepo
    {
        public static List<CategoryModel> Get() {
            var db = new Entities();
            var categories = new List<CategoryModel>();
            foreach (var item in db.Categories)
            {
                categories.Add(new CategoryModel() { 
                    Id = item.Id,   
                    Name = item.Name
                });
            }
            return categories;
        }
        public static CategoryModel Get(int id) {
            var db = new Entities();
            var dbct = db.Categories.Find(id);
            return new CategoryModel() { 
                Id = dbct.Id,
                Name = dbct.Name
            };
        }
        public static void Create(CategoryModel cat) {
            var db = new Entities();
            db.Categories.Add(new Category() { 
                Id=cat.Id,
                Name=cat.Name
                
            });
            db.SaveChanges();
            
        }
    }
}