namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        int i = 0;
        List<string> TimeTables = new List<string>() { "Подъём", "Завтрак", "Перекличка", "Работа", "Обед", "Cвободное Время", "Ужин", "Подготовка ко сну", "Сон" };
        public Form1()
        {
            InitializeComponent();
            StartTest();
            TimeTableLabel.Text = TimeTables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 0:

                break;
            }
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
           
        }
        public void StartTest()
        {
            
        }
    }
}
