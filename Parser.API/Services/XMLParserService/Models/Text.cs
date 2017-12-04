using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Parser.Models
{
	/// <summary>
	/// Class representing whole text consisting of sentences.
	/// </summary>
    [XmlRoot("text")]
    public class Text
    {
		/// <summary>
		/// Default parameterless constructor for serialization.
		/// </summary>
        public Text()
        {
        }

		/// <summary>
		/// List of <see cref="Sentence"/> objects.
		/// </summary>
        [XmlElement("sentence")]
        public List<Sentence> Sentences {get; set;} = new List<Sentence>();
    }
}