using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class DonorRepoV2 : IRepo<Donor, int, Donor>
    {
        public Donor Add(Donor obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Donor obj)
        {
            throw new NotImplementedException();
        }

        public List<Donor> Get()
        {
            throw new NotImplementedException();
        }

        public Donor Get(int id)
        {
            throw new NotImplementedException();
        }

        public Donor Update(Donor obj)
        {
            throw new NotImplementedException();
        }
    }
}
