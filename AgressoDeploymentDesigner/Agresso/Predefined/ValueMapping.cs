using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgressoDeploymentDesigner.Agresso.Predefined
{
    /// <summary>
    /// Agresso predefined values with description.
    /// </summary>
    public class ValueMapping
    {
        /// <summary>
        /// Type of mapping.
        /// </summary>
        public MappingTypes MappingType { get; }

        /// <summary>
        ///  Type of predefined value.
        /// </summary>
        public Type ValueType { get; }

        /// <summary>
        /// List of possible values in this mapping.
        /// </summary>
        public Dictionary<object, string> PossibleValues { get; }

        public ValueMapping(MappingTypes type, Type valueType, Dictionary<object, string> possibleValues)
        {
            this.MappingType = type;
            this.ValueType = valueType;
            this.PossibleValues = possibleValues;
        }
    }
}
