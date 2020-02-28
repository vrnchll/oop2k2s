using System;
using System.Collections.Generic;
using System.Text;

namespace patterns_3
{
    interface ICommand
    {
        void Execute();
        void Undo();
    };
    public class RedRidHood
    {
        public RedRidHood()
        {
            Console.WriteLine("Красная шапочка");
        }
        public void Operation()
        { }
        public void Jump()
        {
            Console.WriteLine("Прыгает!");
        }
        public void FireGun()
        {
            Console.WriteLine("Стреляет!");
        }
        public void Exit()
        {
            Console.WriteLine("Отмена!");
        }
    }
    class JumpCommand : ICommand
    {
        RedRidHood redRidHood;
        public JumpCommand(RedRidHood r)
        {
            redRidHood = r;
        }
        public void Execute() { redRidHood.Jump(); }
        public void Undo() { redRidHood.Exit(); }
    };
    class FireCommand : ICommand
    {
        RedRidHood redRidHood;
        public FireCommand(RedRidHood r)
        {
            redRidHood = r;
        }
        public void Execute() { redRidHood.FireGun(); }
        public void Undo() { redRidHood.Exit(); }
       
    };
    class Invoker
    {
        ICommand command;
        public void SetCommand(ICommand com)
        {
            command = com;
        }
        public void JumpOrFire()
        {
            command.Execute();
        }
        public void Cancel()
        {
            command.Undo();
        }
    }

}

