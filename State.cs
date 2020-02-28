using System;
using System.Collections.Generic;
using System.Text;

namespace patterns_3
{
    
    abstract class State
        {
            public abstract void HandleInput(MyObject redridhood);
        };
    class Stand : State
    {
        public override void HandleInput(MyObject redridhood)
        {
            redridhood.State = new Fire();
            Console.WriteLine("Стоит!");
        }
    }
    class Jump : State
    {
        public override void HandleInput(MyObject redridhood)
        {
            redridhood.State = new Stand();
            Console.WriteLine("Огоонь!");

        }
        
    }
   
    class Fire : State
    {
        public override void HandleInput(MyObject redridhood)
        {
            redridhood.State = new Jump();
            Console.WriteLine("Прыжоок!");
        }
    }
    class MyObject
        {
        public State State { get; set; }
        public MyObject(State state)
        {
            this.State = state;
        }
        public void Request()
        {
            this.State.HandleInput(this);
        }
    };
    }

