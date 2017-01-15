using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Ioc.Framework.Test.Interface;

namespace Unity.Ioc.Framework.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ITestInterface service = ServiceLocator.GetInstance<ITestInterface>();
            service.TestMethod("Hello world!");
            Console.ReadKey();
        }
    }
}
