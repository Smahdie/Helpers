using Helpers;
using NUnit.Framework;

namespace Test
{
    public class StringHelperTests
    {
        [Test]
        public void Reduce_Length_Returns_Same_When_MaxLengh_Bigger_OrEqual_Input_Length()
        {
            var input = "hello";
            var maxLength = 5;
            var result = input.ReduceLength(maxLength);
            Assert.That(result, Is.EqualTo(input));
        }

        [Test]
        public void Reduce_Length_Returns_Shorter_String_WithDots_When_MaxLengh_Less_Than_Input_Length()
        {
            var input = "hello";
            var expectedOutput = "hel ...";
            var maxLength = 3;
            var result = input.ReduceLength(maxLength);
            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [TestCase("")]
        [TestCase(null)]
        public void Reduce_Length_Returns_Same_WhenNullOrEmpty(string input)
        {
            var maxLength = 0;
            var result = input.ReduceLength(maxLength);
            Assert.That(result, Is.EqualTo(input));
        }

        [Test]
        public void Reduce_Length_Returns_Empty_WhenWhiteSpace()
        {
            var input = " ";
            var maxLength = 0;
            var result = input.ReduceLength(maxLength);
            Assert.That(result, Is.EqualTo(string.Empty));
        }

        [TestCase(" ")]
        [TestCase("")]
        [TestCase(null)]
        public void EnglishDigits_Returns_Same_WhenNullOrEmptyOrWhiteSpace(string input)
        {
            var result = input.WithEnglishDigits();
            Assert.That(result, Is.EqualTo(input));
        }

        [Test]
        public void EnglishDigits_Changes_Arabic_Digits_ToEnglish()
        {
            var input = "٩6٧٨1";
            var expectedOutput = "96781";
            var result = input.WithEnglishDigits();
            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [TestCase(" ")]
        [TestCase("")]
        [TestCase(null)]
        public void Persian_Letters_Returns_Same_WhenNullOrEmptyOrWhiteSpace(string input)
        {
            var result = input.WithPersianLetters();
            Assert.That(result, Is.EqualTo(input));
        }

        [TestCase("كد", "کد")]
        [TestCase("مهديه", "مهدیه")]
        public void Persian_Letters_Converts_Arabic_Letters_ToPersian(string input, string expectedOutput)
        {
            var result = input.WithPersianLetters();
            Assert.That(input, Is.Not.EqualTo(expectedOutput));
            Assert.That(result, Is.EqualTo(expectedOutput));
        }
    }
}