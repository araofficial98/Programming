using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    class Method
    {

        public int Amnt = Enum.GetNames(typeof(Bike.Type)).Length;

        public static void SetBikes() {
            for (int i = 0; i < Amnt; i++)
            {
                GetBikes()
            }
        }

        private static List<string> GetBikes()
        {
            return Store.Bikes;
        }


    }
}
