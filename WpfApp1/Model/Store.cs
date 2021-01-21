using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class Store
    {

        public string Address { get; set; }
        public string City { get; set; }
        public int MaxCapacity { get; set; }
        public List<string> Bikes = new List<string> {};

        public Store(string add, string stad, int max)
        {
            add = Address;
            stad = City;
            max = MaxCapacity;
        }

        


    }
}
