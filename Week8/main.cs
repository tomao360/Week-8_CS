using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDll;
using Eli_Lib;

namespace Week8.Lesson2_16_11_22
{
    internal class main
    {
        static void Main(string[] args)
        {
            Week8Lesson2_16_11_22 week8Lesson2_16_11_22 = new Week8Lesson2_16_11_22();
            week8Lesson2_16_11_22.RunProperty();

            RunStudent run = new RunStudent();
            run.Runner();

            //--------Class Library-------
            //My dll
            myDll getFromDll = new myDll();
            for (int i = 0; i < 10; i++)
            {
               
                Console.WriteLine(getFromDll.RandomNum());
            }
            Console.WriteLine(getFromDll.getSentence());

            //Someone else's dll
            rnd_encouragement elisDll = new rnd_encouragement();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}", elisDll.getRandomNumber());
            }
            Console.WriteLine("{0}", elisDll.strEncouragement());


            Week8.Lesson3_17_11_22.RunnerBook book = new Week8.Lesson3_17_11_22.RunnerBook();
            book.Run();

            Week8.Lesson3_Static_17_11_22.RunnerItem item = new Week8.Lesson3_Static_17_11_22.RunnerItem();
            item.Run();
        }
    }
}
