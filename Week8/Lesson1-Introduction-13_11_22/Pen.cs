using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8
{
    internal class Pen
    {
        public string color;
        public int length;
        public double tipLength;

       /* public Pen(string color)
        {
            this.color = color;
        }*/

        public void PrintPen()
        {
            string str = "Pen color:" + color + ", Pen length:" + length + ", Pen tip length:" + tipLength;
            Console.WriteLine(str);
        }

        public void SetRandonSize()
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            int randomNum = rand.Next(10, 25);
            length = randomNum;
        }

        public void SetRandonTipSize()
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            double randomNum = rand.NextDouble();
            tipLength = randomNum;
        }

        public void SetRandonColor()
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            int randomNum = rand.Next(1, 4);

            if (randomNum == 1)
            {
                string str = "Red";
                color = str;
            }
            else if (randomNum == 2)
            {
                string str = "Black";
                 color = str;
            }
            else
            {
                string str = "Blue";
                 color = str;
            }
        }

    }
}
