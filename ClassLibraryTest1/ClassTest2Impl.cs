using System;
using System.Collections.Generic;
using System.Text;
using Unity.Ioc.Framework;

namespace ClassLibraryTest1
{
    [ServiceImplementation(Name ="ClassTest2")]
    public class ClassTest2Impl : InterfaceA
    {
        public string TestMethodA()
        {
           return "ClassTest2Impl.TestMethodA";
        }
    }
}
