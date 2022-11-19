using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8.Lesson3_17_11_22
{
    internal class Item
    {
        public Item(int id)
        {
            Id = id;
        }

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _price;
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

    }
}
