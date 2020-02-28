using System;

namespace patterns_3
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Кнопка q-Стреляет, кнопка w-Прыгает:");
            string choice1 = Console.ReadLine();
            switch (choice1)
            {
                case "q":
                    Invoker invoke = new Invoker();
        RedRidHood red = new RedRidHood();
        invoke.SetCommand(new FireCommand(red));
                    invoke.JumpOrFire();
                    break;
                case "w":
                    Invoker invoke1 = new Invoker();
        RedRidHood red1 = new RedRidHood();
        invoke1.SetCommand(new JumpCommand(red1));
                    invoke1.JumpOrFire();
                    break;
                default:
                    Console.WriteLine("Неверное команда, попробуйте еще раз");
                    break;
            

}
            Console.WriteLine("");

            //2
            MyObject redridhood = new MyObject(new Jump());
            redridhood.Request();
            redridhood.Request();
            redridhood.Request();


            Console.WriteLine("");

            //3
            Knight knight = new Knight();
            knight.FireShoot();
            GameHistory gameHistory = new GameHistory();
            gameHistory.History.Push(knight.CreateMemento());
            knight.FireShoot();
            gameHistory.History.Push(knight.CreateMemento());
            knight.PowerDeath();
            gameHistory.History.Push(knight.CreateMemento());
            knight.PowerDeath();
            knight.SetMemento(gameHistory.History.Pop());

            Console.WriteLine("");

            //4
            KnightObservable knob = new KnightObservable();
            RidRedObserver ridred = new RidRedObserver("Рыцарь", knob);
            ridred.StopFight();
          

            Console.ReadKey();
        }
    }
}
