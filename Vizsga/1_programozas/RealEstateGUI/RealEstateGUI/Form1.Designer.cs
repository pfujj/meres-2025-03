﻿namespace RealEstateGUI
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
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 27);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "Eladó neve:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 42);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 2;
            label2.Text = "Eladó telefonszáma:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(164, 86);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 3;
            label3.Text = "Hirdetések száma:";
            // 
            // button1
            // 
            button1.Location = new Point(164, 60);
            button1.Name = "button1";
            button1.Size = new Size(176, 23);
            button1.TabIndex = 4;
            button1.Text = "Hirdetések betöltése";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}
