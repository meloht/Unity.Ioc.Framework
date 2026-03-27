# Unity.Ioc.Framework
a unity framework extension for Microsoft.Practices.Unity

![C#](https://img.shields.io/badge/language-C%23-blue.svg) ![.NET Version](https://img.shields.io/badge/.NET-4.5-blue?style=plastic) ![NuGet](https://img.shields.io/nuget/v/Unity.Ioc.Framework.svg?logo=nuget&logoColor=white) ![Downloads](https://img.shields.io/nuget/dt/Unity.Ioc.Framework.svg)

# Simple code

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
     
# Config File
```xml
<configuration>
  <configSections>
    <section name="packing" type="Unity.Ioc.Framework.Configuration.PackingSection,Unity.Ioc.Framework"/>
  </configSections>
  <packing>
    <moduleAssemblies>
      <add name="Unity.Ioc.Framework.Test.Implementation"/>
    </moduleAssemblies>
  </packing>
  <startup>
    <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.5.2" />
  </startup>
</configuration>
```
