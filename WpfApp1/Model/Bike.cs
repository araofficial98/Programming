using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class Bike
    {

        public enum Type {  Oma, Opa, Bmx }
        
        public enum Gender {  Men, Women }
        public enum Size {  Small, Medium, Big }
        public string Brand { get; set; }

        public double HourRate  = 5;
        public double DailyRate = 60;
    }
}
