using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice
{
    public class StockObserver
    {
        private string name;
        private ISubject sub;
        public StockObserver(string name, ISubject sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public void Update()
        {
            Console.WriteLine("{0} {1} plz close stock, go to work!", sub.SubjectState, name);
        }
    }
}
