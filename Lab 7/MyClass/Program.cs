using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            //b1.SetBook("Пушкин А.С.", "Капитанская дочка", "Вильямс", 123, 2018);

            Book.SetPrice(12);

            //b1.Print();

            //Console.WriteLine("\n Итоговая стоимость аренды за 3 дня: {0} р.", b1.PriceBook(3));

            //Book b2 = new Book("Толстой Л.Н.", "Война и Мир", "Наука и жизнь", 1234, 2013, 101, true);
            //b2.TakeItem();
            //b2.Print();

            Book b3 = new Book("Лермонтов М.Ю.", "Мцыри");
            //b3.Print();

            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);
            //mag1.Print();

            Publisher publ = new Publisher("Наука и жизнь", "nauka@mail.ru", 1234, new DateTime(2014, 12, 14));

            Book b2 = new Book("Толстой Л.Н.", "Война и Мир", publ, 1234, 2013, 101, true);

            b2.Print();
        }
    }
}
