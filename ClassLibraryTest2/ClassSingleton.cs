using System;
using System.Collections.Generic;
using System.Text;
using Unity.Ioc.Framework;

namespace ClassLibraryTest2
{
    [ServiceImplementation(ResolveLifetime = Lifetime.Singleton)]
    public class ClassSingleton : InterfaceSingleton
    {
        public string TestMethod()
        {
            return "ClassSingleton.TestMethod";
        }
    }
}
