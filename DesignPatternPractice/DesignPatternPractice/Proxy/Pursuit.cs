using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice
{
    public class Pursuit : IGiveGift
    {
        ShowGirl showGirl;
        public Pursuit(ShowGirl showGirl)
        {
            this.showGirl = showGirl;
        }
        public void GiveChocolate()
        {
            Console.WriteLine(showGirl.Name + "give chocolate");
        }

        public void GiveDolls()
        {
            Console.WriteLine(showGirl.Name + "give doll");
        }

        public void GiveFlowers()
        {
            Console.WriteLine(showGirl.Name + "give flower");
        }
    }
}
