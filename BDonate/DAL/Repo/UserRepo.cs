using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class UserRepo : IRepo<User, string, User>,IAuth
    {
        BloodDonateEntities db;
        internal UserRepo()
        {
            db = new BloodDonateEntities();
        }
        public User Add(User obj)
        {
            db.Users.Add(obj);
            if (db.SaveChanges() > 0) {
                return obj;
            }
            return null;
            
        }

        public User Authenticate(string uname, string pass)
        {
            var obj = db.Users.FirstOrDefault(x => x.Username.Equals(uname) && x.Password.Equals(pass));
            return obj;
        }

        public bool Delete(User obj)
        {
            throw new NotImplementedException();
        }

        public List<User> Get()
        {
            return db.Users.ToList();
        }

        public User Get(string id)
        {
            return db.Users.Find(id);
        }

        public User Update(User obj)
        {
            var dbobj = Get(obj.Username);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) {
                return obj;
            }
            return null;
        }
    }
}
