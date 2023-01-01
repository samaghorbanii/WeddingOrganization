using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingDB.IRepository
{
    public interface IWeddingServiceRepository
    {
        DataTable GetAll(int id);
    }
}
