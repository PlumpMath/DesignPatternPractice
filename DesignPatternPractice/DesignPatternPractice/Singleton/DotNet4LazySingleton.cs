using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice
{
    public sealed class DotNet4LazySingleton
    {
        private static readonly Lazy<DotNet4LazySingleton> lazy = new Lazy<DotNet4LazySingleton>(() => new DotNet4LazySingleton());

        public static DotNet4LazySingleton Instance 
        {
            get 
            {
                return lazy.Value;
            }
        }

        private DotNet4LazySingleton() 
        { 
        }
    }
}
