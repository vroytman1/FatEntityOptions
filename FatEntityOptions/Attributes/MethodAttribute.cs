using System;

namespace FatEntityOptions.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class MethodAttribute : Attribute
    {
        /// <summary>
        /// Alias name
        /// </summary>
        public string Alias { get; set; }
    }
}
