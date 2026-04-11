using System;
using System.Collections.Generic;
using System.Text;
using Unity.Ioc.Framework;

namespace ClassLibraryTest2
{
    [ServiceImplementation]
    public class ClassTestA : InterfaceTestA
    {
        public string TestMethodA()
        {
            return "ClassTestA.TestMethodA";
        }
    }
}
