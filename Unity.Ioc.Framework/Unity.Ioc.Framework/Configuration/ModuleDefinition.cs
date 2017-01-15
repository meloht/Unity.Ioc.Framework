using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Ioc.Framework.Configuration.Common;

namespace Unity.Ioc.Framework.Configuration
{
    /// <summary>
    /// 指定待加载的程序模块.
    /// </summary>
    /// <remarks>目前只使用一个name属性, 内容应是合法的程序集名称,
    /// 可以不包括版本和publicKeyToken</remarks>.
    public class ModuleDefinition : NamedConfigurationElement
    {
    }
}
