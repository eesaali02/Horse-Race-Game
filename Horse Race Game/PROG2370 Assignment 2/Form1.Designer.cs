namespace PROG2370_Assignment_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblHorseRace = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.picHorse1 = new System.Windows.Forms.PictureBox();
            this.picHorse2 = new System.Windows.Forms.PictureBox();
            this.picHorse3 = new System.Windows.Forms.PictureBox();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblTiming = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHorse1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblHorse1Timing = new System.Windows.Forms.Label();
            this.lblHorse3Timing = new System.Windows.Forms.Label();
            this.lblHorse2Timing = new System.Windows.Forms.Label();
            this.lblHorse3Speed = new System.Windows.Forms.Label();
            this.lblHorse2Speed = new System.Windows.Forms.Label();
            this.lblHorse1Speed = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.counter1 = new System.Windows.Forms.Timer(this.components);
            this.counter2 = new System.Windows.Forms.Timer(this.components);
            this.counter3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHorse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHorse2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHorse3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(546, 513);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(196, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(164, 161);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblHorseRace
            // 
            this.lblHorseRace.AutoSize = true;
            this.lblHorseRace.Location = new System.Drawing.Point(206, 222);
            this.lblHorseRace.Name = "lblHorseRace";
            this.lblHorseRace.Size = new System.Drawing.Size(77, 15);
            this.lblHorseRace.TabIndex = 2;
            this.lblHorseRace.Text = "Horse Racing";
            this.lblHorseRace.Click += new System.EventHandler(this.lblHorseRace_Click);
            // 
            // lblStart
            // 
            this.lblStart.BackColor = System.Drawing.Color.SeaGreen;
            this.lblStart.Location = new System.Drawing.Point(12, 219);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(188, 21);
            this.lblStart.TabIndex = 3;
            this.lblStart.Text = "Start ";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnd
            // 
            this.lblEnd.BackColor = System.Drawing.Color.SeaGreen;
            this.lblEnd.Location = new System.Drawing.Point(266, 320);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(21, 196);
            this.lblEnd.TabIndex = 4;
            this.lblEnd.Text = "F\r\nI\r\nN\r\nI\r\nS\r\nH";
            this.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picHorse1
            // 
            this.picHorse1.BackColor = System.Drawing.Color.Transparent;
            this.picHorse1.Image = global::PROG2370_Assignment_2.Properties.Resources.horse;
            this.picHorse1.Location = new System.Drawing.Point(116, 243);
            this.picHorse1.Name = "picHorse1";
            this.picHorse1.Size = new System.Drawing.Size(40, 40);
            this.picHorse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHorse1.TabIndex = 5;
            this.picHorse1.TabStop = false;
            // 
            // picHorse2
            // 
            this.picHorse2.BackColor = System.Drawing.Color.Transparent;
            this.picHorse2.Image = global::PROG2370_Assignment_2.Properties.Resources.horse;
            this.picHorse2.Location = new System.Drawing.Point(65, 243);
            this.picHorse2.Name = "picHorse2";
            this.picHorse2.Size = new System.Drawing.Size(40, 40);
            this.picHorse2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHorse2.TabIndex = 6;
            this.picHorse2.TabStop = false;
            // 
            // picHorse3
            // 
            this.picHorse3.BackColor = System.Drawing.Color.Transparent;
            this.picHorse3.Image = global::PROG2370_Assignment_2.Properties.Resources.horse;
            this.picHorse3.Location = new System.Drawing.Point(12, 243);
            this.picHorse3.Name = "picHorse3";
            this.picHorse3.Size = new System.Drawing.Size(40, 40);
            this.picHorse3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHorse3.TabIndex = 7;
            this.picHorse3.TabStop = false;
            // 
            // lblWinner
            // 
            this.lblWinner.BackColor = System.Drawing.Color.SeaGreen;
            this.lblWinner.Location = new System.Drawing.Point(591, 44);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(161, 21);
            this.lblWinner.TabIndex = 8;
            this.lblWinner.Text = "Winner: ";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSpeed
            // 
            this.lblSpeed.BackColor = System.Drawing.Color.SeaGreen;
            this.lblSpeed.Location = new System.Drawing.Point(591, 86);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(161, 21);
            this.lblSpeed.TabIndex = 9;
            this.lblSpeed.Text = "Speed: ";
            this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTiming
            // 
            this.lblTiming.BackColor = System.Drawing.Color.SeaGreen;
            this.lblTiming.Location = new System.Drawing.Point(591, 65);
            this.lblTiming.Name = "lblTiming";
            this.lblTiming.Size = new System.Drawing.Size(161, 21);
            this.lblTiming.TabIndex = 10;
            this.lblTiming.Text = "Timing: ";
            this.lblTiming.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SeaGreen;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(591, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Horse #";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SeaGreen;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(648, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Timing";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.SeaGreen;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(701, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Speed";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHorse1
            // 
            this.lblHorse1.BackColor = System.Drawing.Color.SeaGreen;
            this.lblHorse1.Location = new System.Drawing.Point(591, 216);
            this.lblHorse1.Name = "lblHorse1";
            this.lblHorse1.Size = new System.Drawing.Size(161, 21);
            this.lblHorse1.TabIndex = 14;
            this.lblHorse1.Text = "1";
            this.lblHorse1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHorse1.Click += new System.EventHandler(this.label7_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.SeaGreen;
            this.label7.Location = new System.Drawing.Point(591, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "3";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.SeaGreen;
            this.label8.Location = new System.Drawing.Point(591, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "2";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHorse1Timing
            // 
            this.lblHorse1Timing.BackColor = System.Drawing.Color.SeaGreen;
            this.lblHorse1Timing.Location = new System.Drawing.Point(648, 216);
            this.lblHorse1Timing.Name = "lblHorse1Timing";
            this.lblHorse1Timing.Size = new System.Drawing.Size(49, 21);
            this.lblHorse1Timing.TabIndex = 17;
            this.lblHorse1Timing.Text = "##";
            this.lblHorse1Timing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHorse3Timing
            // 
            this.lblHorse3Timing.BackColor = System.Drawing.Color.SeaGreen;
            this.lblHorse3Timing.Location = new System.Drawing.Point(648, 258);
            this.lblHorse3Timing.Name = "lblHorse3Timing";
            this.lblHorse3Timing.Size = new System.Drawing.Size(49, 21);
            this.lblHorse3Timing.TabIndex = 18;
            this.lblHorse3Timing.Text = "##";
            this.lblHorse3Timing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHorse2Timing
            // 
            this.lblHorse2Timing.BackColor = System.Drawing.Color.SeaGreen;
            this.lblHorse2Timing.Location = new System.Drawing.Point(648, 237);
            this.lblHorse2Timing.Name = "lblHorse2Timing";
            this.lblHorse2Timing.Size = new System.Drawing.Size(49, 21);
            this.lblHorse2Timing.TabIndex = 19;
            this.lblHorse2Timing.Text = "##";
            this.lblHorse2Timing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHorse3Speed
            // 
            this.lblHorse3Speed.BackColor = System.Drawing.Color.SeaGreen;
            this.lblHorse3Speed.Location = new System.Drawing.Point(703, 258);
            this.lblHorse3Speed.Name = "lblHorse3Speed";
            this.lblHorse3Speed.Size = new System.Drawing.Size(49, 21);
            this.lblHorse3Speed.TabIndex = 20;
            this.lblHorse3Speed.Text = "##";
            this.lblHorse3Speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHorse2Speed
            // 
            this.lblHorse2Speed.BackColor = System.Drawing.Color.SeaGreen;
            this.lblHorse2Speed.Location = new System.Drawing.Point(703, 237);
            this.lblHorse2Speed.Name = "lblHorse2Speed";
            this.lblHorse2Speed.Size = new System.Drawing.Size(49, 21);
            this.lblHorse2Speed.TabIndex = 21;
            this.lblHorse2Speed.Text = "##";
            this.lblHorse2Speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHorse1Speed
            // 
            this.lblHorse1Speed.BackColor = System.Drawing.Color.SeaGreen;
            this.lblHorse1Speed.Location = new System.Drawing.Point(703, 216);
            this.lblHorse1Speed.Name = "lblHorse1Speed";
            this.lblHorse1Speed.Size = new System.Drawing.Size(49, 21);
            this.lblHorse1Speed.TabIndex = 22;
            this.lblHorse1Speed.Text = "##";
            this.lblHorse1Speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnStart.Location = new System.Drawing.Point(591, 327);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(81, 28);
            this.btnStart.TabIndex = 23;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRestart.Location = new System.Drawing.Point(671, 327);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(81, 28);
            this.btnRestart.TabIndex = 24;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // counter1
            // 
            this.counter1.Tick += new System.EventHandler(this.counter1_Tick);
            // 
            // counter2
            // 
            this.counter2.Tick += new System.EventHandler(this.counter2_Tick);
            // 
            // counter3
            // 
            this.counter3.Tick += new System.EventHandler(this.counter3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(846, 602);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblHorse1Speed);
            this.Controls.Add(this.lblHorse2Speed);
            this.Controls.Add(this.lblHorse3Speed);
            this.Controls.Add(this.lblHorse2Timing);
            this.Controls.Add(this.lblHorse3Timing);
            this.Controls.Add(this.lblHorse1Timing);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblHorse1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTiming);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.picHorse3);
            this.Controls.Add(this.picHorse2);
            this.Controls.Add(this.picHorse1);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblHorseRace);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHorse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHorse2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHorse3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblHorseRace;
        private Label lblStart;
        private Label lblEnd;
        private PictureBox picHorse1;
        private PictureBox picHorse2;
        private PictureBox picHorse3;
        private Label lblWinner;
        private Label lblSpeed;
        private Label lblTiming;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblHorse1;
        private Label label7;
        private Label label8;
        private Label lblHorse1Timing;
        private Label lblHorse3Timing;
        private Label lblHorse2Timing;
        private Label lblHorse3Speed;
        private Label lblHorse2Speed;
        private Label lblHorse1Speed;
        private Button btnStart;
        private Button btnRestart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer counter1;
        private System.Windows.Forms.Timer counter2;
        private System.Windows.Forms.Timer counter3;
    }
}