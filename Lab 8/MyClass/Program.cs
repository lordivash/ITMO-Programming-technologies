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
            Publisher publ = new Publisher("Наука и жизнь", "nauka@mail.ru", 1234, new DateTime(2014, 12, 14));

            //Book b1 = new Book("Пушкин А.С.", "Капитанская дочка", publ, 123, 2018, 2, true);
            //Book b2 = new Book("Толстой Л.Н.", "Война и Мир", publ, 1234, 2013, 1, true);
            //Book b3 = new Book("Лермонтов М.Ю.", "Мцыри", publ, 1234, 2014, 3, true);

            Audit.RunAudit();

            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 4, true);
            mag1.Subs();

            Audit.StopAudit();

            Magazine mag2 = new Magazine("О неживом", 2, "Материя", 2014, 6, true);
            mag2.Subs();

            List<Item> itlist = new List<Item>();
            itlist.AddRange(new Item[] { /*b1, b2, b3,*/ mag1, mag2 });
            itlist.Sort();

            Console.WriteLine("\nСортировка по инвентарному номеру\n");
            foreach(Item x in itlist)
            {
                x.Print();
            }
        }
    }
}
