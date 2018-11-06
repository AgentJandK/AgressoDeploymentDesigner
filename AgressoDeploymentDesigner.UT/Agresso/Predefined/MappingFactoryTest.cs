using NUnit.Framework;
using AgressoDeploymentDesigner.Agresso.Predefined;

namespace AgressoDeploymentDesigner.Agresso.Predefined.UT
{
    [TestFixture]
    public class MappingFactoryTest
    {
        [Test]
        public void Will_ReturnStatusMapping_When_Requested()
        {
            ValueMapping mapping = MappingFactory.GetMapping(MappingTypes.STATUS);

            Assert.IsNotNull(mapping);
            Assert.AreEqual(MappingTypes.STATUS, mapping.MappingType);
            Assert.AreEqual(typeof(char), mapping.ValueType);
            Assert.IsTrue(mapping.PossibleValues.ContainsKey('N'));
            Assert.AreEqual("Normal", mapping.PossibleValues['N']);
            Assert.IsTrue(mapping.PossibleValues.ContainsKey('P'));
            Assert.AreEqual("Parked", mapping.PossibleValues['P']);
            Assert.IsTrue(mapping.PossibleValues.ContainsKey('C'));
            Assert.AreEqual("Closed", mapping.PossibleValues['C']);
            Assert.IsTrue(mapping.PossibleValues.ContainsKey('T'));
            Assert.AreEqual("Terminated", mapping.PossibleValues['T']);
        }

        [Test]
        public void Will_ReturnBflagMapping_When_Requested()
        {
            ValueMapping mapping = MappingFactory.GetMapping(MappingTypes.BFLAG);

            Assert.IsNotNull(mapping);
            Assert.AreEqual(MappingTypes.BFLAG, mapping.MappingType);
            Assert.AreEqual(typeof(int), mapping.ValueType);
            Assert.IsTrue(mapping.PossibleValues.ContainsKey(1));
            Assert.AreEqual("Address(A)", mapping.PossibleValues[1]);
            Assert.IsTrue(mapping.PossibleValues.ContainsKey(2));
            Assert.AreEqual("Memory/cache(M)", mapping.PossibleValues[2]);
            Assert.IsTrue(mapping.PossibleValues.ContainsKey(4));
            Assert.AreEqual("Workflow(W)", mapping.PossibleValues[4]);
            Assert.IsTrue(mapping.PossibleValues.ContainsKey(8));
            Assert.AreEqual("Master file(MF)", mapping.PossibleValues[8]);
            Assert.IsTrue(mapping.PossibleValues.ContainsKey(16));
            Assert.AreEqual("Dates on relations", mapping.PossibleValues[16]);
            Assert.IsTrue(mapping.PossibleValues.ContainsKey(32));
            Assert.AreEqual("Form", mapping.PossibleValues[32]);
        }

        [Test]
        public void Will_returnAttributeDataTypeMapping_When_Requested()
        {
            ValueMapping mapping = MappingFactory.GetMapping(MappingTypes.ATTRIBUTE_DATA_TYPE);

            Assert.IsNotNull(mapping);
            Assert.AreEqual(MappingTypes.ATTRIBUTE_DATA_TYPE, mapping.MappingType);
            Assert.AreEqual(typeof(char), mapping.ValueType);
            Assert.IsTrue(mapping.PossibleValues.ContainsKey('A'));
            Assert.AreEqual("Alpha numeric", mapping.PossibleValues['A']);
            Assert.IsTrue(mapping.PossibleValues.ContainsKey('N'));
            Assert.AreEqual("Numeric", mapping.PossibleValues['N']);
        }
    }
}
