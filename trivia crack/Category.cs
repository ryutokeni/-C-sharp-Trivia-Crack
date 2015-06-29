using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Drawing;

namespace trivia_crack
{
    [Serializable()]
    public class Category
    {
        [XmlAttribute("ID")]
        public int ID { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("NQuestion")]
        public int NQuestion { get; set; }

        [XmlElement("Question")]
        public Question[] Question { get; set; }

        public void recoveryQuestion(int rQuestion)
        {
            switch (ID)
            {
                case 1:
                    using (StreamWriter file = new System.IO.StreamWriter("RecoverySerie.txt", true))
                        file.WriteLine(rQuestion);
                    break;
                case 2:
                    using (StreamWriter file = new System.IO.StreamWriter("RecoveryCartoon.txt", true))
                        file.WriteLine(rQuestion);
                    break;
                case 3:
                    using (StreamWriter file = new System.IO.StreamWriter("RecoveryClassic.txt", true))
                        file.WriteLine(rQuestion);
                    break;
                case 4:
                    using (StreamWriter file = new System.IO.StreamWriter("RecoveryAction.txt", true))
                        file.WriteLine(rQuestion);
                    break;
            }
        }

        public void UpdateRecovery()
        {
            switch (ID)
            {
                case 1:
                    if (File.Exists("RecoverySerie.txt"))
                    {
                        string[] lines = File.ReadAllLines("RecoverySerie.txt");

                        foreach (string line in lines)
                        {
                            int IDQuestion = -1;
                            Int32.TryParse(line, out IDQuestion);
                            if (IDQuestion != -1)
                            {
                                Question[IDQuestion].changeSign();
                            }
                        }
                    }
                    break;
                case 2:
                    if (File.Exists("RecoveryCartoon.txt"))
                    {
                        string[] lines = File.ReadAllLines("RecoveryCartoon.txt");
                        foreach (string line in lines)
                        {
                            int IDQuestion = -1;
                            Int32.TryParse(line, out IDQuestion);
                            if (IDQuestion != -1)
                            {
                                Question[IDQuestion].changeSign();
                            }
                        }
                    }
                    break;
                case 3:
                    if (File.Exists("RecoveryClassic.txt"))
                    {
                        string[] lines = File.ReadAllLines("RecoveryClassic.txt");
                        foreach (string line in lines)
                        {
                            int IDQuestion = -1;
                            Int32.TryParse(line, out IDQuestion);
                            if (IDQuestion != -1)
                            {
                                Question[IDQuestion].changeSign();
                            }
                        }
                    }
                    break;
                case 4:
                    if (File.Exists("RecoveryAction.txt"))
                    {
                        string[] lines = File.ReadAllLines("RecoveryAction.txt");
                        foreach (string line in lines)
                        {
                            int IDQuestion = -1;
                            Int32.TryParse(line, out IDQuestion);
                            if (IDQuestion != -1)
                            {
                                Question[IDQuestion].changeSign();
                            }
                        }
                    }
                    break;
            }
        }

        public void loadContent(FormQuestion f1)
        {
            bool Sign = true;
            int IDQuestion = 0;
            while (Sign)
            {
                Random randomQuestion = new Random();
                IDQuestion = randomQuestion.Next(0, NQuestion - 1);
                Sign = Question[IDQuestion].checkSign();
            }

            Question[IDQuestion].changeSign();
            this.recoveryQuestion(IDQuestion);

            f1.Content.Text = Question[IDQuestion].getContent();
            f1.AnswerA.Text = Question[IDQuestion].getAnswerA();
            f1.AnswerB.Text = Question[IDQuestion].getAnswerB();
            f1.AnswerC.Text = Question[IDQuestion].getAnswerC();
            f1.AnswerD.Text = Question[IDQuestion].getAnswerD();
            f1.TrueAnswer = Question[IDQuestion].getTrueAnswer();
            if (Question[IDQuestion].Image != null)
                f1.pictureBox1.BackgroundImage = Bitmap.FromFile((string)Question[IDQuestion].Image);
        }

        public string writeName()
        {
            return Name;
        }
    }
}
