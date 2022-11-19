using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8.Lesson3_17_11_22
{
    internal class Food : Item
    {
        public Food(int id) : base(id) { }
        public int Weight { get; set; }
    }
}
