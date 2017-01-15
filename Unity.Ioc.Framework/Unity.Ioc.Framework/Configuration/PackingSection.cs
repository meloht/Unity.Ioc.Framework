using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Ioc.Framework.Configuration.Common;

namespace Unity.Ioc.Framework.Configuration
{
    /// <summary>
    /// packing配置节.
    /// </summary>
    public class PackingSection : ConfigurationSection
    {
        /// <summary>
        /// 配置节名称
        /// </summary>
        public const string SectionName = "packing";

        /// <summary>
        /// 读取配置节内容
        /// </summary>
        public static readonly PackingSection Content
            = ConfigurationManager.GetSection(SectionName) as PackingSection;

        /// <summary>
        /// 配置集合名称
        /// </summary>
        private const string ModulesAssembliesProperty = "moduleAssemblies";

        /// <summary>
        /// 指定要加载的模块
        /// </summary>
        [ConfigurationProperty(ModulesAssembliesProperty, IsRequired = true)]
        public NamedElementCollection<ModuleDefinition> ModuleAssemblies
        {
            get
            {
                return (NamedElementCollection<ModuleDefinition>)base[ModulesAssembliesProperty];
            }
        }

    }
}
