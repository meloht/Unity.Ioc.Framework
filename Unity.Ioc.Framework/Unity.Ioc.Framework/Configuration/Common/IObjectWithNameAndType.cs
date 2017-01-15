using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity.Ioc.Framework.Configuration.Common
{
    /// <summary>
    /// Represents the abstraction of an object with a name and a type.
    /// </summary>
    public interface IObjectWithNameAndType : IObjectWithName
    {
        /// <summary>
        /// Gets the type.
        /// </summary>
        Type Type { get; }
    }
}
