using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_with_core.Model
{
    public class Customers
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Customers()
        {
            ID = -1;
            Name = null;
        }
        public Customers(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
