using System;
using System.Collections.Generic;
using System.Text;
using Unity.Ioc.Framework;

namespace ClassLibraryTest1
{
    [ServiceImplementation(Name ="ClassTest3")]
    public class ClassTest3Impl : InterfaceA
    {
        public string TestMethodA()
        {
            return "ClassTest3Impl.TestMethodA";
        }
    }
}
