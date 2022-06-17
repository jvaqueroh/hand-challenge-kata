using System.Text;
using FluentAssertions;

namespace HandChallengeKata
{
    public class Tests
    {
        private HandCompiler handCompiler;

        [SetUp]
        public void Setup()
        {
            handCompiler = new HandCompiler();
        }

        [Test(Description = "aceptance test")]
        public void print_hello()
        {
            var result = handCompiler.Compile("👇🤜👇👇👇👇👇👇👇👉👆👈🤛👉👇👊👇🤜👇👉👆👆👆👆👆👈🤛👉👆👆👊👆👆👆👆👆👆👆👊👊👆👆👆👊");

            result.Should().Be("Hello!");
        }

        [Test]
        public void return_empty_string_for_input_with_no_fist() //no 👊 in the imput
        {
            var result = handCompiler.Compile("👇");

            result.Should().Be(string.Empty);
        }

        [Test]
        public void return_ascii_char_for_decimal_1()
        {
            var result = handCompiler.Compile("👆👊");

            result.Should().Be(Encoding.ASCII.GetString((new[] { (byte)1 })));
        }
    }
}