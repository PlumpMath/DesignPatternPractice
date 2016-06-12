using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice
{
    public sealed class WithoutLockSingleton
    {
        private static readonly WithoutLockSingleton instance = new WithoutLockSingleton();

        static WithoutLockSingleton() 
        { 
        }

        private WithoutLockSingleton() 
        { 
        }

        public static WithoutLockSingleton Instance 
        {
            get 
            {
                return instance;
            }
        }
    }
}
