using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class DonorRepo : IRepo<Donor, int, Donor>
    {
        BloodDonateEntities db;
        internal DonorRepo() { 
            db = new BloodDonateEntities();
        }
        public Donor Add(Donor obj)
        {
            db.Donors.Add(obj);
            if(db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(Donor obj)
        {
            var dbobj = Get(obj.Id);
            db.Donors.Remove(dbobj);
            return db.SaveChanges() > 0;
        }

        public List<Donor> Get()
        {
            return db.Donors.ToList();
        }

        public Donor Get(int id)
        {
            return db.Donors.Find(id);  
        }

        public Donor Update(Donor obj)
        {
            var dbojb = Get(obj.Id);
            db.Entry(dbojb).CurrentValues.SetValues(obj);
            if(db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
    }
}
