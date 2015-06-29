using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;
using System.Threading;

namespace trivia_crack
{
    public partial class Form1 : Form
    {
        FormQuestion form_q;
        public delegate void delPassData(string text);
        public WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public int[] team = new int[4]{0, 0, 0, 0 };
        public int[] icon = new int[4] { 0, 0, 0, 0 };
        public int[] result = new int[4] { 80, 80, 80, 80 };
        public int[,] Badge = new int[4,4];
        public int done = 0;
        public int IDBadgeChoose = -1;
        public static bool check; //cont = false;
        public int turn = 0;
        public int round = 1;

        public Form1()
        {
            InitializeComponent();
            SpinningBoard.Controls.Add(SpinButton);
            SpinButton.Location = new Point(150, 140);
            SpinButton.BackColor = Color.Transparent;
            result1.Text = Convert.ToString(result[0]);
            result2.Text = Convert.ToString(result[1]);
            result3.Text = Convert.ToString(result[2]);
            result4.Text = Convert.ToString(result[3]);
            for (int i = 0; i<4;i++)
                for (int j = 0;j <4;j++)
                    Badge[i,j] = 0;
        }
        
        public void ShowBadge(int player)
        {
            if (Badge[player, 0] == 0)
                Badge0.Show();
            if (Badge[player, 1] == 0)
                Badge1.Show();
            if (Badge[player, 2] == 0)
                Badge2.Show();
            if (Badge[player, 3] == 0)
                Badge3.Show();
        }

        public void ChooseBadge(int player)
        {       
            team[turn] = 0;
            switch (turn)
            {
                case 0: point1.Text = Convert.ToString(team[turn]); break;
                case 1: point2.Text = Convert.ToString(team[turn]); break;
                case 2: point3.Text = Convert.ToString(team[turn]); break;
                case 3: point4.Text = Convert.ToString(team[turn]); break;
            }
            form_q = new FormQuestion();
            categories.loadContent(IDBadgeChoose, form_q);


            this.Hide();
            form_q.ShowDialog(this);
            
            this.Show();
            if (check == true)
            {
               switch (player)
               {
                   case 0: GetBadge_P0(); result[0] += 5; icon[0]++; result1.Text = Convert.ToString(result[0]); break;
                   case 1: GetBadge_P1(); result[1] += 5; icon[1]++; result2.Text = Convert.ToString(result[1]); break;
                   case 2: GetBadge_P2(); result[2] += 5; icon[2]++; result3.Text = Convert.ToString(result[2]); break;
                   case 3: GetBadge_P3(); result[3] += 5; icon[3]++; result4.Text = Convert.ToString(result[3]); break;
               }
               while (Badge[turn, 0] == 1 && Badge[turn, 1] == 1 && Badge[turn, 2] == 1 && Badge[turn, 3] == 1)
               {
                   turn++;
                   if (turn >= 4)
                   {
                       Tour.Text = "Tour: " + ++round;
                       for (int i = 0; i < 4; i++)
                       {
                           if (icon[i] < 4)
                               result[i] -= 10;
                       }
                       result1.Text = Convert.ToString(result[0]);
                       result2.Text = Convert.ToString(result[1]);
                       result3.Text = Convert.ToString(result[2]);
                       result4.Text = Convert.ToString(result[3]);
                       if (round > 8)
                           Tour.Text = "Jeu terminé";
                       turn = 0;
                   }
               }
            }
            else
            {
                turn++;
                if (turn >= 4)
                {
                    Tour.Text = "Tour: " + ++round;
                    for (int i = 0; i < 4; i++)
                    {
                        if (icon[i] < 4)
                            result[i] -= 10;
                    }
                    result1.Text = Convert.ToString(result[0]);
                    result2.Text = Convert.ToString(result[1]);
                    result3.Text = Convert.ToString(result[2]);
                    result4.Text = Convert.ToString(result[3]);
                    if (round > 8)
                        Tour.Text = "Jeu terminé";
                    turn = 0;
                }
                while (Badge[turn, 0] == 1 && Badge[turn, 1] == 1 && Badge[turn, 2] == 1 && Badge[turn, 3] == 1)
                {
                    turn++;
                    if (turn >= 4)
                    {
                        Tour.Text = "Tour: " + ++round;
                        for (int i = 0; i < 4; i++)
                        {
                            if (icon[i] < 4)
                                result[i] -= 10;
                        }
                        result1.Text = Convert.ToString(result[0]);
                        result2.Text = Convert.ToString(result[1]);
                        result3.Text = Convert.ToString(result[2]);
                        result4.Text = Convert.ToString(result[3]);
                        if (round > 8)
                            Tour.Text = "Jeu terminé";
                        turn = 0;
                    }
                }
            }
            //Playing.Text = "Équipe: " + (turn + 1);
            switch (turn)
            {
                case 0:
                    Playing.Text = "Les trois garcons chauds";
                    break;
                case 1:
                    Playing.Text = "ĐAK";
                    break;
                case 2:
                    Playing.Text = "Verseau";
                    break;
                case 3:
                    Playing.Text = "1430";
                    break;
            }
            SavePoint();
            Badge0.Hide();
            Badge1.Hide();
            Badge2.Hide();
            Badge3.Hide();
            return;
        }

