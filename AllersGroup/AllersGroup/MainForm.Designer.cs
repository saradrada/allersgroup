﻿namespace AllersGroup
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.mini_slide = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_G221 = new AllersGroup.UC_G22();
            this.uC_G31 = new AllersGroup.UC_G3();
            this.uC_G41 = new AllersGroup.UC_G4();
            this.uC_G51 = new AllersGroup.UC_G5();
            this.uC_P111 = new AllersGroup.UC_P11();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 42);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(11, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(129, 42);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // minimize
            // 
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.Location = new System.Drawing.Point(1070, 4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(30, 30);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize.TabIndex = 3;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(1106, 4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 30);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 2;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.panel4.Controls.Add(this.uC_P111);
            this.panel4.Controls.Add(this.uC_G51);
            this.panel4.Controls.Add(this.uC_G41);
            this.panel4.Controls.Add(this.uC_G31);
            this.panel4.Controls.Add(this.uC_G221);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(70, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1071, 643);
            this.panel4.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(12, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 37);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(12, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 44);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(22, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 34);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(9, 221);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 37);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(11, 285);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(58, 37);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // mini_slide
            // 
            this.mini_slide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(114)))));
            this.mini_slide.Location = new System.Drawing.Point(0, 33);
            this.mini_slide.Name = "mini_slide";
            this.mini_slide.Size = new System.Drawing.Size(10, 36);
            this.mini_slide.TabIndex = 8;
            this.mini_slide.Visible = false;
            this.mini_slide.Paint += new System.Windows.Forms.PaintEventHandler(this.mini_slide_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.mini_slide);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(70, 643);
            this.panel2.TabIndex = 1;
            // 
            // uC_G221
            // 
            this.uC_G221.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.uC_G221.Location = new System.Drawing.Point(0, 0);
            this.uC_G221.Name = "uC_G221";
            this.uC_G221.Size = new System.Drawing.Size(1000, 1950);
            this.uC_G221.TabIndex = 0;
            // 
            // uC_G31
            // 
            this.uC_G31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.uC_G31.Location = new System.Drawing.Point(0, 0);
            this.uC_G31.Name = "uC_G31";
            this.uC_G31.Size = new System.Drawing.Size(1000, 2266);
            this.uC_G31.TabIndex = 1;
            // 
            // uC_G41
            // 
            this.uC_G41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.uC_G41.Location = new System.Drawing.Point(0, 0);
            this.uC_G41.Name = "uC_G41";
            this.uC_G41.Size = new System.Drawing.Size(1000, 1484);
            this.uC_G41.TabIndex = 2;
            // 
            // uC_G51
            // 
            this.uC_G51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.uC_G51.Location = new System.Drawing.Point(0, 0);
            this.uC_G51.Name = "uC_G51";
            this.uC_G51.Size = new System.Drawing.Size(1000, 1750);
            this.uC_G51.TabIndex = 3;
            // 
            // uC_P111
            // 
            this.uC_P111.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.uC_P111.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.uC_P111.ForeColor = System.Drawing.Color.BurlyWood;
            this.uC_P111.Location = new System.Drawing.Point(0, 0);
            this.uC_P111.Name = "uC_P111";
            this.uC_P111.Size = new System.Drawing.Size(1000, 1704);
            this.uC_P111.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1141, 685);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "AuxForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel mini_slide;
        private System.Windows.Forms.Panel panel2;
        private UC_P11 uC_P111;
        private UC_G5 uC_G51;
        private UC_G4 uC_G41;
        private UC_G3 uC_G31;
        private UC_G22 uC_G221;
    }
}