using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8.Lesson3_17_11_22;

namespace Week8.Lesson3_Static_17_11_22
{
    internal class RunnerItem
    {
        public void Run()
        {
            //Questions 5-6
            Item[] list = new Item[2];
            list[0] = new Drink(12345);
            list[1] = new Food(67891);

            //Questions 7-11
            Item[] list2 = new Item[10];

            list2[0] = new Drink(1);
            list2[0].Name = "Coffee";
            list2[1] = new Drink(2);
            list2[1].Name = "Cola";
            list2[2] = new Drink(2);
            list2[2].Name = "Sprite";
            list2[3] = new Drink(3);
            list2[3].Name = "Fanta";
            list2[4] = new Drink(4);
            list2[4].Name = "Pepsi";

            list2[5] = new Food(5);
            list2[5].Name = "Pizza";
            list2[6] = new Food(6);
            list2[6].Name = "Ravioli";
            list2[7] = new Food(7);
            list2[7].Name = "Pasta";
            list2[8] = new Food(8);
            list2[8].Name = "French Fries";
            list2[9] = new Food(9);
            list2[9].Name = "Sushi";

            for (int i = 0; i < list2.Length; i++)
            {
                Console.WriteLine("Item Id:{0} Item Name:{1}", list2[i].Id, list2[i].Name);
            }

            //Questions 12-14
            Item[] list3 = new Item[100];

            Random random = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < 100; i++)
            {
                int randomNum = random.Next(1, 3);
                if (randomNum == 1)
                {
                    Drink drink = new Drink(i);
                    Console.WriteLine("Please enter the drink's Name: ");
                    drink.Name = Console.ReadLine();
                    Console.WriteLine("Please enter the drink's Price: ");
                    string str = Console.ReadLine();
                    drink.Price = int.Parse(str);
                    Console.WriteLine("Please enter the drink's Liquid Color: ");
                    drink.LiquidColor = Console.ReadLine();

                    //Console.WriteLine("Item Id:{0} Item Name:{1} Item Price:{2} Item Liquid Color:{3}", drink.Id, drink.Name, drink.Price, drink.LiquidColor);

                    list3[i] = drink;
                }
                if (randomNum == 2)
                {
                    Food food = new Food(i);
                    Console.WriteLine("Please enter the food's Name: ");
                    food.Name = Console.ReadLine();
                    Console.WriteLine("Please enter the food's Price: ");
                    string str = Console.ReadLine();                   
                    food.Price = int.Parse(str);
                    Console.WriteLine("Please enter the food's weight: ");
                    str = Console.ReadLine();
                    food.Weight = int.Parse(str);

                    //Console.WriteLine("Item Id:{0} Item Name:{1} Item Price:{2} Item Liquid Color:{3}", food.Id, food.Name, food.Price, food.Weight);

                    list3[i] = food;
                }

                Console.WriteLine("Item Id:{0}", list3[i].Id);
            }

            //Question 16
            for (int i = 0; i < list3.Length; i++)
            {
                if (list3[i] is Drink)
                {
                    Drink drink = (Drink)list3[i];
                    Console.WriteLine("Item Id:{0} Item Name:{1} Item Price:{2} Item Liquid Color:{3}", drink.Id, drink.Name, drink.Price, drink.LiquidColor);
                }
                else if (list3[i] is Food)
                {
                    Food food = (Food)list3[i];
                    Console.WriteLine("Item Id:{0} Item Name:{1} Item Price:{2} Item Liquid Color:{3}", food.Id, food.Name, food.Price, food.Weight);
                }
            }
        }
    }
}