        public void GetBadge_P0()
        {
            switch (IDBadgeChoose)
            {
                case 0: Badge00.Show(); Badge[0, 0] = 1; break;
                case 1: Badge01.Show(); Badge[0, 1] = 1; break;
                case 2: Badge02.Show(); Badge[0, 2] = 1; break;
                case 3: Badge03.Show(); Badge[0, 3] = 1; break;
            }
        }

        public void GetBadge_P1()
        {
            switch (IDBadgeChoose)
            {
                case 0: Badge10.Show(); Badge[1, 0] = 1; break;
                case 1: Badge11.Show(); Badge[1, 1] = 1; break;
                case 2: Badge12.Show(); Badge[1, 2] = 1; break;
                case 3: Badge13.Show(); Badge[1, 3] = 1; break;
            }
        }

        public void GetBadge_P2()
        {
            switch (IDBadgeChoose)
            {
                case 0: Badge20.Show(); Badge[2, 0] = 1; break;
                case 1: Badge21.Show(); Badge[2, 1] = 1; break;
                case 2: Badge22.Show(); Badge[2, 2] = 1; break;
                case 3: Badge23.Show(); Badge[2, 3] = 1; break;
            }
        }

        public void GetBadge_P3()
        {
            switch (IDBadgeChoose)
            {
                case 0: Badge30.Show(); Badge[3, 0] = 1; break;
                case 1: Badge31.Show(); Badge[3, 1] = 1; break;
                case 2: Badge32.Show(); Badge[3, 2] = 1; break;
                case 3: Badge33.Show(); Badge[3, 3] = 1; break;
            }
        }

