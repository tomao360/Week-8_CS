using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8.Lesson2_16_11_22
{
    internal class Week8Lesson2_16_11_22
    {
        public void RunProperty()
        {
            Car car1 = new Car();
            car1.Firm = "Subaro";
            car1.KM = 10;
            car1.Id = 12345;

            car1.KM += 30;
            car1.KM += 100;

            car1.KM -= +45;
            car1.KM = -349;

            //car1.Firm = "Mitsubishi";
            //car1.Firm = "Mercedes";

            Car car2 = new Car();
            car2.Firm = "Mazda";
            car2.Id = 6789;
        }
    }
   

    class Car
    {
        public Car() //constructor
        {
           
        }

        public int KM;
        public int Id;

        private int changedName = 0;

        private string _firm;
        public string  Firm
        {
            get
            {
                return "The Best Car: " + _firm;
            }

            set

            {
                if (value == "*")
                {
                    changedName = 0;
                }

                if (changedName < 3)
                {
                    _firm = value;
                    changedName++;
                }
            }
        }
    }
}
