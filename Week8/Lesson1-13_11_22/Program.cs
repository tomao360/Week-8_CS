using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8
{
    internal class Program
    {
        static void Main_1(string[] args)
        {
            /*string str = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(str);
            }

            string str2 = Console.ReadLine();
            int num = int.Parse(str2);

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(str);
            }

            string str3 = Console.ReadLine();
            string strLoop = "";
            for (int i = 0; i < num; i++)
            {
                strLoop += str3;
            }

            Console.WriteLine(strLoop); 
            */
         

            Pen pen1 = new Pen();
            pen1.SetRandonColor();
            pen1.SetRandonTipSize();
            pen1.SetRandonSize();
            pen1.PrintPen();
            
            Pen pen2 = new Pen();
            pen2.SetRandonColor();
            pen2.SetRandonTipSize();
            pen2.SetRandonSize();
            pen2.PrintPen();
           
            Pen pen3 = new Pen();
            pen3.SetRandonColor();
            pen3.SetRandonTipSize();
            pen3.SetRandonSize();
            pen3.PrintPen();

            Random rand = new Random();
           // int randomNum = rand.Next(100);
           // Console.WriteLine(randomNum);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rand.Next(100));
            }


            int randomNum;
            int above500 = 0;
            int below500 = 0;

            for (int i = 0; i < 1000; i++)
            {
                randomNum = rand.Next(99, 999);
                if (randomNum > 500)
                {
                    above500++;
                }
               else
                {
                    below500++;
                }
            }

            Console.WriteLine("Above 500:" + above500 + " Below 500:" + below500);

            int COUNT = 1000;
            Pen[] PenArr = new Pen[COUNT];
           for (int i = 0; i < PenArr.Length; i++)
            {
                PenArr[i] = new Pen();
                PenArr[i].SetRandonColor();
                PenArr[i].SetRandonSize();
                PenArr[i].SetRandonTipSize();
                PenArr[i].PrintPen();
            }

            PenBooster penBoster = new PenBooster(PenArr);
            penBoster.PrintBlue();
            penBoster.PrintBlack();
            penBoster.PrintRed();
            Console.ReadLine();

        }
    }
}
