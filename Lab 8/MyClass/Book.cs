using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    class Book : Item, IPr
    {
        public string Author { get; set; }
        public string Title { get; set; }
        //public string Publisher { get; set; }
        public Publisher Publ { get; set; }
        public int Pages { get; set; }
        public int Year { get; set; }
        public bool returnSrok { get; private set; }

        private static double price;
        public static double Price
        {
            get { return price; }
            set { if (value >= 9) price = value; }
        }

        static Book()
        {
            Price = 9;
        }

        public Book() { }

        public Book(string author, string title)
        {
            this.Author = author;
            this.Title = title;
        }

        public Book(string author, string title, Publisher publisher,
            int pages, int year)
        {
            this.Author = author;
            this.Title = title;
            this.Publ = publisher;
            this.Pages = pages;
            this.Year = year;
        }

        public Book(string author, string title, Publisher publisher,
            int pages, int year, long invNumber, bool avaliable) : base(invNumber, avaliable)
        {
            this.Author = author;
            this.Title = title;
            this.Publ = publisher;
            this.Pages = pages;
            this.Year = year;
        }

        public void SetBook(string author, string title, Publisher publisher,
            int pages, int year)
        {
            this.Author = author;
            this.Title = title;
            this.Publ = publisher;
            this.Pages = pages;
            this.Year = year;
        }

        public void SetPrice(double price)
        {
            Book.Price = price;
        }

        public override string ToString()
        {
            string bs = String.Format
                (
                "\nКнига:" +
                "\nАвтор: {0}" +
                "\nНазвание: {1}" +
                "\nГод издания: {2}" +
                "\n{3} стр." +
                "\nСтоимость аренды: {4}" +
                "\nИздательство {5}",
                Author, Title, Year, Pages, Price, Publ.ToString()
                );
            return bs;
        }

        public override void Print()
        {
            Console.WriteLine(this);
            base.Print();
        }

        public double PriceBook(int s)
        {
            double cust = s * price;
            return cust;
        }

        public void ReturnSrok()
        {
            returnSrok = true;
        }

        public override void Return()
        {
            if (returnSrok == true)
                avaliable = true;
            else
                avaliable = false;
        }
    }
}
