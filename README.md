![Unity.Ioc.Framework](https://socialify.git.ci/meloht/Unity.Ioc.Framework/image?description=1&forks=1&language=1&owner=1&pulls=1&stargazers=1)
# Unity.Ioc.Framework
a unity IoC framework extension for Microsoft.Practices.Unity

![C#](https://img.shields.io/badge/language-C%23-blue.svg) ![.NET Version](https://img.shields.io/badge/dynamic/xml?url=https://raw.githubusercontent.com/meloht/Unity.Ioc.Framework/refs/heads/master/Unity.Ioc.Framework/Unity.Ioc.Framework.csproj&query=//TargetFrameworks&label=.NET) ![NuGet](https://img.shields.io/nuget/v/Unity.Ioc.Framework.svg?logo=nuget&logoColor=white) ![NuGet](https://img.shields.io/nuget/v/Unity.Ioc.Framework.svg?logo=nuget&logoColor=white) ![Downloads](https://img.shields.io/nuget/dt/Unity.Ioc.Framework.svg)

# QuickStart
## Interface & implementation

```C#
    [ServiceImplementation]
    public class TestClass : ITestInterface
    {
        public void TestMethod(string a)
        {
            Console.WriteLine("input:{0}", a);
        }
    }
           
   ITestInterface service = ServiceLocator.GetInstance<ITestInterface>();
   service.TestMethod("Hello world!");
```
## AppConfig File Setting
add packing section and moduleAssemblies that assembly the of the interface implementation class

Config name must be named "Unity.config" in root directory of project

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
	<configSections>
		<section name="packing" type="Unity.Ioc.Framework.Configuration.PackingSection,Unity.Ioc.Framework"/>
	</configSections>

	<packing>
		<moduleAssemblies>
			<add name="ClassLibraryTest1"/>
			<add name="ClassLibraryTest2"/>
		</moduleAssemblies>
	</packing>
</configuration>
```
# Advance

### Create Singleton Instance (Lifetime.Singleton)

```csharp
    [ServiceImplementation(ResolveLifetime =Lifetime.Singleton)]
    public class TestClass2 : ITestInterface
    {
        public void TestMethod(string a)
        {
            Console.WriteLine("input:{0}", a);
        }
    }
```
### A new object is created each time an instance is obtained (default Lifetime.New)

``` csharp
    [ServiceImplementation(ResolveLifetime =Lifetime.New)]
    public class TestClass2 : ITestInterface
    {
        public void TestMethod(string a)
        {
            Console.WriteLine("input:{0}", a);
        }
    }

```

### Return different objects for different thread contexts, and return the same object for the same thread (default Lifetime.PerThread)

``` csharp
    [ServiceImplementation(ResolveLifetime =Lifetime.PerThread)]
    public class TestClass2 : ITestInterface
    {
        public void TestMethod(string a)
        {
            Console.WriteLine("input:{0}", a);
        }
    }

```

### a interface has muti implementation class 

``` csharp
    [ServiceImplementation( Name ="class_a",ResolveLifetime =Lifetime.New)]
    public class TestClass2 : ITestInterface
    {
        public void TestMethod(string a)
        {
            Console.WriteLine("input:{0}", a);
        }
    }

    [ServiceImplementation( Name ="class_b",ResolveLifetime =Lifetime.New)]
    public class TestClass3: ITestInterface
    {
        public void TestMethod(string a)
        {
            Console.WriteLine("input:{0}", a);
        }
    }

    ITestInterface service = ServiceLocator.GetInstance<ITestInterface>("class_a");
    service.TestMethod("Hello world!");

    ITestInterface service2 = ServiceLocator.GetInstance<ITestInterface>("class_b");
    service2.TestMethod("Hello world!");

```



