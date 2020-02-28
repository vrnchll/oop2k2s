using System;
using System.Collections.Generic;
using System.Text;

namespace patterns_3
{
    class Memento
    {
        public int Power { get; private set; }
        public int Arrow { get; private set; }

        public Memento(int arrow, int power)
        {
            this.Power = power;
            this.Arrow = arrow;
        }
    }
    class GameHistory //caretaker
    {
        public Stack<Memento> History { get; private set; }
        public GameHistory()
        {
            History = new Stack<Memento>();
        }
    }
   
    class Knight // originator
    {
        private int power = 100;
        private int arrow = 10;
        public void FireShoot()
        {
            if (arrow > 0)
            {
                arrow--;
                Console.WriteLine("Пииу. Осталось {0} стрел", arrow);
            }
            else
                Console.WriteLine("Game over--Стрел больше нет.");
        }
        public void PowerDeath()
        {
            if (power > 0)
            {
                power--;
                Console.WriteLine("Ой. Осталось {0} силы", power);
            }
            else
                Console.WriteLine("Game over");
        }
        public void SetMemento(Memento memento)  // восстановление состояния
        {
            this.arrow = memento.Arrow;
            this.power = memento.Power;
            Console.WriteLine("Восстановление игры. Параметры: {0} стрел, {1} силы", arrow, power);
        }
        public Memento CreateMemento() //cохранение состояния
        {
            Console.WriteLine("Сохранение игры. Параметры: {0} стрел, {1} силы", arrow, power);
            return new Memento(arrow,power);
        }
    }
}
