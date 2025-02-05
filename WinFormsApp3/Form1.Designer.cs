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
            components = new System.ComponentModel.Container();
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
            listBoxTradeInventory = new ListBox();
            buttonStreet = new Button();
            toolTip1 = new ToolTip(components);
            listBoxInventoryBox = new ListBox();
            buttonOpenBox = new Button();
            buttonPutItem = new Button();

            ((System.ComponentModel.ISupportInitialize)pictureBoxLocation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLocation
            // 
            pictureBoxLocation.BackColor = Color.AntiqueWhite;
            pictureBoxLocation.Location = new Point(176, -1);
            pictureBoxLocation.Name = "pictureBoxLocation";
            pictureBoxLocation.Size = new Size(624, 452);
            pictureBoxLocation.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLocation.TabIndex = 0;
            pictureBoxLocation.TabStop = false;
            toolTip1.SetToolTip(pictureBoxLocation, "Вы сейчас находитесь здесь");
            // 
            // TimeTableLabel
            // 
            TimeTableLabel.AutoSize = true;
            TimeTableLabel.BackColor = Color.Transparent;
            TimeTableLabel.Font = new Font("Ink Free", 9F, FontStyle.Bold | FontStyle.Italic);
            TimeTableLabel.ForeColor = Color.LavenderBlush;
            TimeTableLabel.Location = new Point(9, 30);
            TimeTableLabel.Name = "TimeTableLabel";
            TimeTableLabel.Size = new Size(12, 15);
            TimeTableLabel.TabIndex = 2;
            TimeTableLabel.Text = "-";
            toolTip1.SetToolTip(TimeTableLabel, "Текущее время");
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.Cursor = Cursors.Hand;
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
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Ink Free", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.LavenderBlush;
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
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
            toolTip1.SetToolTip(pictureBox2, "Это вы");
            // 
            // buttonLibrary
            // 
            buttonLibrary.BackColor = Color.DimGray;
            buttonLibrary.Cursor = Cursors.Hand;
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
            buttonTheif.BackColor = Color.DimGray;
            buttonTheif.Cursor = Cursors.Hand;
            buttonTheif.FlatStyle = FlatStyle.Popup;
            buttonTheif.Font = new Font("Ink Free", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonTheif.ForeColor = Color.LavenderBlush;
            buttonTheif.Location = new Point(9, 197);
            buttonTheif.Name = "buttonTheif";
            buttonTheif.Size = new Size(88, 23);
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
            toolTip1.SetToolTip(listBoxBooks, "Книги");
            // 
            // buttonBuy
            // 
            buttonBuy.BackColor = Color.DimGray;
            buttonBuy.Cursor = Cursors.Hand;
            buttonBuy.FlatStyle = FlatStyle.Popup;
            buttonBuy.Font = new Font("Ink Free", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonBuy.ForeColor = Color.LavenderBlush;
            buttonBuy.Location = new Point(176, 119);
            buttonBuy.Name = "buttonBuy";
            buttonBuy.Size = new Size(75, 30);
            buttonBuy.TabIndex = 9;
            buttonBuy.Text = "Купить";
            buttonBuy.UseVisualStyleBackColor = false;
            buttonBuy.Click += buttonBuy_Click;
            // 
            // buttonTrade
            // 
            buttonTrade.BackColor = Color.DimGray;
            buttonTrade.Cursor = Cursors.Hand;
            buttonTrade.FlatStyle = FlatStyle.Popup;
            buttonTrade.Font = new Font("Ink Free", 9F, FontStyle.Bold | FontStyle.Italic);
            buttonTrade.ForeColor = Color.LavenderBlush;
            buttonTrade.Location = new Point(177, 114);
            buttonTrade.Name = "buttonTrade";
            buttonTrade.Size = new Size(74, 26);
            buttonTrade.TabIndex = 10;
            buttonTrade.Text = "Продать";
            buttonTrade.UseVisualStyleBackColor = false;
            buttonTrade.Click += buttonTrade_Click;
            // 
            // buttonGym
            // 
            buttonGym.BackColor = Color.DimGray;
            buttonGym.Cursor = Cursors.Hand;
            buttonGym.FlatStyle = FlatStyle.Popup;
            buttonGym.Font = new Font("Ink Free", 9F, FontStyle.Bold | FontStyle.Italic);
            buttonGym.ForeColor = Color.LavenderBlush;
            buttonGym.Location = new Point(9, 386);
            buttonGym.Name = "buttonGym";
            buttonGym.Size = new Size(88, 23);
            buttonGym.TabIndex = 11;
            buttonGym.Text = "Качалка";
            buttonGym.UseVisualStyleBackColor = false;
            buttonGym.Click += buttonGym_Click;
            // 
            // listBoxTradeInventory
            // 
            listBoxTradeInventory.BackColor = Color.DimGray;
            listBoxTradeInventory.Cursor = Cursors.Hand;
            listBoxTradeInventory.Font = new Font("Ink Free", 9F, FontStyle.Bold | FontStyle.Italic);
            listBoxTradeInventory.ForeColor = Color.LavenderBlush;
            listBoxTradeInventory.FormattingEnabled = true;
            listBoxTradeInventory.ItemHeight = 15;
            listBoxTradeInventory.Location = new Point(176, -1);
            listBoxTradeInventory.Name = "listBoxTradeInventory";
            listBoxTradeInventory.Size = new Size(312, 109);
            listBoxTradeInventory.TabIndex = 13;
            toolTip1.SetToolTip(listBoxTradeInventory, "Ваш инвентарь предметов на продажу");
            // 
            // buttonStreet
            // 
            buttonStreet.BackColor = Color.DimGray;
            buttonStreet.Cursor = Cursors.Hand;
            buttonStreet.FlatStyle = FlatStyle.Popup;
            buttonStreet.Font = new Font("Ink Free", 9F, FontStyle.Bold | FontStyle.Italic);
            buttonStreet.ForeColor = Color.LavenderBlush;
            buttonStreet.Location = new Point(9, 357);
            buttonStreet.Name = "buttonStreet";
            buttonStreet.Size = new Size(88, 23);
            buttonStreet.TabIndex = 14;
            buttonStreet.Text = "Улица";
            buttonStreet.UseVisualStyleBackColor = false;
            buttonStreet.Click += buttonStreet_Click;
            // 
            // listBoxInventoryBox
            // 
            listBoxInventoryBox.BackColor = Color.DimGray;
            listBoxInventoryBox.Cursor = Cursors.Hand;
            listBoxInventoryBox.Font = new Font("Ink Free", 9F, FontStyle.Bold | FontStyle.Italic);
            listBoxInventoryBox.ForeColor = Color.LavenderBlush;
            listBoxInventoryBox.FormattingEnabled = true;
            listBoxInventoryBox.ItemHeight = 15;
            listBoxInventoryBox.Location = new Point(494, -1);
            listBoxInventoryBox.Name = "listBoxInventoryBox";
            listBoxInventoryBox.Size = new Size(306, 109);
            listBoxInventoryBox.TabIndex = 16;
            toolTip1.SetToolTip(listBoxInventoryBox, "Ящик");          
            // 
            // buttonOpenBox
            // 
            buttonOpenBox.BackColor = Color.DimGray;
            buttonOpenBox.FlatStyle = FlatStyle.Popup;
            buttonOpenBox.Font = new Font("Ink Free", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonOpenBox.ForeColor = Color.LavenderBlush;
            buttonOpenBox.Location = new Point(705, 368);
            buttonOpenBox.Name = "buttonOpenBox";
            buttonOpenBox.Size = new Size(83, 23);
            buttonOpenBox.TabIndex = 15;
            buttonOpenBox.Text = "Ящик";
            buttonOpenBox.UseVisualStyleBackColor = false;
            buttonOpenBox.Click += buttonOpenBox_Click;
            // 
            // buttonPutItem
            // 
            buttonPutItem.BackColor = Color.DimGray;
            buttonPutItem.Cursor = Cursors.Hand;
            buttonPutItem.FlatStyle = FlatStyle.Popup;
            buttonPutItem.Font = new Font("Ink Free", 9F, FontStyle.Bold | FontStyle.Italic);
            buttonPutItem.ForeColor = Color.LavenderBlush;
            buttonPutItem.Location = new Point(445, 114);
            buttonPutItem.Name = "buttonPutItem";
            buttonPutItem.Size = new Size(90, 26);
            buttonPutItem.TabIndex = 17;
            buttonPutItem.Text = "Переложить";
            buttonPutItem.UseVisualStyleBackColor = false;
            buttonPutItem.Click += buttonPutItem_Click;           
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            BackgroundImage = Properties.Resources.grey_stena;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonPutItem);
            Controls.Add(listBoxInventoryBox);
            Controls.Add(buttonOpenBox);
            Controls.Add(buttonStreet);
            Controls.Add(listBoxTradeInventory);
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
        private ListBox listBoxTradeInventory;
        private Button buttonStreet;
        private ToolTip toolTip1;
        private Button buttonOpenBox;
        private ListBox listBoxInventoryBox;
        private Button buttonPutItem;
    }
}
