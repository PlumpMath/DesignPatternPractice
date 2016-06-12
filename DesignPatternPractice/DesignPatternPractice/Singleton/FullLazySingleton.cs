using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice
{
    public sealed class FullLazySingleton
    {
        private FullLazySingleton()
        {
        }

        public static FullLazySingleton Instance 
        {
            get 
            {
                return Nested.instance;
            }
        }

        private class Nested 
        {
            static Nested() 
            { 
            }

            internal static readonly FullLazySingleton instance = new FullLazySingleton();
        }
    }
}
