﻿namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.PhysicsTimer = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(223, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(999, 528);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // AnimationTimer
            // 
            this.AnimationTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PhysicsTimer
            // 
            this.PhysicsTimer.Tick += new System.EventHandler(this.PhysicsTimer_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(64, 386);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Run Simulator";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "RotateJetsClock";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(107, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "RotateJetsAnti";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(9, 313);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(39, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Jet1";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(9, 255);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(39, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "Jet2";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 284);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(63, 23);
            this.button8.TabIndex = 9;
            this.button8.Text = "Jet1and2";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Jet3and4";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(117, 226);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(39, 23);
            this.button9.TabIndex = 11;
            this.button9.Text = "Jet4";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(57, 226);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(39, 23);
            this.button10.TabIndex = 10;
            this.button10.Text = "Jet3";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(134, 284);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(63, 23);
            this.button11.TabIndex = 15;
            this.button11.Text = "Jet5and6";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(178, 255);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(39, 23);
            this.button12.TabIndex = 14;
            this.button12.Text = "Jet5";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(178, 313);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(39, 23);
            this.button13.TabIndex = 13;
            this.button13.Text = "Jet6";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(64, 328);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Jet7and8";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(117, 357);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(39, 23);
            this.button6.TabIndex = 17;
            this.button6.Text = "Jet7";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(57, 357);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(39, 23);
            this.button14.TabIndex = 16;
            this.button14.Text = "Jet8";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(89, 299);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(39, 23);
            this.button15.TabIndex = 19;
            this.button15.Text = "0";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(12, 210);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(39, 23);
            this.button16.TabIndex = 20;
            this.button16.Text = "0";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(81, 442);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(98, 17);
            this.checkBox2.TabIndex = 21;
            this.checkBox2.Text = "Play Recording";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(12, 436);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(63, 23);
            this.button17.TabIndex = 22;
            this.button17.Text = "Reset";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(12, 465);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(108, 23);
            this.button18.TabIndex = 23;
            this.button18.Text = "Reset Recording";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Blue",
            "Red",
            "Green"});
            this.listBox1.Location = new System.Drawing.Point(3, 543);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(214, 56);
            this.listBox1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 527);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Raw Sensor Sims";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "0";
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(64, 62);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 71);
            this.button19.TabIndex = 27;
            this.button19.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "6";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "7";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(64, 409);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(59, 17);
            this.checkBox3.TabIndex = 35;
            this.checkBox3.Text = "Run AI";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(126, 465);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 23);
            this.button20.TabIndex = 36;
            this.button20.Text = "reset items";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(158, 3);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(39, 23);
            this.button21.TabIndex = 37;
            this.button21.Text = "0";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(307, 555);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "label10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 605);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer AnimationTimer;
        private System.Windows.Forms.Timer PhysicsTimer;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Label label10;
    }
}

