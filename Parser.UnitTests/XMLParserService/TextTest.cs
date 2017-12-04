using Parser.Models;
using Xunit;

namespace Parser.UnitTests.XMLParserService
{
    public class TextTest
    {
		[Fact]
		public void TextIsNotNull()
		{
			Text t = new Text();

			Assert.NotNull(t);
		}


    }
}
