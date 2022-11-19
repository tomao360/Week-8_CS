using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//---------------------
//--------static-------
//---------------------

namespace Week8.Lesson3_17_11_22
{
    internal class Book
    {
        //---Factory Method Design Pattern---
        public static Book Create(string name)
        {
            if (countBook < 3)
            {
                Book ret = new Book(name);
                return ret;
            }
            else
            {
                return null;
            }
            
        }
        //------------------------------------
        private Book(string name)
        {
            Name = name;
            Id = GenerateNewId();   
        }

        private int _id;
        public int Id
        {
            get 
            { 
                return _id; 
            }
            private set 
            { 
                _id = value;
          
            }
        }
        public string Name { get; set; }

        private static int countBook = 0;

        private static int GenerateNewId()
        {
            countBook++;
            return countBook;
        }

    }
}
