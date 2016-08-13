using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice
{
    public interface ISubject
    {
        ////void Attach(Observer observer);

        ////void Detach(Observer observer);

        void Notify();

        string SubjectState { get; set; }
    }
}
