using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace Parser.Models
{
    public class Sentence
    {
        public Sentence()
        {

        }
        public Sentence(string[] words)
        {
            var sortedWords = words.ToList();
            sortedWords.Sort();
            foreach(var word in sortedWords)
            {
                this.Words.Add(word);
            }
        }

        [XmlElement("word")]
        public List<string> Words {get; set;} = new List<string>();
    }
}