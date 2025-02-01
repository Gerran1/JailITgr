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
            pictureBox2 = new PictureBox();
            buttonLibrary = new Button();
            buttonTheif = new Button();
            listBoxBooks = new ListBox();
            buttonBuy = new Button();
            buttonTrade = new Button();
            buttonGym = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLocation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLocation
            // 
            pictureBoxLocation.BackColor = Color.AntiqueWhite;
            pictureBoxLocation.Image = Properties.Resources.prison_cell;
            pictureBoxLocation.Location = new Point(176, -1);
            pictureBoxLocation.Name = "pictureBoxLocation";
            pictureBoxLocation.Size = new Size(624, 452);
            pictureBoxLocation.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLocation.TabIndex = 0;
            pictureBoxLocation.TabStop = false;
            // 
            // TimeTableLabel
            // 
            TimeTableLabel.AutoSize = true;
            TimeTableLabel.Font = new Font("Ink Free", 9F, FontStyle.Bold | FontStyle.Italic);
            TimeTableLabel.ForeColor = Color.LavenderBlush;
            TimeTableLabel.Location = new Point(9, 30);
            TimeTableLabel.Name = "TimeTableLabel";
            TimeTableLabel.Size = new Size(12, 15);
            TimeTableLabel.TabIndex = 2;
            TimeTableLabel.Text = "-";
            // 
            // button1
            // 
            button1.BackColor = Color.SlateGray;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Ink Free", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.LavenderBlush;
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
            label1.BackColor = Color.LightSlateGray;
            label1.Font = new Font("Ink Free", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.LavenderBlush;
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 4;
            label1.Text = "Расписание: ";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.LavenderBlush;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = Properties.Resources.Lua;
            pictureBox2.Location = new Point(9, 54);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(137, 137);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // buttonLibrary
            // 
            buttonLibrary.BackColor = Color.SlateGray;
            buttonLibrary.FlatStyle = FlatStyle.Popup;
            buttonLibrary.Font = new Font("Ink Free", 9F, FontStyle.Bold | FontStyle.Italic);
            buttonLibrary.ForeColor = Color.LavenderBlush;
            buttonLibrary.Location = new Point(9, 415);
            buttonLibrary.Name = "buttonLibrary";
            buttonLibrary.Size = new Size(88, 23);
            buttonLibrary.TabIndex = 6;
            buttonLibrary.Text = "Библеотека";
            buttonLibrary.TextAlign = ContentAlignment.BottomCenter;
            buttonLibrary.UseVisualStyleBackColor = false;
            buttonLibrary.Click += buttonLibrary_Click;
            // 
            // buttonTheif
            // 
            buttonTheif.BackColor = Color.SlateGray;
            buttonTheif.FlatStyle = FlatStyle.Popup;
            buttonTheif.Font = new Font("Ink Free", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonTheif.ForeColor = Color.LavenderBlush;
            buttonTheif.Location = new Point(9, 197);
            buttonTheif.Name = "buttonTheif";
            buttonTheif.Size = new Size(81, 23);
            buttonTheif.TabIndex = 7;
            buttonTheif.Text = "Своровать";
            buttonTheif.UseVisualStyleBackColor = false;
            buttonTheif.Click += buttonTheif_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.BackColor = Color.LightSeaGreen;
            listBoxBooks.Font = new Font("Ink Free", 9F, FontStyle.Bold | FontStyle.Italic);
            listBoxBooks.ForeColor = Color.LavenderBlush;
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(176, -1);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(624, 124);
            listBoxBooks.TabIndex = 8;
            // 
            // buttonBuy
            // 
            buttonBuy.FlatStyle = FlatStyle.Popup;
            buttonBuy.Font = new Font("Ink Free", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonBuy.ForeColor = Color.LavenderBlush;
            buttonBuy.Location = new Point(176, 121);
            buttonBuy.Name = "buttonBuy";
            buttonBuy.Size = new Size(75, 31);
            buttonBuy.TabIndex = 9;
            buttonBuy.Text = "Купить";
            buttonBuy.UseVisualStyleBackColor = true;
            buttonBuy.Click += buttonBuy_Click;
            // 
            // buttonTrade
            // 
            buttonTrade.BackColor = Color.SlateGray;
            buttonTrade.FlatStyle = FlatStyle.Popup;
            buttonTrade.Font = new Font("Ink Free", 9F, FontStyle.Bold | FontStyle.Italic);
            buttonTrade.ForeColor = Color.LavenderBlush;
            buttonTrade.Location = new Point(96, 197);
            buttonTrade.Name = "buttonTrade";
            buttonTrade.Size = new Size(74, 23);
            buttonTrade.TabIndex = 10;
            buttonTrade.Text = "Продать";
            buttonTrade.UseVisualStyleBackColor = false;
            buttonTrade.Click += buttonTrade_Click;
            // 
            // buttonGym
            // 
            buttonGym.FlatStyle = FlatStyle.Popup;
            buttonGym.Font = new Font("Ink Free", 9F, FontStyle.Bold | FontStyle.Italic);
            buttonGym.ForeColor = Color.LavenderBlush;
            buttonGym.Location = new Point(9, 386);
            buttonGym.Name = "buttonGym";
            buttonGym.Size = new Size(88, 23);
            buttonGym.TabIndex = 11;
            buttonGym.Text = "Качалка";
            buttonGym.UseVisualStyleBackColor = true;
            buttonGym.Click += buttonGym_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonGym);
            Controls.Add(buttonTrade);
            Controls.Add(buttonBuy);
            Controls.Add(listBoxBooks);
            Controls.Add(buttonTheif);
            Controls.Add(buttonLibrary);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(TimeTableLabel);
            Controls.Add(pictureBoxLocation);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLocation).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLocation;
        private Label TimeTableLabel;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox2;
        private Button buttonLibrary;
        private Button buttonTheif;
        private ListBox listBoxBooks;
        private Button buttonBuy;
        private Button buttonTrade;
        private Button buttonGym;
    }
}
