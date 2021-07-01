using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    abstract class Item : IComparable
    {
        //Инвентарный номер
        protected long invNumber;
        protected bool avaliable;

        public Item()
        {
            this.avaliable = true;
        }

        public Item(long invNumber, bool avaliable)
        {
            this.invNumber = invNumber;
            this.avaliable = avaliable;
        }

        public bool IsAvailable()
        {
            if (avaliable == true)
                return true;
            else
                return false;
        }

        public long GetInvNumber()
        {
            return invNumber;
        }

        private void Take()
        {
            avaliable = false;
        }

        public abstract void Return();

        public void TakeItem()
        {
            if (this.IsAvailable())
                this.Take();
        }

        public virtual void Print()
        {
            Console.WriteLine
                (
                "Состояние единицы хранения:" +
                "\nИнвентарный номер: {0}" +
                "\nНаличие: {1}",
                invNumber, avaliable
                );
        }

        int IComparable.CompareTo(object obj)
        {
            Item it = (Item)obj;
            if (this.invNumber == it.invNumber) return 0;
            else if (this.invNumber > it.invNumber) return 1;
            else return -1;
        }
    }
}
