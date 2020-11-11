using System;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BOOK LOTR = new BOOK();
            LOTR.SetBook("idiot", 1);
        }
    }
    class BOOK
    {
        public string title;
        private int pages;
        public void SetBook(string a, int b)
        {
            title = a;
            pages = b;

            Console.WriteLine(title + " " + pages);
        }
    }
}