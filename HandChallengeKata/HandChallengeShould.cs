using FluentAssertions;

namespace HandChallengeKata
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test(Description = "aceptance test")]
        public void print_hello()
        {
            var handCompiler = new HandCompiler();
            var result = handCompiler.Compile("👇🤜👇👇👇👇👇👇👇👉👆👈🤛👉👇👊👇🤜👇👉👆👆👆👆👆👈🤛👉👆👆👊👆👆👆👆👆👆👆👊👊👆👆👆👊");
            result.Should().Be("Hello!");
        }

    }
}