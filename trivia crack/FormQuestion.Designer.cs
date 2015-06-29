namespace trivia_crack
{
    partial class FormQuestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AnswerA = new System.Windows.Forms.Button();
            this.AnswerB = new System.Windows.Forms.Button();
            this.AnswerC = new System.Windows.Forms.Button();
            this.AnswerD = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Content = new System.Windows.Forms.RichTextBox();
            this.Clock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AnswerA
            // 
            this.AnswerA.BackColor = System.Drawing.SystemColors.Control;
            this.AnswerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AnswerA.Location = new System.Drawing.Point(12, 540);
            this.AnswerA.Name = "AnswerA";
            this.AnswerA.Size = new System.Drawing.Size(486, 76);
            this.AnswerA.TabIndex = 1;
            this.AnswerA.Text = "button1";
            this.AnswerA.UseVisualStyleBackColor = false;
            this.AnswerA.Click += new System.EventHandler(this.AnswerA_Click);
            // 
            // AnswerB
            // 
            this.AnswerB.BackColor = System.Drawing.SystemColors.Control;
            this.AnswerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AnswerB.Location = new System.Drawing.Point(514, 540);
            this.AnswerB.Name = "AnswerB";
            this.AnswerB.Size = new System.Drawing.Size(483, 76);
            this.AnswerB.TabIndex = 2;
            this.AnswerB.Text = "button2";
            this.AnswerB.UseVisualStyleBackColor = false;
            this.AnswerB.Click += new System.EventHandler(this.AnswerB_Click);
            // 
            // AnswerC
            // 
            this.AnswerC.BackColor = System.Drawing.SystemColors.Control;
            this.AnswerC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AnswerC.Location = new System.Drawing.Point(12, 635);
            this.AnswerC.Name = "AnswerC";
            this.AnswerC.Size = new System.Drawing.Size(486, 76);
            this.AnswerC.TabIndex = 3;
            this.AnswerC.Text = "button3";
            this.AnswerC.UseVisualStyleBackColor = false;
            this.AnswerC.Click += new System.EventHandler(this.AnswerC_Click);
            // 
            // AnswerD
            // 
            this.AnswerD.BackColor = System.Drawing.SystemColors.Control;
            this.AnswerD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AnswerD.Location = new System.Drawing.Point(514, 635);
            this.AnswerD.Name = "AnswerD";
            this.AnswerD.Size = new System.Drawing.Size(483, 76);
            this.AnswerD.TabIndex = 4;
            this.AnswerD.Text = "button4";
            this.AnswerD.UseVisualStyleBackColor = false;
            this.AnswerD.Click += new System.EventHandler(this.AnswerD_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(119, 241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(787, 293);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Content
            // 
            this.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Content.Location = new System.Drawing.Point(12, 12);
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            this.Content.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Content.Size = new System.Drawing.Size(984, 223);
            this.Content.TabIndex = 7;
            this.Content.Text = "";
            // 
            // Clock
            // 
            this.Clock.AutoSize = true;
            this.Clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock.Location = new System.Drawing.Point(12, 241);
            this.Clock.MinimumSize = new System.Drawing.Size(80, 80);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(80, 80);
            this.Clock.TabIndex = 8;
            this.Clock.Text = "20";
            this.Clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.Clock);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AnswerD);
            this.Controls.Add(this.AnswerC);
            this.Controls.Add(this.AnswerB);
            this.Controls.Add(this.AnswerA);
            this.MinimumSize = new System.Drawing.Size(300, 50);
            this.Name = "FormQuestion";
            this.Text = "FormQuestion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button AnswerA;
        public System.Windows.Forms.Button AnswerB;
        public System.Windows.Forms.Button AnswerC;
        public System.Windows.Forms.Button AnswerD;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.RichTextBox Content;
        private System.Windows.Forms.Label Clock;
    }
}