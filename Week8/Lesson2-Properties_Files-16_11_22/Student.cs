using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week8.Lesson2_16_11_22
{
    internal class Student
    {
        public Student(string id)
        {
            Id = id;
        }

        private string _id;
        public string Id 
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

        private string name;
        public string Name
        {

            get { return name; }

            set 
            {
                if (value.Length > 15)
                {
                    
                    name = value.Substring(0, 15);
                  
                }
                else
                {
                    name = value;
                }

               
            }
        }
        public string Address { get; set; }
        public string Phone { get; set; }

        public void Save()
        {
            string[] str = new string[4];
            str[0] = Id;
            str[1] = Name;
            str[2] = Address;
            str[3] = Phone;

            File.WriteAllLines(Id + ".txt", str);
        }

        public void Load()
        {
            string[] str = new string[4];
            if(File.Exists(Id + ".txt"))
            {
                str = File.ReadAllLines(Id + ".txt");
            }
            else
            {
                Console.WriteLine("File Not Exist");
            }
        }

    }
}
