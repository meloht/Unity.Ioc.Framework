using ClassLibraryTest1;
using ClassLibraryTest2;

namespace Unity.Ioc.Framework.Testx
{
    public class UnitTestIoC
    {


        [Fact]
        public void Test1()
        {
            InterfaceA service = ServiceLocator.GetInstance<InterfaceA>("ClassTest1");
            Assert.NotNull(service);
            Assert.Equal("ClassTest1Impl.TestMethodA", service.TestMethodA());

            InterfaceA service2 = ServiceLocator.GetInstance<InterfaceA>("ClassTest2");
            Assert.NotNull(service2);
            Assert.Equal("ClassTest2Impl.TestMethodA", service2.TestMethodA());

            InterfaceA service3 = ServiceLocator.GetInstance<InterfaceA>("ClassTest3");
            Assert.NotNull(service3);
            Assert.Equal("ClassTest3Impl.TestMethodA", service3.TestMethodA());
        }

        [Fact]
        public void Test2()
        {
            var service = ServiceLocator.GetAllInstances<InterfaceA>();
            Assert.NotNull(service);
            Assert.Equal(3, service.Count());
        }

        [Fact]
        public void Test3()
        {
            var service = ServiceLocator.GetInstance<InterfaceTestA>();
            Assert.NotNull(service);
            Assert.Equal("ClassTestA.TestMethodA", service.TestMethodA());

            var service2 = ServiceLocator.GetInstance<InterfaceTestB>();
            Assert.NotNull(service2);
            Assert.Equal("ClassTestB.TestMethodB", service2.TestMethodB());
        }

        [Fact]
        public void Test4()
        {
            var service1 = ServiceLocator.GetInstance<InterfaceThread>();
            Assert.NotNull(service1);
            int id1 = service1.GetThreadId();

            InterfaceThread service2 = null;
            int id2 = 0;
            Thread thread = new Thread(() =>
            {
                service2 = ServiceLocator.GetInstance<InterfaceThread>();
                id2 = service2.GetThreadId();
            });
            thread.Start();
            thread.Join();
            Thread.Sleep(50);
            Assert.False(object.ReferenceEquals(service1, service2));
            Assert.NotEqual(id1, id2);

            var service3 = ServiceLocator.GetInstance<InterfaceThread>();
            Assert.True(object.ReferenceEquals(service1, service3));
        }

        [Fact]
        public void Test5()
        {
            var service1 = ServiceLocator.GetInstance<InterfaceSingleton>();
            Assert.NotNull(service1);

            var service2 = ServiceLocator.GetInstance<InterfaceSingleton>();
            Assert.NotNull(service2);

            Assert.True(object.ReferenceEquals(service1, service2));

            var service3 = ServiceLocator.GetInstance<InterfaceSingleton>();
            Assert.NotNull(service3);

            Assert.True(object.ReferenceEquals(service1, service3));
        }

        [Fact]
        public void Test6()
        {
            var service = ServiceLocator.GetInstance<InterfaceTestA>();
            Assert.NotNull(service);


            var service2 = ServiceLocator.GetInstance<InterfaceTestA>();
            Assert.NotNull(service2);

            Assert.False(object.ReferenceEquals(service2, service));
        }
      
    }
}
