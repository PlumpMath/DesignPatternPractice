using System;

namespace DesignPatternPractice
{
    public class Proxy : IGiveGift
    {
        Pursuit gg;
        public Proxy(ShowGirl showGirl)
        {
            gg = new Pursuit(showGirl);
        }
        public void GiveChocolate()
        {
            gg.GiveChocolate();
        }

        public void GiveDolls()
        {
            gg.GiveDolls();
        }

        public void GiveFlowers()
        {
            gg.GiveFlowers();
        }
    }
}
