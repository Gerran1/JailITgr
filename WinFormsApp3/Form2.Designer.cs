﻿namespace WinFormsApp3
{
    partial class Form2
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
            pictureBoxDialog = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDialog).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxDialog
            // 
            pictureBoxDialog.Image = Properties.Resources.Itgr_black;
            pictureBoxDialog.Location = new Point(0, 0);
            pictureBoxDialog.Name = "pictureBoxDialog";
            pictureBoxDialog.Size = new Size(643, 408);
            pictureBoxDialog.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDialog.TabIndex = 0;
            pictureBoxDialog.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Ink Free", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.LavenderBlush;
            button1.Location = new Point(530, 856);
            button1.Name = "button1";
            button1.Size = new Size(98, 58);
            button1.TabIndex = 1;
            button1.Text = "→";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Ink Free", 11.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LavenderBlush;
            label1.Location = new Point(0, 411);
            label1.MaximumSize = new Size(500, 0);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 2;
            label1.Text = "-";
            label1.Click += label1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(640, 926);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBoxDialog);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBoxDialog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxDialog;
        private Button button1;
        private Label label1;
    }
}