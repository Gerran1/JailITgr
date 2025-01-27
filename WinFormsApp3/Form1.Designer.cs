namespace WinFormsApp3
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
            pictureBoxLocation = new PictureBox();
            TimeTableLabel = new Label();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLocation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLocation
            // 
            pictureBoxLocation.BackColor = SystemColors.ButtonShadow;
            pictureBoxLocation.Location = new Point(12, 27);
            pictureBoxLocation.Name = "pictureBoxLocation";
            pictureBoxLocation.Size = new Size(776, 411);
            pictureBoxLocation.TabIndex = 0;
            pictureBoxLocation.TabStop = false;
            // 
            // TimeTableLabel
            // 
            TimeTableLabel.AutoSize = true;
            TimeTableLabel.Location = new Point(82, 9);
            TimeTableLabel.Name = "TimeTableLabel";
            TimeTableLabel.Size = new Size(12, 15);
            TimeTableLabel.TabIndex = 2;
            TimeTableLabel.Text = "-";
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.Font = new Font("Baskerville Old Face", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(705, 397);
            button1.Name = "button1";
            button1.Size = new Size(83, 41);
            button1.TabIndex = 3;
            button1.Text = " Далее";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-2, 9);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 4;
            label1.Text = "Расписание: ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Cornsilk;
            pictureBox1.Location = new Point(532, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 256);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(TimeTableLabel);
            Controls.Add(pictureBoxLocation);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLocation).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLocation;
        private Label TimeTableLabel;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
