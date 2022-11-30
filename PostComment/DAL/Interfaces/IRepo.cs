using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<CLASS,ID,RES>
    {
        List<CLASS> Get();
        CLASS Get(ID id);
        RES Add(CLASS obj);  
        RES Update(CLASS obj);
        bool Delete(ID id);
    }
}
