using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice
{
    public class ConcreteObserver : Observer
    {
        private string name;
        private string observerState;

        private ConcreteSubject subject;

        private ConcreteSubject Subject { get; set; }
        public ConcreteObserver(ConcreteSubject csubject, string name)
        {
            this.subject = csubject;
            this.name = name;
        }
        public override void Update()
        {
            observerState = this.subject.SubjectState;
            Console.WriteLine("Observer {0}'s new state is {1}", this.name, this.observerState);
        }
    }
}
