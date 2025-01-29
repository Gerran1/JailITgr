namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        int i = 0;
        List<string> TimeTables = new List<string>() { "Подъём", "Завтрак", "Перекличка", "Работа", "Обед", "Cвободное Время", "Ужин", "Подготовка ко сну", "Сон" };
        public Form1()
        {
            InitializeComponent();
            Test();
            TimeTableLabel.Text = TimeTables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i != 8)
            {
                i++;
                TimeTableLabel.Text = TimeTables[i];
            }
            else
            {
                i = 0;
                TimeTableLabel.Text = TimeTables[i];
            }
            switch (i)
            {
                case 0:
                    //подъём
                    pictureBoxLocation.Image = Properties.Resources.prison_cell;

                    break;
                case 1:
                    //Завтрак
                    pictureBoxLocation.Image = Properties.Resources.dining_room;
                    break;
                case 2:
                    //Перекличка
                    pictureBoxLocation.Image = Properties.Resources.prison_cell;
                    break;
                case 3:
                    //Работа
                    pictureBoxLocation.Image = Properties.Resources.work;
                    break;
                case 4:
                    //Обед
                    pictureBoxLocation.Image = Properties.Resources.dining_room;
                    break;
                case 5:
                    //Cвободное Время
                    pictureBoxLocation.Image = Properties.Resources.street;
                    break;
                case 6:
                    //Ужин
                    pictureBoxLocation.Image = Properties.Resources.dining_room;
                    break;
                case 7:
                    //Подготовка ко сну
                    pictureBoxLocation.Image = Properties.Resources.prison_cell;
                    break;
                case 8:
                    //Сон
                    pictureBoxLocation.Image = Properties.Resources.prison_cell;
                    break;
            }


        }
        public void Test()
        {
            int testPoints = 0;

            DialogResult dr = MessageBox.Show("Опыт в кодинге более 3-х лет?", "Первый вопрос", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                testPoints += 2;
            }
            else
            {
                testPoints += 1;
            }

            dr = MessageBox.Show("Паттерны использовал?", "Второй вопрос", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                testPoints += 2;
            }
            else
            {
                testPoints += 1;
            }

            dr = MessageBox.Show("Чужой код воровал", "Третий вопрос?", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                testPoints += 1;
            }
            else
            {
                testPoints += 2;
            }

            if (testPoints == 6)
            {
                MessageBox.Show("Ну тут всё понятно, это Lua");
                pictureBox2.Image = Properties.Resources.assembler;
            }
            else if (testPoints >= 4 && testPoints < 6)
            {
                MessageBox.Show("Вот ты и попался питонист!");
                pictureBox2.Image = Properties.Resources.python;
            }
            else if (testPoints == 3)
            {
                MessageBox.Show("Ооооо, плюсы тебя с костями съедят, паскальный!");
                pictureBox2.Image = Properties.Resources.Pascal;
            }
        }
    }
}