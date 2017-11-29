using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ConsoleParsing.Models
{
    [XmlRoot("text")]
    public class Text
    {
        public Text()
        {
        }

        [XmlElement("sentence")]
        public List<Sentence> Sentences {get; set;} = new List<Sentence>();
    }
}