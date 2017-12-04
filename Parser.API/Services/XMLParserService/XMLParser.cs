using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using Parser.Models;

namespace Parser.Utils
{
	/// <summary>
	/// Sentence to XML parser. This class is responsible for transforming text into XML format.
	/// </summary>
    public static class XMLParser
    {
		/// <summary>
		/// Parses received text into XML.
		/// </summary>
		/// <param name="receivedText">The text received from calling code.</param>
		/// <returns>XML-formatted string.</returns>
        public static string ParseText(string receivedText)
        {
            var t = XMLParser.SplitToText(receivedText);

            return XMLParser.ParseToXml(t);
        }

		/// <summary>
		/// Parses given <see cref="Text"/> object into XML-formatted string. Uses <see cref="XmlSerializer"/> internally.
		/// </summary>
		/// <param name="t"><see cref="Text"/> object to parse.</param>
		/// <returns>String containing parsed sentence to XML.</returns>
        private static string ParseToXml(Text t)
        {
            var serializer = new XmlSerializer(typeof(Text));
            using (var sw = new StringWriter())
            {
                serializer.Serialize(sw, t);

                return sw.ToString();
            }
        }

		/// <summary>
		/// Splits input text into <see cref="Text"/> object.
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
        private static Text SplitToText(string input)
        {
            var result = new Text();
            var sentences = input.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            foreach(var sent in sentences)
            {
                var words = sent.Split(new char[] { '.', ',', ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                result.Sentences.Add(new Sentence(words));
            }

            return result;
        }
    }
}