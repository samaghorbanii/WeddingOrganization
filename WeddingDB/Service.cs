using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingDB
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Property> Properties { get; set; }
        public ICollection<Value> Values { get; set; }
    }
}
