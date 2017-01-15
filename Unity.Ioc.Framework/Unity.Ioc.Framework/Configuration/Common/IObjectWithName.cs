using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity.Ioc.Framework.Configuration.Common
{
    /// <summary>
    /// Represents the abstraction of an object with a name.
    /// </summary>
    public interface IObjectWithName
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        string Name { get; }
    }
}
