using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Implementations.Singleton
{
    // This implementaion is not thread safe
    public class Singleton
    {
        private static Singleton _instance;
        public Singleton()
        {

        }

        public static Singleton Instance {

            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }

        public void DoStuff()
        {
            Console.WriteLine("Singleton DoStuff");
        }
    }

    public class SampleUsage
    {
        public void SomeMethod()
        {
            // Call Singleton's DoStuff() method
            Singleton.Instance.DoStuff();
                  
                    //Alternative

            // Assign to another variable then  Call Singleton's DoStuff() method
            Singleton myObject = Singleton.Instance;
            myObject.DoStuff();

            // Pass as parameter
            SomeOtherMethod(Singleton.Instance);
        }

        private void SomeOtherMethod(Singleton singleton)
        {
            singleton.DoStuff();
        }
    }
}
