using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice
{
    // Bad code! Do not use!
    public sealed class NoThreadSingleton
    {
        private static NoThreadSingleton instance = null;

        private NoThreadSingleton()
        {
        }

        public static NoThreadSingleton Instance 
        {
            get 
            {
                if (instance == null) 
                {
                    instance = new NoThreadSingleton();
                }

                return instance;
            }
        }
    }
}
