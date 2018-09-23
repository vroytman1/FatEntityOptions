using System;

namespace FatEntityOptions.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class PropertyAttribute : Attribute
    {
        /// <summary>
        /// Optional property name (alias)
        /// </summary>
        public string Name { get; set; }

        public string Type { get; set; }

        public bool IsReadOnly { get; set; }

        public bool IsWriteOnly { get; set; }

        public bool IsHidden { get; set; }

        /// <summary>
        /// For properties included in the primary key
        /// </summary>
        public bool IsPrimaryKey { get; set; }

        /// <summary>
        /// "Lean" Entity and optional property names
        /// </summary>
        /// <remarks>Entity and property names are delimited by period symbol ".".
        /// If property is not specified then the same property name is assumed</remarks>
        public string RefersTo { get; set; }
    }
}
