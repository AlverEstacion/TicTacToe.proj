﻿namespace TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(27, 75);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(96, 94);
            this.Btn1.TabIndex = 0;
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(27, 188);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(96, 94);
            this.Btn2.TabIndex = 1;
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(27, 300);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(96, 94);
            this.Btn3.TabIndex = 2;
            this.Btn3.UseVisualStyleBackColor = true;
            // 
            // Btn4
            // 
            this.Btn4.Location = new System.Drawing.Point(151, 75);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(96, 94);
            this.Btn4.TabIndex = 3;
            this.Btn4.UseVisualStyleBackColor = true;
            // 
            // Btn5
            // 
            this.Btn5.Location = new System.Drawing.Point(151, 188);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(96, 94);
            this.Btn5.TabIndex = 4;
            this.Btn5.UseVisualStyleBackColor = true;
            // 
            // Btn6
            // 
            this.Btn6.Location = new System.Drawing.Point(151, 300);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(96, 94);
            this.Btn6.TabIndex = 5;
            this.Btn6.UseVisualStyleBackColor = true;
            // 
            // Btn9
            // 
            this.Btn9.Location = new System.Drawing.Point(277, 300);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(96, 94);
            this.Btn9.TabIndex = 8;
            this.Btn9.UseVisualStyleBackColor = true;
            // 
            // Btn8
            // 
            this.Btn8.Location = new System.Drawing.Point(277, 188);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(96, 94);
            this.Btn8.TabIndex = 7;
            this.Btn8.UseVisualStyleBackColor = true;
            // 
            // Btn7
            // 
            this.Btn7.Location = new System.Drawing.Point(277, 75);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(96, 94);
            this.Btn7.TabIndex = 6;
            this.Btn7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(400, 428);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
    }
}

