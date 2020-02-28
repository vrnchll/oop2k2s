using System;
using System.Collections.Generic;
using System.Text;

namespace patterns_3
{
    interface IKnight //наблюдаемый объект
    {
        void AddObserver(IRedRigHood r);
        void RemoveObserver(IRedRigHood r);
        void NotifyObservers();
    }
    class KnightObservable : IKnight // коллекция наблюдателей
    {
        KnightInfo kInfo; // информация о торгах
        private List<IRedRigHood> observers;
        public KnightObservable()
        {
            observers = new List<IRedRigHood>();
            kInfo = new KnightInfo();
        }
        public void AddObserver(IRedRigHood r)
        {
            observers.Add(r);
        }

        public void RemoveObserver(IRedRigHood r)
        {
            observers.Remove(r);
        }

        public void NotifyObservers()
        {
            foreach (IRedRigHood observer in observers)
                observer.Update(kInfo);
        }
    }

    class KnightInfo
    {
        public int Power { get; set; }
       public int Arrow { get; set; }
    }
    interface IRedRigHood //наблюдатель
    {
        void Update(Object ob);
    }
    class RidRedObserver : IRedRigHood
    {
        public string Name { get; set; }
        IKnight knight;
        public RidRedObserver(string name, IKnight obs)
        {
            this.Name = name;
            knight = obs;
            knight.AddObserver(this);
        }
        public void Update(object ob)
        {
            KnightInfo kInfo = (KnightInfo)ob;

            if (kInfo.Power > 0)
                Console.WriteLine("Рыцарь {0} в бою;  Сила: {1}", this.Name, kInfo.Power);
            else
                Console.WriteLine("Погиб");
        }
        public void StopFight()
        {
            knight.RemoveObserver(this);
            knight = null;
        }
   
        
    }
}
