using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lance.ExFramework.Swagger.Attributes
{
    /// <summary>
    /// 标记Form表单内是否存在input:file
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    public class SwaggerFileUploadAttribute : Attribute
    {
        public bool Required { get; private set; }

        public SwaggerFileUploadAttribute(bool Required = true)
        {
            this.Required = Required;
        }
    }
}
