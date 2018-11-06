using System;
using System.Collections.Generic;

namespace AgressoDeploymentDesigner.Agresso.Predefined
{
    /// <summary>
    /// Factory creating lists of predefined possible values for specific Agresso columns.
    /// </summary>
    public class MappingFactory
    {
        /// <summary>
        /// Gets a mapping of predefined values of requested type.
        /// </summary>
        /// <param name="type">Required mapping type.</param>
        /// <returns>Mapping containing possible values and additional information for the requested type.</returns>
        public static ValueMapping GetMapping(MappingTypes type)
        {
            switch (type)
            {
                case MappingTypes.STATUS:
                    return CreateStatusMapping();

                case MappingTypes.BFLAG:
                    return CreateBflagMapping();

                case MappingTypes.ATTRIBUTE_DATA_TYPE:
                    return CreateAttributeDataTypeMapping();

                default:
                    return null;
            }
        }

        /// <summary>
        /// Creates a list of possible values and human readable description for Agresso object status.
        /// </summary>
        /// <returns>Value mapping containing possible Agreso object states and their comprehensive descriptions.</returns>
        private static ValueMapping CreateStatusMapping()
        {
            Dictionary<object, string> possibleValues = new Dictionary<object, string>();
            possibleValues.Add('N', "Normal");
            possibleValues.Add('P', "Parked");
            possibleValues.Add('C', "Closed");
            possibleValues.Add('T', "Terminated");
            return new ValueMapping(MappingTypes.STATUS, typeof(char), possibleValues);
        }

        /// <summary>
        /// Creates a list of possible values and human readable description for Agresso Bflag.
        /// </summary>
        /// <returns>Value mapping containing possible Agreso Bflag values and their comprehensive description.</returns>
        private static ValueMapping CreateBflagMapping()
        {
            Dictionary<object, string> possibleValues = new Dictionary<object, string>();
            possibleValues.Add(1, "Address(A)");
            possibleValues.Add(2, "Memory/cache(M)");
            possibleValues.Add(4, "Workflow(W)");
            possibleValues.Add(8, "Master file(MF)");
            possibleValues.Add(16, "Dates on relations");
            possibleValues.Add(32, "Form");
            return new ValueMapping(MappingTypes.BFLAG, typeof(int), possibleValues);
        }

        /// <summary>
        /// Creates a list of possible values and human readable description for Agresso object status.
        /// </summary>
        /// <returns>Value mapping containing possible Agreso object states and their comprehensive descriptions.</returns>
        private static ValueMapping CreateAttributeDataTypeMapping()
        {
            Dictionary<object, string> possibleValues = new Dictionary<object, string>();
            possibleValues.Add('N', "Numeric");
            possibleValues.Add('A', "Alpha numeric");
            return new ValueMapping(MappingTypes.ATTRIBUTE_DATA_TYPE, typeof(char), possibleValues);
        }
    }
}
