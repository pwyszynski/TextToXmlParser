using Xunit;
using Parser.Utils;

namespace Parser.UnitTests.XMLParserService
{
    public class XMLParserTest
    {
		const string input = "A      sentence for     testing. Another sentence.";
		const string output = "<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<text xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <sentence>\r\n    <word>A</word>\r\n    <word>for</word>\r\n    <word>sentence</word>\r\n    <word>testing</word>\r\n  </sentence>\r\n  <sentence>\r\n    <word>Another</word>\r\n    <word>sentence</word>\r\n  </sentence>\r\n</text>";

		[Fact]
		public void TextParsesProperly()
		{
			var result = XMLParser.ParseText(input);

			Assert.True(result == output);
		}
    }
}
