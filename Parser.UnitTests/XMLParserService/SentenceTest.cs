using Parser.Models;
using System;
using Xunit;

namespace Parser.UnitTests.XMLParserService
{
    public class SentenceTest
    {
        [Fact]
        public void SentencesIsNotNullOnDefaultCtor()
        {
			Sentence s = new Sentence();

			Assert.NotNull(s);
        }

		[Fact]
		public void SentenceHasNoWordsOnDefaultCtor()
		{
			Sentence s = new Sentence();

			Assert.Empty(s.Words);
		}

		[Fact]
		public void SentenceIsNotNullOnStringArrayCtor()
		{
			Sentence s = new Sentence(new string[] { "Test", "words", "for", "sentence" });

			Assert.NotNull(s);
		}

		[Fact]
		public void SentenceHasWordsOnStringArrayCtor()
		{
			Sentence s = new Sentence(new string[] { "Test", "words", "for", "sentence" });

			Assert.NotEmpty(s.Words);
		}

		[Fact]
		public void SentenceHasWords()
		{
			Sentence s = new Sentence();

			Assert.NotNull(s.Words);
		}
    }
}