        public Bitmap rotateImage(Bitmap bitmap, float angle)
        {
            Bitmap returnBitmap = new Bitmap(bitmap.Width, bitmap.Height);
            Graphics graphics = Graphics.FromImage(returnBitmap);
            graphics.Clear(Color.Transparent);
            graphics.TranslateTransform((float)bitmap.Width / 2, (float)bitmap.Height / 2);
            graphics.RotateTransform(angle);
            graphics.TranslateTransform(-(float)bitmap.Width / 2, -(float)bitmap.Height / 2);
            graphics.DrawImage(bitmap, new Point(0, 0));
            return returnBitmap;
        }
        private int y = 0;
        private void SpinButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (!timer1.Enabled)
            {
                wplayer.controls.stop();
                //Bitmap bmp1;
                //bmp1 = (Bitmap)Properties.Resources.test1;
                //SpinningBoard.Image = (Bitmap)rotateImage(bmp1, 100);                  
                int IDCategory = 0;
                if (y >= 0 && y <= 72)
                    IDCategory = 0; // do - serie
                else if (y > 72 && y <= 144)
                    IDCategory = 1; // xanh duong - cartoon
                else if (y > 144 && y <= 216)
                    IDCategory = 2; // xam - classic
                else if (y > 216 && y <= 288)
                    IDCategory = 3; // xang la - action
                else if (y > 288 && y <= 359)
                    IDCategory = 4; // vang - crown
                Thread.Sleep(1000);
                if (IDCategory == 4)
                {
                    ShowBadge(turn);
                    return;
                }
                form_q = new FormQuestion();
                categories.loadContent(IDCategory, form_q);
                this.Hide();
                form_q.ShowDialog(this);
                this.Show();
                if (check == true)
                {
                    team[turn] += 1;
                    switch (turn)
                    {
                        case 0: point1_TextChanged(sender, e); result[turn] += 2; result1.Text = Convert.ToString(result[turn]); break;
                        case 1: point2_TextChanged(sender, e); result[turn] += 2; result2.Text = Convert.ToString(result[turn]); break;
                        case 2: point3_TextChanged(sender, e); result[turn] += 2; result3.Text = Convert.ToString(result[turn]); break;
                        case 3: point4_TextChanged(sender, e); result[turn] += 2; result4.Text = Convert.ToString(result[turn]); break;
                    }
                    if (team[turn] == 2)
                    {
                        ShowBadge(turn);
                        return;
                    }
                }
                else
                {
                    turn++;
                    if (turn >= 4)
                    {
                        Tour.Text = "Tour: " + ++round;
                        for (int i = 0; i < 4; i++)
                        {
                            if (icon[i] < 4)
                                result[i] -= 10;
                        }
                        result1.Text = Convert.ToString(result[0]);
                        result2.Text = Convert.ToString(result[1]);
                        result3.Text = Convert.ToString(result[2]);
                        result4.Text = Convert.ToString(result[3]);
                        if (round > 8)
                            Tour.Text = "Jeu terminé";
                        turn = 0;
                    }
                    while (Badge[turn, 0] == 1 && Badge[turn, 1] == 1 && Badge[turn, 2] == 1 && Badge[turn, 3] == 1)
                    {
                        turn++;
                        if (turn >= 4)
                        {
                            Tour.Text = "Tour: " + ++round;
                            for (int i = 0; i < 4; i++)
                            {
                                if (icon[i] < 4)
                                    result[i] -= 10;
                            }
                            result1.Text = Convert.ToString(result[0]);
                            result2.Text = Convert.ToString(result[1]);
                            result3.Text = Convert.ToString(result[2]);
                            result4.Text = Convert.ToString(result[3]);
                            if (round > 8)
                                Tour.Text = "Jeu terminé";
                            turn = 0;
                        }
                    }
                }
                //Playing.Text = "Équipe: " + (turn + 1);
                switch (turn)
                {
                    case 0:
                        Playing.Text = "Les trois garcons chauds";
                        break;
                    case 1:
                        Playing.Text = "ĐAK";
                        break;
                    case 2:
                        Playing.Text = "Verseau";
                        break;
                    case 3:
                        Playing.Text = "1430";
                        break;
                }
            }
            else
            {
                wplayer.URL = "./sound/spin.mp3";
                wplayer.controls.play();
            }
            SavePoint();
        }

