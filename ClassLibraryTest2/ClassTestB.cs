using System;
using System.Collections.Generic;
using System.Text;
using Unity.Ioc.Framework;

namespace ClassLibraryTest2
{
    [ServiceImplementation]
    public class ClassTestB : InterfaceTestB
    {
        public string TestMethodB()
        {
            return "ClassTestB.TestMethodB";
        }
    }
}
