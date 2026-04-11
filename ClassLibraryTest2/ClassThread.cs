using System;
using System.Collections.Generic;
using System.Text;
using Unity.Ioc.Framework;

namespace ClassLibraryTest2
{
    [ServiceImplementation(ResolveLifetime = Lifetime.PerThread)]
    public class ClassThread : InterfaceThread
    {
        public int GetThreadId()
        {
           return Thread.CurrentThread.ManagedThreadId;
        }
    }
}
