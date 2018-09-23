using System;

namespace FatEntityOptions.Attributes
{
    /// <summary>
    /// "Fat" Entity attribute 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class EntityAttribute : Attribute
    {
        /// <summary>
        /// Alias name
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// Primary "lean" entity name
        /// </summary>
        public string PrimaryEntity { get; set; }
    }
}
