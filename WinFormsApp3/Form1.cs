using System;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Random random2 = new Random();

        static Classes.Pascal pascal = new Classes.Pascal();
        static Classes.Python python = new Classes.Python();
        static Classes.Lua lua = new Classes.Lua();
        static Classes.IPrisoner pascalAdapter = new Classes.PascalAdapter(pascal);
        static Classes.IPrisoner pythonAdapter = new Classes.PythonAdapter(python);
        static Classes.IPrisoner luaAdapter = new Classes.LuaAdapter(lua);
        Classes.Player player;
        Questes questes = new Questes();


        static int Money = 0;
        int Days = 0;
        int i = 0;
        int SneakAttackChance;
        
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

                    SneakAttackChance = random2.Next(1, 100);
                    pictureBoxLocation.Image = Properties.Resources.prison_cell;
                    Days += 1;

                    if (SneakAttackChance <= 35)
                    {
                        SneakAttackToYou();
                    }
                    else
                    {
                        MessageBox.Show("�� ������ ��� ������������");
                    }

                    break;
                case 1:
                    //�������

                    pictureBoxLocation.Image = Properties.Resources.dining_room;
                    break;
                case 2:
                    //����������

                    pictureBoxLocation.Image = Properties.Resources.prison_cell;
                    MessageBox.Show($"���� � ������: {Days}\n ������: {player.Money}\n �����: {player.RankName} \n ��������: {player.Health} \n ����: {player.Damage} \n ��������: {player.Agility} \n ���������: {player.Intelligence} \n ��������: {player.Salary} ���.\n" ,"����������",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 3:
                    //������

                    pictureBoxLocation.Image = Properties.Resources.work;
                    MessageBox.Show($"�� ���������� �� ������: {player.Salary} ������");
                    player.Money += player.Salary;

                    if (SneakAttackChance <= 35)
                    {
                        SneakAttackToYou();
                    }
                    else
                    {
                        MessageBox.Show("������ ������ ��� ������������");
                    }

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

                    if (SneakAttackChance <= 35)
                    {
                        SneakAttackToYou();
                    }
                    else
                    {
                        MessageBox.Show("��� ������ ��� ������������");
                    }

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

                MessageBox.Show($"�� �������� �����: {player.RankName}");
                
            }
            else if (testPoints >= 4 && testPoints < 6)
            {
                MessageBox.Show("��� �� � ������� ��������!");
                pictureBox2.Image = Properties.Resources.python;
                player = new Classes.Player(pythonAdapter.Health, pythonAdapter.Damage, pythonAdapter.Agility, pythonAdapter.Intelligence, pythonAdapter.Salary, pythonAdapter.RankName, Money);

                MessageBox.Show($"�� �������� �����: {player.RankName}");
                
            }
            else if (testPoints == 3)
            {
                MessageBox.Show("�����, ����� ���� � ������� ������, ����������!");
                
                player = new Classes.Player(pascalAdapter.Health, pascalAdapter.Damage, pascalAdapter.Agility, pascalAdapter.Intelligence, pascalAdapter.Salary, pascalAdapter.RankName, Money);
                MessageBox.Show($"�� �������� �����: {player.RankName}");
                pictureBox2.Image = Properties.Resources.Pascal;
                 
                
            }
            questes.FirstQuest();
        }

        public void SneakAttackToYou()
        {
            int randomSA = random.Next(1, 100);
            if (player.RankName == "�������")
            {
                if (randomSA <= 100 && randomSA >= 75 && player.Health > 0)
                {
                    MessageBox.Show("������� ������� ���, �� ��������� ������� �� ������ � �������� ������� ��������");
                    player.Health -= 1;
                }
                else if (randomSA <= 75 && randomSA >= 50 && player.Agility > 0)
                {
                    MessageBox.Show("������� ����� ������������ ��� ����, ����� �� ���� � ��������. �� ������ �������, �� ������� ��� �����, ��� ���� �������� ������� ���������");
                    player.Agility -= 1;
                }
                else if (randomSA <= 50 && randomSA >= 25 && player.Damage > 0)
                {
                    MessageBox.Show("�������� �������� ��� ���� ������ ���, � ������ ��������, �� �� �������� ������� �����");
                    player.Damage -= 1;
                }
                else if (randomSA <= 25 && randomSA >= 0 && player.Intelligence > 0)
                {
                    MessageBox.Show("��������� ����� �������� ��� �� ���, �� ������� ����� � ��� � �������� ������� ����������");
                    player.Intelligence -= 1;
                }
            }

            if (player.RankName == "��������")
            {
                if (randomSA <= 100 && randomSA >= 75 && player.Health > 0)
                {
                    MessageBox.Show("������� ������� ���, �� ��������� ������� �� ��� � �������� ����� ��������");
                    player.Health -= 3;
                }
                else if (randomSA <= 75 && randomSA >= 50 && player.Agility > 0)
                {
                    MessageBox.Show("������� ����� ������������ ��� ����, ����� �� ���� � ��������. �� ������ �������, �� ������� ��� �����, ��� ���� �������� ���������");
                    player.Agility -= 2;
                }
                else if (randomSA <= 50 && randomSA >= 25 && player.Damage > 0)
                {
                    MessageBox.Show("�� ������, ��� �� �� ������ �������� ���������� ���, �� ������� �������, ������� �� ��������� � ������� �� ���� ����. ��� ���� ��������");
                    player.Damage -= 2;
                }
                else if (randomSA <= 25 && randomSA >= 0 && player.Intelligence > 0)
                {
                    MessageBox.Show("��������� ����� �������� ��� �� ���� ����, �� ����� � ��� � �������� ���������");
                    player.Intelligence -= 2;
                }
            }

            if (player.RankName == "�������")
            {
                if (randomSA <= 100 && randomSA >= 75 && player.Health > 0)
                {
                    MessageBox.Show("��������� ������� ���, �� ��������� ������� �� ������ � �������� �������� ����� ��������");
                    player.Health -= 2;
                }
                else if (randomSA <= 75 && randomSA >= 50 && player.Agility > 0)
                {
                    MessageBox.Show("������� ����� ������������ ��� ����, ����� �� ���� � ��������. �� ������ �������, �� ������� ��� �����, ��� ���� �������� ���������");
                    player.Agility -= 2;
                }
                else if (randomSA <= 50 && randomSA >= 25 && player.Damage > 0)
                {
                    MessageBox.Show("��������� �������� ��� ���� ������ ���, � ������ ��������, �� �� �������� �������� ����� �����");
                    player.Damage -= 2;
                }
                else if (randomSA <= 25 && randomSA >= 0 && player.Intelligence > 0)
                {
                    MessageBox.Show("������� ����� �������� ��� �� ���������, �� ����� � ��� � �������� ���������");
                    player.Intelligence -= 2;
                }
            }

            if (player.RankName == "���������")
            {
                if (randomSA <= 100 && randomSA >= 75 && player.Health > 0)
                {
                    MessageBox.Show("��������� ������� ���, �� ��������� ������� �� ������ � �������� �������� ����� ��������");
                    player.Health -= 3;
                }
                else if (randomSA <= 75 && randomSA >= 50 && player.Agility > 0)
                {
                    MessageBox.Show("������� ����� ������������ ��� ����, ����� �� ���� � ��������. �� ������ �������, �� ������� ��� �����, ��� ���� �������� ���������");
                    player.Agility -= 2;
                }
                else if (randomSA <= 50 && randomSA >= 25 && player.Damage > 0)
                {
                    MessageBox.Show("������� �������� ��� ���� ������ ���, � ������ ��������, �� �� �������� �������� ����� �����");
                    player.Damage -= 2;
                }               
            }

            if (player.RankName == "�������")
            {
                if (randomSA <= 100 && randomSA >= 75 && player.Health > 0)
                {
                    MessageBox.Show("��������� ������� ���, �� ��������� ������� �� ������ � �������� �������� ����� ��������");
                    player.Health -= 3;
                }
                else if (randomSA <= 50 && randomSA >= 25 && player.Damage > 0)
                {
                    MessageBox.Show("��������� ����� ������������ ��� ����, ����� �� ���� � ��������. �� ������ �������, �� ������� ��� �����, ��� ���� �������� ���������");
                    player.Damage -= 2;
                }
                else if (randomSA <= 25 && randomSA >= 0 && player.Intelligence > 0)
                {
                    MessageBox.Show("��������� ����� �������� ��� �� ���� ����, �� ����� � ��� � �������� ���������");
                    player.Intelligence -= 3;
                }
            }
        }

    }
}