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

    }
}