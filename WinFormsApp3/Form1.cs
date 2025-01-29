namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        int i = 0;
        List<string> TimeTables = new List<string>() { "������", "�������", "����������", "������", "����", "C�������� �����", "����", "���������� �� ���", "���" };
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
                    //������
                    pictureBoxLocation.Image = Properties.Resources.prison_cell;

                    break;
                case 1:
                    //�������
                    pictureBoxLocation.Image = Properties.Resources.dining_room;
                    break;
                case 2:
                    //����������
                    pictureBoxLocation.Image = Properties.Resources.prison_cell;
                    break;
                case 3:
                    //������
                    pictureBoxLocation.Image = Properties.Resources.work;
                    break;
                case 4:
                    //����
                    pictureBoxLocation.Image = Properties.Resources.dining_room;
                    break;
                case 5:
                    //C�������� �����
                    pictureBoxLocation.Image = Properties.Resources.street;
                    break;
                case 6:
                    //����
                    pictureBoxLocation.Image = Properties.Resources.dining_room;
                    break;
                case 7:
                    //���������� �� ���
                    pictureBoxLocation.Image = Properties.Resources.prison_cell;
                    break;
                case 8:
                    //���
                    pictureBoxLocation.Image = Properties.Resources.prison_cell;
                    break;
            }


        }
        public void Test()
        {
            int testPoints = 0;

            DialogResult dr = MessageBox.Show("���� � ������� ����� 3-� ���?", "������ ������", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                testPoints += 2;
            }
            else
            {
                testPoints += 1;
            }

            dr = MessageBox.Show("�������� �����������?", "������ ������", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                testPoints += 2;
            }
            else
            {
                testPoints += 1;
            }

            dr = MessageBox.Show("����� ��� �������", "������ ������?", MessageBoxButtons.YesNo);

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
                MessageBox.Show("�� ��� �� �������, ��� Lua");
                pictureBox2.Image = Properties.Resources.assembler;
            }
            else if (testPoints >= 4 && testPoints < 6)
            {
                MessageBox.Show("��� �� � ������� ��������!");
                pictureBox2.Image = Properties.Resources.python;
            }
            else if (testPoints == 3)
            {
                MessageBox.Show("�����, ����� ���� � ������� ������, ����������!");
                pictureBox2.Image = Properties.Resources.Pascal;
            }
        }
    }
}