using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1204016

{
    class Program_1204016
    {
        static void Main(string[] args)
        {


            book_1204016 mybook = new book_1204016("Book", "C# Object Oriented Solution", "300");
            DVD_1204016 dvd = new DVD_1204016("Ethernal Sunshine Of The Spotless Mind", "145");

            Console.WriteLine("Product 1 is a {0} called \"{1}\" and has {2} pages", mybook.MyType, mybook.MyTitle, mybook.PageCount);
            Console.WriteLine("Product 1 is a {0} called \"{1}\" and has {2} minutes duration", dvd.MyType, dvd.MyTitle, dvd.Duration);
        }
    }
}


