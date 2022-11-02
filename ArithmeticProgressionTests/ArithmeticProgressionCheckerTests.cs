using ArithmeticProgression;
using NUnit.Framework;
using System.Collections.Generic;

namespace ArithmeticProgressionTests
{
    public class ArithmeticProgressionCheckerTests
    {
        private ArithmeticProgressionChecker _checker;

        [Test(Author = "Taroiu Ionut")]
        public void IsProgression_ProgressionInput_Return_True()
        {
            //arrange
            var input = new List<int> { 6, 8, 10, 12, 14, 16, 18 };
            _checker = new ArithmeticProgressionChecker(input);

            //act
            var actual = _checker.IsProgression();

            //assert
            Assert.IsTrue(actual);
        }

        [Test(Author = "Taroiu Ionut")]
        public void IsProgression_NoProgressionInput_Return_False()
        {
            //arrange
            var input = new List<int> { 17, 19, 21, 23, 27 };
            _checker = new ArithmeticProgressionChecker(input);

            //act
            var actual = _checker.IsProgression();

            //assert
            Assert.IsFalse(actual);
        }
    }
}