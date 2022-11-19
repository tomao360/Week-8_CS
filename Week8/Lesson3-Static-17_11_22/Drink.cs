using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8.Lesson3_17_11_22
{
    internal class Drink : Item
    {
       public Drink(int id) : base(id) { }

        public string LiquidColor { get; set; }
    }
}
