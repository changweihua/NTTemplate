using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lance.ExFramework.Swagger.Attributes
{
    /// <summary>
    /// 隐藏接口，不生成到swagger文档展示
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class ActionHiddenAttribute : Attribute
    {
    }
}
