using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRconstraction
{
    internal class Cat : Animal
    {
        private int lives;
        private bool classActivities = true;
        public int Lives
        {
            get { return lives; }
            set
            {
                if (value < 1 || value > 9)
                {
                    Console.WriteLine("Ошибка, некоректное значение");
                    classActivities = false;

                }
                lives = value;
            }
        }
        public Cat(string name, int lives) : base(name)
        {
            this.lives = lives;
        }
        public Cat(string name) : this(name, 9)
        {
        }
        public void Meow()
        {
            if (lives < 1||!classActivities)
            {
                Console.WriteLine("Недостаточно жизней");
                return;
            }
            lives-=1;
            Console.WriteLine($"{Name} мяукнул, осталось жизней {Lives} ");
        }
    }
}
