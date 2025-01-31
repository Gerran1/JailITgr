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

                    SneakAttackChance = random2.Next(1, 100);
                    pictureBoxLocation.Image = Properties.Resources.prison_cell;
                    Days += 1;

                    if (SneakAttackChance <= 35)
                    {
                        SneakAttackToYou();
                    }
                    else
                    {
                        MessageBox.Show("Всё прошло без происшествий");
                    }

                    break;
                case 1:
                    //Завтрак

                    pictureBoxLocation.Image = Properties.Resources.dining_room;
                    break;
                case 2:
                    //Перекличка

                    pictureBoxLocation.Image = Properties.Resources.prison_cell;
                    MessageBox.Show($"Дней в тюрьме: {Days}\n Деньги: {player.Money}\n Масть: {player.RankName} \n Здоровье: {player.Health} \n Урон: {player.Damage} \n Ловкость: {player.Agility} \n Интеллект: {player.Intelligence} \n Зарплата: {player.Salary} руб.\n" ,"Статистика",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 3:
                    //Работа

                    pictureBoxLocation.Image = Properties.Resources.work;
                    MessageBox.Show($"Вы заработали на работе: {player.Salary} рублей");
                    player.Money += player.Salary;

                    if (SneakAttackChance <= 35)
                    {
                        SneakAttackToYou();
                    }
                    else
                    {
                        MessageBox.Show("Работа прошла без происшествий");
                    }

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

                    if (SneakAttackChance <= 35)
                    {
                        SneakAttackToYou();
                    }
                    else
                    {
                        MessageBox.Show("Сон прошёл без происшествий");
                    }

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
                pictureBox2.Image = Properties.Resources.Lua;
                player = new Classes.Player(luaAdapter.Health, luaAdapter.Damage, luaAdapter.Agility, luaAdapter.Intelligence, luaAdapter.Salary, luaAdapter.RankName, Money);

                MessageBox.Show($"Вы получили масть: {player.RankName}");
                
            }
            else if (testPoints >= 4 && testPoints < 6)
            {
                MessageBox.Show("Вот ты и попался питонист!");
                pictureBox2.Image = Properties.Resources.python;
                player = new Classes.Player(pythonAdapter.Health, pythonAdapter.Damage, pythonAdapter.Agility, pythonAdapter.Intelligence, pythonAdapter.Salary, pythonAdapter.RankName, Money);

                MessageBox.Show($"Вы получили масть: {player.RankName}");
                
            }
            else if (testPoints == 3)
            {
                MessageBox.Show("Ооооо, плюсы тебя с костями съедят, паскальный!");
                
                player = new Classes.Player(pascalAdapter.Health, pascalAdapter.Damage, pascalAdapter.Agility, pascalAdapter.Intelligence, pascalAdapter.Salary, pascalAdapter.RankName, Money);
                MessageBox.Show($"Вы получили масть: {player.RankName}");
                pictureBox2.Image = Properties.Resources.Pascal;
                 
                
            }
            questes.FirstQuest();
        }

        public void SneakAttackToYou()
        {
            int randomSA = random.Next(1, 100);
            if (player.RankName == "Паскаль")
            {
                if (randomSA <= 100 && randomSA >= 75 && player.Health > 0)
                {
                    MessageBox.Show("Луанист толкнул вас, вы ударились головой об стенку и потеряли немного здоровья");
                    player.Health -= 1;
                }
                else if (randomSA <= 75 && randomSA >= 50 && player.Agility > 0)
                {
                    MessageBox.Show("Плюсист решил поиздеваться над вами, бегая за вами с заточкой. Вы смогли убежать, но удерали так долго, что ваша ловкость немного снизилась");
                    player.Agility -= 1;
                }
                else if (randomSA <= 50 && randomSA >= 25 && player.Damage > 0)
                {
                    MessageBox.Show("Питонист вывернул вам руку просто так, её быстро вправили, но вы потеряли немного урона");
                    player.Damage -= 1;
                }
                else if (randomSA <= 25 && randomSA >= 0 && player.Intelligence > 0)
                {
                    MessageBox.Show("Сишарпист начал пояснять вам за ООП, вы немного сошли с ума и потеряли немного интеллекта");
                    player.Intelligence -= 1;
                }
            }

            if (player.RankName == "Питонист")
            {
                if (randomSA <= 100 && randomSA >= 75 && player.Health > 0)
                {
                    MessageBox.Show("Луанист толкнул вас, вы ударились головой об пол и потеряли много здоровья");
                    player.Health -= 3;
                }
                else if (randomSA <= 75 && randomSA >= 50 && player.Agility > 0)
                {
                    MessageBox.Show("Плюсист решил поиздеваться над вами, бегая за вами с заточкой. Вы смогли убежать, но удерали так долго, что ваша ловкость снизилась");
                    player.Agility -= 2;
                }
                else if (randomSA <= 50 && randomSA >= 25 && player.Damage > 0)
                {
                    MessageBox.Show("От злости, что вы не смогли написать нормальный код, вы ударили ноутбук, ноутбук не пострадал в отличии от ваше руки. Ваш урон снизился");
                    player.Damage -= 2;
                }
                else if (randomSA <= 25 && randomSA >= 0 && player.Intelligence > 0)
                {
                    MessageBox.Show("Ассемблер начал пояснять вам за свой язык, вы сошли с ума и потеряли интеллект");
                    player.Intelligence -= 2;
                }
            }

            if (player.RankName == "Луанист")
            {
                if (randomSA <= 100 && randomSA >= 75 && player.Health > 0)
                {
                    MessageBox.Show("Сишарпист толкнул вас, вы ударились головой об стенку и потеряли несильно много здоровья");
                    player.Health -= 2;
                }
                else if (randomSA <= 75 && randomSA >= 50 && player.Agility > 0)
                {
                    MessageBox.Show("Плюсист решил поиздеваться над вами, бегая за вами с заточкой. Вы смогли убежать, но удерали так долго, что ваша ловкость снизилась");
                    player.Agility -= 2;
                }
                else if (randomSA <= 50 && randomSA >= 25 && player.Damage > 0)
                {
                    MessageBox.Show("Сишарпист вывернул вам руку просто так, её быстро вправили, но вы потеряли несильно много урона");
                    player.Damage -= 2;
                }
                else if (randomSA <= 25 && randomSA >= 0 && player.Intelligence > 0)
                {
                    MessageBox.Show("Плюсист начал пояснять вам за указатели, вы сошли с ума и потеряли интеллект");
                    player.Intelligence -= 2;
                }
            }

            if (player.RankName == "Сишарпист")
            {
                if (randomSA <= 100 && randomSA >= 75 && player.Health > 0)
                {
                    MessageBox.Show("Ассемблер толкнул вас, вы ударились головой об стенку и потеряли несильно много здоровья");
                    player.Health -= 3;
                }
                else if (randomSA <= 75 && randomSA >= 50 && player.Agility > 0)
                {
                    MessageBox.Show("Плюсист решил поиздеваться над вами, бегая за вами с заточкой. Вы смогли убежать, но удерали так долго, что ваша ловкость снизилась");
                    player.Agility -= 2;
                }
                else if (randomSA <= 50 && randomSA >= 25 && player.Damage > 0)
                {
                    MessageBox.Show("Плюсист вывернул вам руку просто так, её быстро вправили, но вы потеряли несильно много урона");
                    player.Damage -= 2;
                }               
            }

            if (player.RankName == "Плюсист")
            {
                if (randomSA <= 100 && randomSA >= 75 && player.Health > 0)
                {
                    MessageBox.Show("Ассемблер толкнул вас, вы ударились головой об стенку и потеряли несильно много здоровья");
                    player.Health -= 3;
                }
                else if (randomSA <= 50 && randomSA >= 25 && player.Damage > 0)
                {
                    MessageBox.Show("Ассемблер решил поиздеваться над вами, бегая за вами с заточкой. Вы смогли убежать, но удерали так долго, что ваша ловкость снизилась");
                    player.Damage -= 2;
                }
                else if (randomSA <= 25 && randomSA >= 0 && player.Intelligence > 0)
                {
                    MessageBox.Show("Ассемблер начал пояснять вам за свой язык, вы сошли с ума и потеряли интеллект");
                    player.Intelligence -= 3;
                }
            }
        }

    }
}