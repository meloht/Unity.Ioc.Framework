using ClassLibraryTest1;
using ClassLibraryTest2;

namespace Unity.Ioc.Framework.Test
{
    [TestClass]
    public sealed class TestIoC
    {
        [TestMethod]
        public void TestMethod1()
        {
            InterfaceA service = ServiceLocator.GetInstance<InterfaceA>("ClassTest1");
            Assert.IsNotNull(service);
            Assert.AreEqual("ClassTest1Impl.TestMethodA", service.TestMethodA());

            InterfaceA service2 = ServiceLocator.GetInstance<InterfaceA>("ClassTest2");
            Assert.IsNotNull(service2);
            Assert.AreEqual("ClassTest2Impl.TestMethodA", service2.TestMethodA());

            InterfaceA service3 = ServiceLocator.GetInstance<InterfaceA>("ClassTest3");
            Assert.IsNotNull(service3);
            Assert.AreEqual("ClassTest3Impl.TestMethodA", service3.TestMethodA());
        }

        [TestMethod]
        public void TestMethod2()
        {
            var service = ServiceLocator.GetAllInstances<InterfaceA>();
            Assert.IsNotNull(service);
            Assert.AreEqual(3, service.Count());
        }

        [TestMethod]
        public void TestMethod3()
        {
            var service = ServiceLocator.GetInstance<InterfaceTestA>();
            Assert.IsNotNull(service);
            Assert.AreEqual("ClassTestA.TestMethodA", service.TestMethodA());

            var service2 = ServiceLocator.GetInstance<InterfaceTestB>();
            Assert.IsNotNull(service2);
            Assert.AreEqual("ClassTestB.TestMethodB", service2.TestMethodB());
        }

        [TestMethod]
        public void TestMethod4()
        {
            var service1 = ServiceLocator.GetInstance<InterfaceThread>();
            Assert.IsNotNull(service1);
            int id1 = service1.GetThreadId();


            int id2 = 0;
            Thread thread = new Thread(() =>
            {
                var service2 = ServiceLocator.GetInstance<InterfaceThread>();
                id2 = service2.GetThreadId();
            });
            thread.Start();
            thread.Join();
            Thread.Sleep(100);

            Assert.AreNotEqual(id1, id2);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var service = ServiceLocator.GetInstance<InterfaceSingleton>();
            Assert.IsNotNull(service);


            var service2 = ServiceLocator.GetInstance<InterfaceSingleton>();
            Assert.IsNotNull(service2);

            Assert.IsTrue(object.ReferenceEquals(service2, service));
        }

        [TestMethod]
        public void TestMethod6()
        {
            var service = ServiceLocator.GetInstance<InterfaceTestA>();
            Assert.IsNotNull(service);


            var service2 = ServiceLocator.GetInstance<InterfaceTestA>();
            Assert.IsNotNull(service2);

            Assert.IsFalse(object.ReferenceEquals(service2, service));
        }
    }
}
