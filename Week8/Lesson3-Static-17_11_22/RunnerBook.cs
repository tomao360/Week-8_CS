using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8.Lesson3_17_11_22
{
    internal class RunnerBook
    {
        public void Run()
        {
            /*Book book1 = new Book("Harry Potter");
            Console.WriteLine("Book Name:'{0}', Book Id:{1}", book1.Name, book1.Id);
            Book book2 = new Book("The Little Prince");
            Console.WriteLine("Book Name:'{0}', Book Id:{1}", book2.Name, book2.Id);*/

            Book book1 = Book.Create("Harry Potter");
            Book book2 = Book.Create("The Little Prince");
            Book book3 = Book.Create("Hunger Games");
            Book book4 = Book.Create("Aladin");
            Book book5 = Book.Create("Hasamba");
        }
    }
}
