using Unity.Ioc.Framework;

namespace ClassLibraryTest1
{
    [ServiceImplementation(Name ="ClassTest1")]
    public class ClassTest1Impl : InterfaceA
    {
        public string TestMethodA()
        {
            return "ClassTest1Impl.TestMethodA";
        }
    }
}
