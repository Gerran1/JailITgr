namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        int i = 0;
        List<string> TimeTables = new List<string>() { "������", "�������", "����������", "������", "����", "C�������� �����", "����", "���������� �� ���", "���" };
        public Form1()
        {
            InitializeComponent();
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
            
        }
    }
}
