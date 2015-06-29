using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace trivia_crack
{

    public partial class FormQuestion : Form
    {
        public WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public WMPLib.WindowsMediaPlayer wplayerClock = new WMPLib.WindowsMediaPlayer();
        public string TrueAnswer;
        public FormQuestion()
        {       
            InitializeComponent();
            timer = 20;
            timer1.Start();
            wplayerClock.URL = "./sound/clock.mp3";
            wplayer.controls.play();
            AnswerA.BackColor = default(Color);
            AnswerB.BackColor = default(Color);
            AnswerC.BackColor = default(Color);
            AnswerD.BackColor = default(Color);
            Content.SelectionAlignment = HorizontalAlignment.Center;
        }

        public bool check = false;

        public delegate void delPassData(TextBox text);
        

        private void AnswerA_Click(object sender, EventArgs e)
        {
            
            //this.Hide();
            //Owner.Show();
            if (TrueAnswer == "A")
            {
                check = true;
                AnswerA.BackColor = Color.LawnGreen;
                wplayer.URL = "./sound/true.mp3";
                wplayer.controls.play();
                //MessageBox.Show("C'est vrai! Felicitations!");
            }
            else
            {
                AnswerA.BackColor = Color.IndianRed;
                wplayer.URL = "./sound/false.mp3";
                wplayer.controls.play();
                if (TrueAnswer == "A")
                    AnswerA.BackColor = Color.LawnGreen;
                if (TrueAnswer == "B")
                    AnswerB.BackColor = Color.LawnGreen;
                if (TrueAnswer == "C")
                    AnswerC.BackColor = Color.LawnGreen;
                if (TrueAnswer == "D")
                    AnswerD.BackColor = Color.LawnGreen;
                //MessageBox.Show("Cette reponse n'est pas vrai!");
            }
           // Form1 form1 = new Form1();
            Form1.check = check;
            //Form1.cont = check;
            //Owner.Show();
            timer1.Stop();
            wplayerClock.controls.stop();
            check = false;
            //Thread.Sleep(2000);
            //this.Close();
        }

        private void AnswerB_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Owner.Show();
            if (TrueAnswer == "B")
            {
                check = true;
                wplayer.URL = "./sound/true.mp3";
                wplayer.controls.play();
                AnswerB.BackColor = Color.LawnGreen;
                //MessageBox.Show("C'est vrai! Felicitations!");
            }
            else
            {
                AnswerB.BackColor = Color.IndianRed;
                wplayer.URL = "./sound/false.mp3";
                wplayer.controls.play();
                if (TrueAnswer == "A")
                    AnswerA.BackColor = Color.LawnGreen;
                if (TrueAnswer == "B")
                    AnswerB.BackColor = Color.LawnGreen;
                if (TrueAnswer == "C")
                    AnswerC.BackColor = Color.LawnGreen;
                if (TrueAnswer == "D")
                    AnswerD.BackColor = Color.LawnGreen;
                //MessageBox.Show("Cette reponse n'est pas vrai!");
            }
            //Form1 form1 = new Form1();
            Form1.check = check;
            timer1.Stop();
            wplayerClock.controls.stop();
            check = false;
            //Thread.Sleep(2000);
            //this.Close();
        }

        private void AnswerC_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Owner.Show();
            if (TrueAnswer == "C")
            {
                check = true;
                wplayer.URL = "./sound/true.mp3";
                wplayer.controls.play();
                AnswerC.BackColor = Color.LawnGreen;
                //MessageBox.Show("C'est vrai! Felicitations!");
            }
            else
            {
                AnswerC.BackColor = Color.IndianRed;
                wplayer.URL = "./sound/false.mp3";
                wplayer.controls.play();
                if (TrueAnswer == "A")
                    AnswerA.BackColor = Color.LawnGreen;
                if (TrueAnswer == "B")
                    AnswerB.BackColor = Color.LawnGreen;
                if (TrueAnswer == "C")
                    AnswerC.BackColor = Color.LawnGreen;
                if (TrueAnswer == "D")
                    AnswerD.BackColor = Color.LawnGreen;
                //MessageBox.Show("Cette reponse n'est pas vrai!");
            }
            //Form1 form1 = new Form1();
            Form1.check = check;
            timer1.Stop();
            wplayerClock.controls.stop();
            check = false;
            //Thread.Sleep(2000);
            //this.Close();
        }

        private void AnswerD_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Owner.Show();
            if (TrueAnswer == "D")
            {
                check = true;
                wplayer.URL = "./sound/true.mp3";
                wplayer.controls.play();
                AnswerD.BackColor = Color.LawnGreen;
                //MessageBox.Show("C'est vrai! Felicitations!");
            }
            else
            {
                AnswerD.BackColor = Color.IndianRed;
                wplayer.URL = "./sound/false.mp3";
                wplayer.controls.play();
                if (TrueAnswer == "A")
                    AnswerA.BackColor = Color.LawnGreen;
                if (TrueAnswer == "B")
                    AnswerB.BackColor = Color.LawnGreen;
                if (TrueAnswer == "C")
                    AnswerC.BackColor = Color.LawnGreen;
                if (TrueAnswer == "D")
                    AnswerD.BackColor = Color.LawnGreen;
            }
             //Form1 form1 = new Form1();
            Form1.check = check;
            timer1.Stop();
            wplayerClock.controls.stop();
            check = false;
            //Thread.Sleep(2000);
            //this.Close();
        }

        int timer = 20;
        int tick = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {          
            if (tick++ == 60)
            {
                Clock.Text = (--timer).ToString();
                tick = 0;
            }
            if (timer == 0)
            {
                timer1.Stop();
                wplayer.URL = "./sound/alarm.mp3";
                wplayer.controls.play();
                wplayerClock.controls.stop();
                if (TrueAnswer == "A")
                    AnswerA.BackColor = Color.LawnGreen;
                if (TrueAnswer == "B")
                    AnswerB.BackColor = Color.LawnGreen;
                if (TrueAnswer == "C")
                    AnswerC.BackColor = Color.LawnGreen;
                if (TrueAnswer == "D")
                    AnswerD.BackColor = Color.LawnGreen;
            }
        }

       

    }
}
