using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using Parser.Models;

namespace Parser.Utils
{
    public static class XMLParser
    {
        public static string ParseText(string receivedText)
        {
            var t = XMLParser.SplitToText(receivedText);

            return XMLParser.ParseToXml(t);
        }

        private static string ParseToXml(Text t)
        {
            var serializer = new XmlSerializer(typeof(Text));
            using (var sw = new StringWriter())
            {
                serializer.Serialize(sw, t);

                return sw.ToString();
            }
        }

        private static Text SplitToText(string input)
        {
            var result = new Text();
            var sentences = input.Split('.', StringSplitOptions.RemoveEmptyEntries);

            foreach(var sent in sentences)
            {
                var words = sent.Split(new char[] { '.', ',', ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                result.Sentences.Add(new Sentence(words));
            }

            return result;
        }
    }
}