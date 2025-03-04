/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HOMETASK4
{
    internal class Book
    {
        public string Title;
        public string Author;
        public string ISBN;
        public double Price;
        public Book() { }
        void DisplayBookInfo()
        {
            Console.WriteLine("Book Info is Displayed here : \n");
            Console.WriteLine($"Title : {Title} \n");
            Console.WriteLine($"Author : {Author} \n");
            Console.WriteLine($"ISBN : {ISBN} \n");
            Console.WriteLine($"Price : {Price} \n");
        }
        void ApplyDiscount(double percentage)
        {
            if (percentage < 0 || percentage > 100)
            {
                Console.WriteLine("Discount percentage should be between 0 and 100");
                return;
            }
            double discountPrice = Price * (percentage / 100);
            Price = Price - discountPrice;
        }

        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Title = "It ends with US";
            book1.Author = "Colleen Hoover";
            book1.ISBN = "2345";
            book1.Price = 345;
            book1.DisplayBookInfo();

            Console.WriteLine("After applying discount : ");

            book1.ApplyDiscount(20);
            book1.DisplayBookInfo();
        }
    }
}*/
