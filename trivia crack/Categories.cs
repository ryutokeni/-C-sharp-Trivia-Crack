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
    [XmlRoot("Game")]
    public class Game
    {
 
        [XmlArray("Categories")]
        [XmlArrayItem("Category", typeof(Category))]
        public Category[] Categories { get; set; }

        public string writeCategory(int IDCategory)
        {
            if (IDCategory < 4)
                    return Categories[IDCategory].writeName();
            return "COURONNE";
        }


        public void loadContent(int IDCategory, FormQuestion f1)
        {
            Categories[IDCategory].loadContent(f1); 
            return;
        }

        public void UpdateRecovery()
        {
            for (int i = 0; i < 4; i++)
                Categories[i].UpdateRecovery();
        }
    }
}
