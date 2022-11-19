using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8.Lesson2_16_11_22
{
    internal class RunStudent
    {
       public void Runner()
        {
            Student s1 = new Student("123");
            s1.Name = "Tamara";
            s1.Address = "Hadera";
            s1.Phone = "052222222";
            s1.Save();
            s1.Load();
        }
    }
}
