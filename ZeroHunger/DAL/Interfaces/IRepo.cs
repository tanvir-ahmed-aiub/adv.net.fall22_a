﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<CLASS,ID>
    {
        void Add(CLASS obj);
        void Update(CLASS obj);
        List<CLASS> Get();
        CLASS Get(ID id);
        void Delete(ID id);
    }
}
