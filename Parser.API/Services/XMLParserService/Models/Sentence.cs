using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace Parser.Models
{
	/// <summary>
	/// Class representing a sentence.
	/// </summary>
    public class Sentence
    {
		/// <summary>
		/// Default parameterless constructor for serialization.
		/// </summary>
        public Sentence()
        {
        }

		/// <summary>
		/// Constructor that takes an array of words (strings) as parameter, sorts them and adds them to the internal Words list <see cref="Words"/>.
		/// </summary>
		/// <param name="words">Array of unsorted words (strings).</param>
        public Sentence(string[] words)
        {
            var sortedWords = words.ToList();
            sortedWords.Sort();
            foreach(var word in sortedWords)
            {
                this.Words.Add(word);
            }
        }

		/// <summary>
		/// List of words contained in the sentence.
		/// </summary>
        [XmlElement("word")]
        public List<string> Words {get; set;} = new List<string>();
    }
}