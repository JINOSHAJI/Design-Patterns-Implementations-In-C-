using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Implementations.Singleton
{
    // fully lazy instantiation and threadsafe implementation
    public class LazySingleton
    {
        private LazySingleton()
        {
        }

        //type initializer in .net
        // C# compiler guranty that type initilizer instantiated lazly
        public static LazySingleton Instance
        {
            get { return Nested.instance; }
        }

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly LazySingleton instance = new LazySingleton();
        }
    }



    // Alternative implementation using .NET 4's Lazy<T> type

    public class Lazy2Singleton
    {
        private static readonly Lazy<Lazy2Singleton> lazy =
            new Lazy<Lazy2Singleton>(() => new Lazy2Singleton());

        public static Lazy2Singleton Instance { get { return lazy.Value; } }

        private Lazy2Singleton()
        {
        }
    }
}
