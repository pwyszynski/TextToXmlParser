using Parser.Models;
using System;
using Xunit;

namespace Parser.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void SentencesIsNotNullTest()
        {
            //arange
            Text t = new Text();

            //act
            //nothing

            //assert
            Assert.NotNull(t.Sentences);
        }

        [Fact]
        public void TextHasSentencesTest()
        {
            //arange
            Text t = new Text();

            //act
            t.Sentences.Add(new Sentence());

            //assert
            Assert.NotEmpty(t.Sentences);
        }
    }
}
