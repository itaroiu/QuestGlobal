using GeneticExperints;
using NUnit.Framework;

namespace GeneticExperimentsTests
{
    public class CompoundSynthesizerTests
    {
        private CompoundSynthesizer _compoundSynthesizer;

        [Test(Author = "Taroiu Ionut")]
        [TestCase("aabbaadddc", "a4b2d3c1")]
        [TestCase("bbbbaaaadddeee", "b4a4d3e3")]
        public void Synthesize_ValidInput_Return_Synthentized(string input, string expected)
        {
            //arrange
            _compoundSynthesizer = new CompoundSynthesizer(input);

            //act
            var actual = _compoundSynthesizer.Synthesize();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}