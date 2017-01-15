using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity.Ioc.Framework
{
    /// <summary>
    /// 指定由容器创建对象的生存期.
    /// </summary>
    public enum Lifetime
    {
        /// <summary>
        /// 每次获取实例时都新建对象
        /// </summary>
        New,
        /// <summary>
        /// 对不同线程返回不同的对象, 同一线程返回同一对象
        /// </summary>
        PerThread,
        /// <summary>
        /// 只创建一次, 始终返回同一对象
        /// </summary>
        Singleton,
    }
}
