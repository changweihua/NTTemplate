using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lance.ExFramework.Swagger.Attributes
{
    /// <summary>
    /// Swagger 版本控制
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public class SwaggerVersionAttribute : Attribute
    {
        public SwaggerVersionAttribute(string name, int version)
        {
            Name = name;
            Version = version;
        }

        public string Name { get; set; }
        public int Version { get; set; }
    }
}
