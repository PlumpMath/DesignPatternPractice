using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice
{
    public class Boss : ISubject
    {
        public delegate void MyEventHandler();
        ////private List<Observer> observers = new List<Observer>();
        private string action;
        public event MyEventHandler Update;
        public string SubjectState { get; set; }
        //{
        //    get { return action; }
        //    set { action = value; }
        //}

        ////public void Attach(Observer observer)
        ////{
        ////    observers.Add(observer);
        ////}

        ////public void Detach(Observer observer)
        ////{
        ////    observers.Remove(observer);
        ////}

        public void Notify()
        {
            ////foreach (var o in observers)
            ////{
            ////    o.Update();
            ////}
            Update();
        }
    }
}