        int tick = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            Bitmap bmp1;
            bmp1 = (Bitmap)Properties.Resources.test1;
            y += 150;
            y %= 360;
            if (y == 0 || y == 72 || y == 144 || y == 216 || y == 288)
                y += 2;
            SpinningBoard.Image = (Bitmap)rotateImage(bmp1, y);
            SpinningBoard.Refresh();
            SpinningBoard.Invalidate();
        }

        private Game categories;
        private void Form1_Load_1(object sender, EventArgs e)
        {
            categories = null;
            string path = "Oficiel.xml";

            using (TextReader reader = new StreamReader(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Game));
                categories = (Game)serializer.Deserialize(reader);
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            form_q.Close();
            this.Close();
        }

        private void point1_TextChanged(object sender, EventArgs e)
        {
            //point1.Text = String.Empty;
            point1.Text = Convert.ToString(team[0]);
        }

        private void point2_TextChanged(object sender, EventArgs e)
        {
            //point2.Text = String.Empty;
            point2.Text = Convert.ToString(team[1]);
        }

        private void point3_TextChanged(object sender, EventArgs e)
        {
            //point3.Text = String.Empty;
            point3.Text = Convert.ToString(team[2]);
        }

        private void point4_TextChanged(object sender, EventArgs e)
        {
            //point4.Text = String.Empty;
            point4.Text = Convert.ToString(team[3]);
        }

        private void Badge0_Click(object sender, EventArgs e)
        {
            IDBadgeChoose = 0;
            ChooseBadge(turn);
        }

        private void Badge1_Click(object sender, EventArgs e)
        {
            IDBadgeChoose = 1;
            ChooseBadge(turn);
        }

        private void Badge2_Click(object sender, EventArgs e)
        {
            IDBadgeChoose = 2;
            ChooseBadge(turn);
        }

        private void Badge3_Click(object sender, EventArgs e)
        {
            IDBadgeChoose = 3;
            ChooseBadge(turn);
        }

        private void SavePoint()
        {
            if (File.Exists("RecoveryPoint.txt"))
            {
                File.Delete("OldRecoveryPoint.txt");
                File.Move("RecoveryPoint.txt", "OldRecoveryPoint.txt");
                File.Delete("RecoveryPoint.txt");
            }
            using (StreamWriter file = new System.IO.StreamWriter("RecoveryPoint.txt", true))
            {
                file.WriteLine(round);
                file.WriteLine(turn);
                for (int i = 0; i < 4; i++)
                    file.WriteLine(team[i]);
                for (int i = 0; i < 4; i++)
                    file.WriteLine(result[i]);
                for (int i = 0; i < 4; i++)
                    for (int j = 0; j < 4; j++)
                        file.WriteLine(Badge[i, j]);             
            }
        }

        private void ClearRev_Click(object sender, EventArgs e)
        {
            if (File.Exists("RecoveryAction.txt"))
                File.Delete("RecoveryAction.txt");
            if (File.Exists("RecoveryCartoon.txt"))
                File.Delete("RecoveryCartoon.txt");
            if (File.Exists("RecoverySerie.txt"))
                File.Delete("RecoverySerie.txt");
            if (File.Exists("RecoveryClassic.txt"))
                File.Delete("RecoveryClassic.txt");
            if (File.Exists("RecoveryPoint.txt"))
                File.Delete("RecoveryPoint.txt");
        }

        private void UpdateBadge()
        {
            if (File.Exists("RecoveryPoint.txt"))
                using (StreamReader file = new System.IO.StreamReader("RecoveryPoint.txt", true))
                {
                    round = Convert.ToInt32(file.ReadLine());
                    Tour.Text = "Tour: " + ++round;
                    turn = Convert.ToInt32(file.ReadLine());
                    for (int i = 0; i < 4; i++)
                        team[i] = Convert.ToInt32(file.ReadLine());
                    for (int i = 0; i < 4; i++)
                        result[i] = Convert.ToInt32(file.ReadLine());
                    for (int i = 0; i < 4; i++)
                        for (int j = 0; j < 4; j++)
                            Badge[i, j] = Convert.ToInt32(file.ReadLine());
                }
            result1.Text = Convert.ToString(result[0]);
            result2.Text = Convert.ToString(result[1]);
            result3.Text = Convert.ToString(result[2]);
            result4.Text = Convert.ToString(result[3]);
            point1.Text = Convert.ToString(team[0]);
            point2.Text = Convert.ToString(team[1]);
            point3.Text = Convert.ToString(team[2]);
            point4.Text = Convert.ToString(team[3]);
            Badge00.Visible = Convert.ToBoolean(Badge[0, 0]);
            Badge01.Visible = Convert.ToBoolean(Badge[0, 1]);
            Badge02.Visible = Convert.ToBoolean(Badge[0, 2]);
            Badge03.Visible = Convert.ToBoolean(Badge[0, 3]);
            Badge10.Visible = Convert.ToBoolean(Badge[1, 0]);
            Badge11.Visible = Convert.ToBoolean(Badge[1, 1]);
            Badge12.Visible = Convert.ToBoolean(Badge[1, 2]);
            Badge13.Visible = Convert.ToBoolean(Badge[1, 3]);
            Badge20.Visible = Convert.ToBoolean(Badge[2, 0]);
            Badge21.Visible = Convert.ToBoolean(Badge[2, 1]);
            Badge22.Visible = Convert.ToBoolean(Badge[2, 2]);
            Badge23.Visible = Convert.ToBoolean(Badge[2, 3]);
            Badge30.Visible = Convert.ToBoolean(Badge[3, 0]);
            Badge31.Visible = Convert.ToBoolean(Badge[3, 1]);
            Badge32.Visible = Convert.ToBoolean(Badge[3, 2]);
            Badge33.Visible = Convert.ToBoolean(Badge[3, 3]);
        }

        private void UpdateRev_Click(object sender, EventArgs e)
        {
            UpdateBadge();
            //Playing.Text = "Équipe: " + (turn + 1);
            switch(turn)
            {
                case 0:
                    Playing.Text = "Les trois garcons chauds";
                    break;
                case 1:
                    Playing.Text = "ĐAK";
                    break;
                case 2:
                    Playing.Text = "Verseau";
                    break;
                case 3:
                    Playing.Text = "1430";
                    break;
            }
            categories.UpdateRecovery();
            if (team[turn] == 2)
                ShowBadge(turn);        
        }
    }
}
