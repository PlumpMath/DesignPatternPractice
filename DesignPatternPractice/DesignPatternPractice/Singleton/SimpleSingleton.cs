using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice
{
    public sealed class SimpleSingleton
    {
        private static SimpleSingleton instance = null;
        private static readonly object padlock = new object();

        SimpleSingleton() 
        { 
        }

        public static SimpleSingleton Instance 
        {
            get 
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SimpleSingleton();
                    }
                }

                return instance;
            }
        }

        // Bad code! Do not use!
        public static SimpleSingleton Instance2
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new SimpleSingleton();
                        }
                    } 
                }

                return instance;
            }
        }
    }
}
