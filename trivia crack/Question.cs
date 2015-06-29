using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace trivia_crack
{
    [Serializable()]
    public class Question
    {
        [XmlAttribute("ID")]
        public int ID { get; set; }

        [XmlElement("Content")]
        public string Content { get; set; }

        [XmlElement("A")]
        public string A { get; set; }

        [XmlElement("B")]
        public string B { get; set; }

        [XmlElement("C")]
        public string C { get; set; }

        [XmlElement("D")]
        public string D { get; set; }

        [XmlElement("True")]
        public string True { get; set; }

        [XmlElement("Image")]
        public string Image { get; set; }

        public bool Sign = false;
        public string getContent()
        {
            return Content;
        }

        public bool checkSign()
        {
            return Sign;
        }

        public void changeSign()
        {
            Sign = true;
        }

        public string getAnswerA()
        {
            return A;
        }

        public string getAnswerB()
        {
            return B;
        }

        public string getAnswerC()
        {
            return C;
        }

        public string getAnswerD()
        {
            return D;
        }

        public string getTrueAnswer()
        {
            return True;
        }
    }
}
