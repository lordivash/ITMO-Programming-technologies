using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    delegate void ProcessMagazineDelegate(Magazine mag, DateTime dt);

    class Magazine : Item, IPubs
    {
        public string Volume { get; set; }
        public int Number { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public bool IfSubs { get; set; }

        public Magazine() { }

        public Magazine(string volume, int number, string title, int year,
            long invNumber, bool avaliable) : base(invNumber, avaliable)
        {
            this.Volume = volume;
            this.Number = number;
            this.Title = title;
            this.Year = year;
        }

        public override string ToString()
        {
            string bs = String.Format
                (
                "\nЖурнал:" +
                "\nТом: {0}" +
                "\nНомер {1}" +
                "\nНазвание {2}" +
                "\nГод выпуска {3}" +
                "\nСтатус подписки {4}",
                Volume, Number, Title, Year, IfSubs
                );
            return bs;
        }

        public override void Print()
        {
            Console.WriteLine(this);
            base.Print();
        }

        public override void Return()
        {
            avaliable = true;
        }

        public static event ProcessMagazineDelegate Subscribe = null;

        public void Subs()
        {
            IfSubs = true;
            if (Subscribe != null) Subscribe(this, DateTime.Now);
        }
    }
}
