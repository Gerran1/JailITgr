namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        static Classes.Pascal pascal = new Classes.Pascal();
        static Classes.Python python = new Classes.Python();
        static Classes.Lua lua = new Classes.Lua();
        static Classes.IPrisoner pascalAdapter = new Classes.PascalAdapter(pascal);
        static Classes.IPrisoner pythonAdapter = new Classes.PythonAdapter(python);
        static Classes.IPrisoner luaAdapter = new Classes.LuaAdapter(lua);
        Classes.Player player;
        Questes questes = new Questes();
        static int Money = 0;

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
                pictureBox2.Image = Properties.Resources.Lua;
                player = new Classes.Player(luaAdapter.Health, luaAdapter.Damage, luaAdapter.Agility, luaAdapter.Intelligence, luaAdapter.Salary, luaAdapter.RankName, Money);

                MessageBox.Show($"�� �������� ����: {player.RankName}");
                
            }
            else if (testPoints >= 4 && testPoints < 6)
            {
                MessageBox.Show("��� �� � ������� ��������!");
                pictureBox2.Image = Properties.Resources.python;
                player = new Classes.Player(pythonAdapter.Health, pythonAdapter.Damage, pythonAdapter.Agility, pythonAdapter.Intelligence, pythonAdapter.Salary, pythonAdapter.RankName, Money);

                MessageBox.Show($"�� �������� ����: {player.RankName}");
                
            }
            else if (testPoints == 3)
            {
                MessageBox.Show("�����, ����� ���� � ������� ������, ����������!");
                
                player = new Classes.Player(pascalAdapter.Health, pascalAdapter.Damage, pascalAdapter.Agility, pascalAdapter.Intelligence, pascalAdapter.Salary, pascalAdapter.RankName, Money);
                MessageBox.Show($"�� �������� ����: {player.RankName}");
                pictureBox2.Image = Properties.Resources.Pascal;
                 
                
            }
            questes.FirstQuest();
        }

           

    }
}