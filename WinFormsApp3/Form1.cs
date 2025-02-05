using System;
using System.Collections.Generic;
using static WinFormsApp3.Classes;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Random random2 = new Random();
        Random Theifrandom = new Random();

        static Classes.Pascal pascal = new Classes.Pascal();
        static Classes.Python python = new Classes.Python();
        static Classes.Lua lua = new Classes.Lua();
        static Classes.CSharp cSharp = new Classes.CSharp();
        static Classes.Cpp cpp = new Classes.Cpp();
        static Classes.Assembly assembly = new Classes.Assembly();
        static Classes.IPrisoner pascalAdapter = new Classes.PascalAdapter(pascal);
        static Classes.IPrisoner pythonAdapter = new Classes.PythonAdapter(python);
        static Classes.IPrisoner luaAdapter = new Classes.LuaAdapter(lua);
        static Classes.IPrisoner csharpAdapter = new Classes.CSharpAdapter(cSharp);
        static Classes.IPrisoner cppAdapter = new Classes.CppAdapter(cpp);
        static Classes.IPrisoner assemblyAdapter = new Classes.AssemblyAdapter(assembly);
        public WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
        Classes.Player player;

        Questes questes = new Questes();

        static int Money = 0;
        int Days = 0;
        int i = 0;
        int SneakAttackChance;
        int RankPoints = 0;
        int ComissionPercent = 0;
        bool IsArested = false;
        bool IsOpened = false;
        bool IsShopbtnOpened = false;

        List<string> TimeTables = new List<string>() { "Подъём", "Завтрак", "Перекличка", "Работа", "Обед", "Cвободное Время", "Ужин", "Подготовка ко сну", "Сон" };      

        Dictionary<int, string> Books = new Dictionary<int, string>()
        {
            [550] = "Питон Том I",
            [700] = "Питон Том II",
            [890] = "Луа: Исповедь Roblox",
            [1000] = "Основы OOП",
            [1250] = "С#: Экспресс-курс",
            [1400] = "Базы данных для детей",
            [1600] = "С++: Основы",
            [1800] = "С++: Работа с памятью",
            [2000] = "С++: Указатели",
            [2200] = "С++: Работа с памятью II",
            [2800] = "Исскусство программирование на Assembler Том I",
            [3500] = "Исскусство программирование на Assembler Том II",
            [4000] = "Исскусство программирование на Assembler Том III"
        };

        Dictionary<int, string> TradeInventory = new Dictionary<int, string>() { };

        List<string> BoxInventory = new List<string>() { };



        public Form1()
        {
            InitializeComponent();
            pictureBoxLocation.Image = Properties.Resources.prison_cell;
            WMP.URL = @"C:\Users\мк\Source\Repos\JailITgr5.02\WinFormsApp3\Resources\Mikhail_Krug.wav";
            WMP.settings.volume = 10;
            WMP.settings.playCount = 9999;
            WMP.controls.play();


            Test();
            TimeTableLabel.Text = TimeTables[0];
            buttonLibrary.Enabled = false;
            buttonLibrary.Visible = false;

            buttonTheif.Enabled = false;
            buttonTheif.Visible = false;

            listBoxBooks.Enabled = true;
            listBoxBooks.Visible = false;
            listBoxTradeInventory.Enabled = true;
            listBoxTradeInventory.Visible = false;
            listBoxInventoryBox.Enabled = true;
            listBoxInventoryBox.Visible = false;


            buttonBuy.Enabled = false;
            buttonBuy.Visible = false;

            buttonTrade.Enabled = false;
            buttonTrade.Visible = false;

            buttonGym.Enabled = false;
            buttonGym.Visible = false;

            buttonStreet.Enabled = false;
            buttonStreet.Visible = false;

            buttonOpenBox.Enabled = false;
            buttonOpenBox.Visible = false;

            buttonPutItem.Visible = false;
            buttonPutItem.Enabled = false;

            
            foreach (var book in Books)
            {
                string item = $"{book.Value}" + $" за {book.Key} руб.";
                listBoxBooks.Items.Add(item);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
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
                    listBoxBooks.Visible = false;
                    listBoxTradeInventory.Visible = false;
                    listBoxInventoryBox.Visible = false;

                    buttonTheif.Enabled = false;
                    buttonTheif.Visible = false;
                    buttonLibrary.Enabled = false;
                    buttonLibrary.Visible = false;

                    buttonBuy.Enabled = false;
                    buttonBuy.Visible = false;
                    buttonTrade.Enabled = false;
                    buttonTrade.Visible = false;
                    buttonGym.Enabled = false;
                    buttonGym.Visible = false;
                    buttonStreet.Enabled = false;
                    buttonStreet.Visible = false;
                    buttonPutItem.Visible = false;
                    buttonPutItem.Enabled = false;

                    buttonOpenBox.Enabled = true;
                    buttonOpenBox.Visible = true;

                    IsArested = false;


                    if (player.RankName == "Ассемблер")
                    {
                        MessageBox.Show($"Вы заработали с комиссии на продаже 200 рублей", "Пассивный заработок", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        player.Money += 200;
                        DialogResult dr = MessageBox.Show("Вы желаете стать вором в законе?(конец игры)", "\"Конец?\"", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dr == DialogResult.Yes)
                        {
                            MessageBox.Show("Вы смогли стать вором в законе, выйдя из тюрьми \"ITgr\" по блату.", "\"Конец.\"", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                    }
                    else if (player.RankName == "Плюсист")
                    {
                        MessageBox.Show($"Вы заработали с комиссии на продаже 100 рублей", "Пассивный заработок", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        player.Money += 100;
                    }

                    SneakAttackChance = random2.Next(1, 100);
                    pictureBoxLocation.Image = Properties.Resources.prison_cell;
                    Days += 1;

                    switch (RankPoints)
                    {
                        case 2:
                            //питонист
                            player = new Classes.Player(pythonAdapter.Health, pythonAdapter.Damage, pythonAdapter.Agility, pythonAdapter.Intelligence, pythonAdapter.Salary, pythonAdapter.RankName, player.Money);
                            pictureBox2.Image = Properties.Resources.python;
                            break;
                        case 3:
                            //lua
                            player = new Classes.Player(luaAdapter.Health, luaAdapter.Damage, luaAdapter.Agility, luaAdapter.Intelligence, luaAdapter.Salary, luaAdapter.RankName, player.Money);
                            pictureBox2.Image = Properties.Resources.Lua;
                            break;
                        case 6:
                            //cs
                            player = new Classes.Player(csharpAdapter.Health, csharpAdapter.Damage, csharpAdapter.Agility, csharpAdapter.Intelligence, csharpAdapter.Salary, csharpAdapter.RankName, player.Money);
                            pictureBox2.Image = Properties.Resources.C_;
                            break;
                        case 10:
                            //cpp
                            player = new Classes.Player(cppAdapter.Health, cppAdapter.Damage, cppAdapter.Agility, cppAdapter.Intelligence, cppAdapter.Salary, cppAdapter.RankName, player.Money);
                            pictureBox2.Image = Properties.Resources.C__;
                            break;
                        case 13:
                            //ass
                            player = new Classes.Player(assemblyAdapter.Health, assemblyAdapter.Damage, assemblyAdapter.Agility, assemblyAdapter.Intelligence, assemblyAdapter.Salary, assemblyAdapter.RankName, player.Money);
                            pictureBox2.Image = Properties.Resources.assembler;
                            break;
                    }
                    IsDeath();
                    break;
                case 1:
                    //Завтрак
                    buttonTheif.Enabled = false;
                    buttonTheif.Visible = false;
                    buttonLibrary.Enabled = false;
                    buttonLibrary.Visible = false;
                    listBoxBooks.Visible = false;
                    listBoxTradeInventory.Visible = false;
                    listBoxInventoryBox.Visible = false;
                    buttonBuy.Enabled = false;
                    buttonBuy.Visible = false;
                    buttonTrade.Enabled = false;
                    buttonTrade.Visible = false;
                    buttonGym.Enabled = false;
                    buttonGym.Visible = false;
                    buttonStreet.Enabled = false;
                    buttonStreet.Visible = false;
                    buttonOpenBox.Enabled = false;
                    buttonOpenBox.Visible = false;
                    buttonPutItem.Visible = false;
                    buttonPutItem.Enabled = false;


                    pictureBoxLocation.Image = Properties.Resources.dining_room;
                    //AsyncRegeniration();

                    IsDeath();
                    break;
                case 2:
                    //Перекличка
                    buttonTheif.Enabled = false;
                    buttonTheif.Visible = false;
                    buttonLibrary.Enabled = false;
                    buttonLibrary.Visible = false;
                    listBoxBooks.Visible = false;
                    listBoxTradeInventory.Visible = false;
                    listBoxInventoryBox.Visible = false;
                    buttonBuy.Enabled = false;
                    buttonBuy.Visible = false;
                    buttonTrade.Enabled = false;
                    buttonTrade.Visible = false;
                    buttonGym.Enabled = false;
                    buttonGym.Visible = false;
                    buttonStreet.Enabled = false;
                    buttonStreet.Visible = false;
                    buttonPutItem.Visible = false;
                    buttonPutItem.Enabled = false;

                    buttonOpenBox.Enabled = true;
                    buttonOpenBox.Visible = true;


                    pictureBoxLocation.Image = Properties.Resources.prison_cell;
                    Shmon();
                    MessageBox.Show($"Дней в тюрьме: {Days}\n Деньги: {player.Money}\n Масть: {player.RankName} \n Здоровье: {player.Health} \n Урон: {player.Damage} \n Ловкость: {player.Agility} \n Интеллект: {player.Intelligence} \n Зарплата: {player.Salary} руб.\n", "Статистика", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IsDeath();
                    break;
                case 3:
                    //Работа
                    if (player.RankName == "Сишарпист" || player.RankName == "Плюсист" && IsArested == false)
                    {
                        buttonTheif.Enabled = true;
                        buttonTheif.Visible = true;

                    }
                    else if (IsArested == true)
                    {
                        buttonTheif.Enabled = false;
                    }
                    else
                    {
                        buttonTheif.Enabled = false;
                        buttonTheif.Visible = false;

                    }
                    buttonLibrary.Enabled = false;
                    buttonLibrary.Visible = false;
                    listBoxBooks.Visible = false;
                    listBoxTradeInventory.Visible = false;
                    listBoxInventoryBox.Visible = false;
                    buttonBuy.Enabled = false;
                    buttonBuy.Visible = false;
                    buttonTrade.Enabled = false;
                    buttonTrade.Visible = false;
                    buttonGym.Enabled = false;
                    buttonGym.Visible = false;
                    buttonStreet.Enabled = false;
                    buttonStreet.Visible = false;
                    buttonOpenBox.Enabled = false;
                    buttonOpenBox.Visible = false;
                    buttonPutItem.Visible = false;
                    buttonPutItem.Enabled = false;




                    pictureBoxLocation.Image = Properties.Resources.work;



                    MessageBox.Show($"Вы заработали на работе: {player.Salary} рублей", "Работа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    player.Money += player.Salary;

                    if (SneakAttackChance <= 35)
                    {
                        AsyncSneakAttackToYou();
                    }
                    else
                    {
                        MessageBox.Show("Работа прошла без происшествий");
                    }
                    IsDeath();
                    break;
                case 4:
                    //Обед
                    buttonTheif.Enabled = false;
                    buttonTheif.Visible = false;
                    buttonLibrary.Enabled = false;
                    buttonLibrary.Visible = false;
                    listBoxBooks.Visible = false;
                    listBoxTradeInventory.Visible = false;
                    listBoxInventoryBox.Visible = false;
                    buttonBuy.Enabled = false;
                    buttonBuy.Visible = false;
                    buttonTrade.Enabled = false;
                    buttonTrade.Visible = false;
                    buttonGym.Enabled = false;
                    buttonGym.Visible = false;
                    buttonStreet.Enabled = false;
                    buttonStreet.Visible = false;
                    buttonOpenBox.Enabled = false;
                    buttonOpenBox.Visible = false;
                    buttonPutItem.Visible = false;
                    buttonPutItem.Enabled = false;


                    pictureBoxLocation.Image = Properties.Resources.dining_room;
                    AsyncRegeniration();
                    IsDeath();
                    break;
                case 5:
                    //Cвободное Время
                    buttonTheif.Enabled = false;
                    buttonTheif.Visible = false;
                    buttonBuy.Enabled = false;
                    buttonBuy.Visible = false;
                    listBoxBooks.Visible = false;
                    listBoxBooks.Enabled = true;
                    listBoxInventoryBox.Visible = false;

                    if (player.RankName == "Сишарпист" || player.RankName == "Плюсист")
                    {
                        buttonTrade.Enabled = true;
                        buttonTrade.Visible = true;
                        listBoxTradeInventory.Visible = true;
                    }
                    pictureBoxLocation.Image = Properties.Resources.street;
                    buttonLibrary.Enabled = true;
                    buttonLibrary.Visible = true;
                    buttonGym.Enabled = true;
                    buttonGym.Visible = true;
                    buttonStreet.Enabled = true;
                    buttonStreet.Visible = true;
                    buttonOpenBox.Enabled = false;
                    buttonOpenBox.Visible = false;
                    buttonPutItem.Visible = false;
                    buttonPutItem.Enabled = false;

                    IsDeath();
                    break;
                case 6:
                    //Ужин
                    buttonTheif.Enabled = false;
                    buttonTheif.Visible = false;
                    buttonLibrary.Enabled = false;
                    buttonLibrary.Visible = false;
                    buttonBuy.Enabled = false;
                    buttonBuy.Visible = false;
                    listBoxBooks.Visible = false;
                    listBoxTradeInventory.Visible = false;
                    listBoxInventoryBox.Visible = false;
                    buttonTrade.Enabled = false;
                    buttonTrade.Visible = false;
                    buttonGym.Enabled = false;
                    buttonGym.Visible = false;
                    buttonStreet.Enabled = false;
                    buttonStreet.Visible = false;
                    buttonOpenBox.Enabled = false;
                    buttonOpenBox.Visible = false;
                    buttonPutItem.Visible = false;
                    buttonPutItem.Enabled = false;

                    pictureBoxLocation.Image = Properties.Resources.dining_room;
                    //AsyncRegeniration();
                    IsDeath();
                    break;
                case 7:
                    //Подготовка ко сну
                    buttonTheif.Enabled = false;
                    buttonTheif.Visible = false;
                    buttonLibrary.Enabled = false;
                    buttonLibrary.Visible = false;
                    buttonBuy.Enabled = false;
                    buttonBuy.Visible = false;
                    listBoxBooks.Visible = false;
                    listBoxTradeInventory.Visible = false;
                    listBoxInventoryBox.Visible = false;
                    buttonTrade.Enabled = false;
                    buttonTrade.Visible = false;
                    buttonGym.Enabled = false;
                    buttonGym.Visible = false;
                    buttonStreet.Enabled = false;
                    buttonStreet.Visible = false;
                    buttonPutItem.Visible = false;
                    buttonPutItem.Enabled = false;


                    pictureBoxLocation.Image = Properties.Resources.shower;
                    int badthingsRandom = random.Next(1, 100);

                    if (badthingsRandom >= 0 && badthingsRandom < 20)
                    {
                        MessageBox.Show("Во время душа вы случайно уранили лямбда мыло, вы нагнулись за ним. Дальше кто-то подошал к вам сзади...", "\"Неприятности\"", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (player.Agility >= 5 && player.Damage >= 4)
                        {
                            MessageBox.Show("но вы смогли резка дать отпор паскальщику.", "\"Неприятности\"", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("и вы не успели среагировать и произошло кое что ужасное. Ваша репутация подкасилась.", "\"Неприятности\"", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Вы спокойно помылись.", "\"Неприятности\"", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IsDeath();
                    break;
                case 8:
                    //Сон
                    buttonTheif.Enabled = false;
                    buttonTheif.Visible = false;
                    buttonLibrary.Enabled = false;
                    buttonLibrary.Visible = false;
                    buttonBuy.Enabled = false;
                    buttonBuy.Visible = false;
                    listBoxBooks.Visible = false;
                    listBoxTradeInventory.Visible = false;
                    listBoxInventoryBox.Visible = false;
                    buttonTrade.Enabled = false;
                    buttonTrade.Visible = false;
                    buttonGym.Enabled = false;
                    buttonGym.Visible = false;
                    buttonStreet.Enabled = false;
                    buttonStreet.Visible = false;
                    buttonPutItem.Visible = false;
                    buttonPutItem.Enabled = false;

                    buttonOpenBox.Enabled = true;
                    buttonOpenBox.Visible = true;

                    if (SneakAttackChance <= 35)
                    {
                        AsyncSneakAttackToYou();
                    }
                    else
                    {
                        MessageBox.Show("Сон прошёл без происшествий");
                    }
                    pictureBoxLocation.Image = Properties.Resources.prison_cell;
                    IsDeath();
                    break;

            }
        }
        void Test()
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

            dr = MessageBox.Show("Чужой код воровал?", "Третий вопрос", MessageBoxButtons.YesNo);

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
                RankPoints = 3;
                MessageBox.Show($"Вы получили масть: {player.RankName}");


            }
            else if (testPoints >= 4 && testPoints < 6)
            {
                //временно сишарпист
                MessageBox.Show("Вот ты и попался питонист!(временно сишарпист)");
                pictureBox2.Image = Properties.Resources.python;
                player = new Classes.Player(csharpAdapter.Health, csharpAdapter.Damage, csharpAdapter.Agility, csharpAdapter.Intelligence, csharpAdapter.Salary, csharpAdapter.RankName, Money);
                RankPoints = 6;
                MessageBox.Show($"Вы получили масть: {player.RankName}");

            }
            else if (testPoints == 3)
            {
                MessageBox.Show("Ооооо, плюсы тебя с костями съедят, паскальный!");

                player = new Classes.Player(pascalAdapter.Health, pascalAdapter.Damage, pascalAdapter.Agility, pascalAdapter.Intelligence, pascalAdapter.Salary, pascalAdapter.RankName, Money);
                RankPoints = 1;
                MessageBox.Show($"Вы получили масть: {player.RankName}");
                pictureBox2.Image = Properties.Resources.Pascal;


            }
            questes.FirstQuest();
        }
        void SneakAttackToYou()
        {
            int randomSA = random.Next(1, 100);
            switch (player.RankName)
            {
                case "Паскаль":
                    if (randomSA <= 100 && randomSA >= 75 && player.Health > 0)
                    {
                        MessageBox.Show("Луанист толкнул вас, вы ударились головой об стенку и потеряли немного здоровья", "Подлянка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        player.Health -= 1;
                    }
                    else if (randomSA <= 75 && randomSA >= 50 && player.Agility > 0)
                    {
                        MessageBox.Show("Плюсист решил поиздеваться над вами, бегая за вами с заточкой. Вы смогли убежать, но удерали так долго, что ваша ловкость немного снизилась", "Подлянка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        player.Agility -= 1;
                    }
                    else if (randomSA <= 50 && randomSA >= 25 && player.Damage > 0)
                    {
                        MessageBox.Show("Питонист вывернул вам руку просто так, её быстро вправили, но вы потеряли немного урона", "Подлянка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        player.Damage -= 1;
                    }
                    else if (randomSA <= 25 && randomSA >= 0 && player.Intelligence > 0)
                    {
                        MessageBox.Show("Сишарпист начал пояснять вам за ООП, вы немного сошли с ума и потеряли немного интеллекта", "Подлянка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        player.Intelligence -= 1;
                    }
                    IsDeath();
                    break;

                case "Питонист":
                    if (randomSA <= 100 && randomSA >= 75 && player.Health > 0)
                    {
                        MessageBox.Show("Луанист толкнул вас, вы ударились головой об пол и потеряли много здоровья", "Подлянка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        player.Health -= 3;
                    }
                    else if (randomSA <= 75 && randomSA >= 50 && player.Agility > 0)
                    {
                        MessageBox.Show("Плюсист решил поиздеваться над вами, бегая за вами с заточкой. Вы смогли убежать, но удерали так долго, что ваша ловкость снизилась", "Подлянка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        player.Agility -= 2;
                    }
                    else if (randomSA <= 50 && randomSA >= 25 && player.Damage > 0)
                    {
                        MessageBox.Show("От злости, что вы не смогли написать нормальный код, вы ударили ноутбук, ноутбук не пострадал в отличии от ваше руки. Ваш урон снизился", "Подлянка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        player.Damage -= 2;
                    }
                    else if (randomSA <= 25 && randomSA >= 0 && player.Intelligence > 0)
                    {
                        MessageBox.Show("Ассемблер начал пояснять вам за свой язык, вы сошли с ума и потеряли интеллект", "Подлянка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        player.Intelligence -= 2;
                    }
                    IsDeath();
                    break;

                case "Луанист":
                    if (randomSA <= 100 && randomSA >= 75 && player.Health > 0)
                    {
                        MessageBox.Show("Сишарпист толкнул вас, вы ударились головой об стенку и потеряли несильно много здоровья", "Подлянка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        player.Health -= 2;
                    }
                    else if (randomSA <= 75 && randomSA >= 50 && player.Agility > 0)
                    {
                        MessageBox.Show("Плюсист решил поиздеваться над вами, бегая за вами с заточкой. Вы смогли убежать, но удерали так долго, что ваша ловкость снизилась", "Подлянка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        player.Agility -= 2;
                    }
                    else if (randomSA <= 50 && randomSA >= 25 && player.Damage > 0)
                    {
                        MessageBox.Show("Сишарпист вывернул вам руку просто так, её быстро вправили, но вы потеряли несильно много урона", "Подлянка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        player.Damage -= 2;
                    }
                    else if (randomSA <= 25 && randomSA >= 0 && player.Intelligence > 0)
                    {
                        MessageBox.Show("Плюсист начал пояснять вам за указатели, вы сошли с ума и потеряли интеллект", "Подлянка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        player.Intelligence -= 2;
                    }
                    IsDeath();
                    break;

                case "Сишарпист":
                    if (randomSA <= 100 && randomSA >= 75 && player.Health > 0)
                    {
                        MessageBox.Show("Ассемблер толкнул вас, вы ударились головой об стенку и потеряли несильно много здоровья", "Подлянка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        player.Health -= 3;
                    }
                    else if (randomSA <= 75 && randomSA >= 50 && player.Agility > 0)
                    {
                        MessageBox.Show("Плюсист решил поиздеваться над вами, бегая за вами с заточкой. Вы смогли убежать, но удерали так долго, что ваша ловкость снизилась", "Подлянка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        player.Agility -= 2;
                    }
                    else if (randomSA <= 50 && randomSA >= 25 && player.Damage > 0)
                    {
                        MessageBox.Show("Плюсист вывернул вам руку просто так, её быстро вправили, но вы потеряли несильно много урона", "Подлянка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        player.Damage -= 2;
                    }
                    IsDeath();
                    break;

                case "Плюсист":
                    if (randomSA <= 100 && randomSA >= 75 && player.Health > 0)
                    {
                        MessageBox.Show("Ассемблер толкнул вас, вы ударились головой об стенку и потеряли несильно много здоровья", "Подлянка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        player.Health -= 3;
                    }
                    else if (randomSA <= 50 && randomSA >= 25 && player.Damage > 0)
                    {
                        MessageBox.Show("Ассемблер решил поиздеваться над вами, бегая за вами с заточкой. Вы смогли убежать, но удерали так долго, что ваша ловкость снизилась", "Подлянка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        player.Damage -= 2;
                    }
                    else if (randomSA <= 25 && randomSA >= 0 && player.Intelligence > 0)
                    {
                        MessageBox.Show("Ассемблер начал пояснять вам за свой язык, вы сошли с ума и потеряли интеллект", "Подлянка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        player.Intelligence -= 3;
                    }
                    IsDeath();
                    break;
            }
        }
        void Regeniration()
        {
            switch (player.RankName)
            {
                case "Паскаль":
                    player.Health = 3;
                    player.Damage = 3;
                    player.Agility = 3;
                    player.Intelligence = 3;
                    break;
                case "Питонист":
                    player.Health = 8;
                    player.Damage = 2;
                    player.Agility = 7;
                    player.Intelligence = 5;
                    break;
                case "Луанист":
                    player.Health = 5;
                    player.Damage = 5;
                    player.Agility = 7;
                    player.Intelligence = 5;
                    break;
                case "Сишарпист":
                    player.Health = 7;
                    player.Damage = 6;
                    player.Agility = 5;
                    player.Intelligence = 6;
                    break;
                case "Плюсист":
                    player.Health = 7;
                    player.Damage = 6;
                    player.Agility = 6;
                    player.Intelligence = 7;
                    break;
                case "Ассемблер":
                    player.Health = 9;
                    player.Damage = 9;
                    player.Agility = 9;
                    player.Intelligence = 9;
                    break;

            }

            MessageBox.Show($"Статистика восстановлена", "Восстановление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        async Task AsyncRegeniration()
        {
            await Task.Run(Regeniration);
        }
        async Task AsyncSneakAttackToYou()
        {
            await Task.Run(SneakAttackToYou);
        }
        void Theif()
        {
            int chance = 0;
            int random = Theifrandom.Next(1, 100);
            int randomItem = Theifrandom.Next(1, 100);
            switch (player.RankName)
            {
                case "Сишарпист":
                    chance = 55;
                    break;
                case "Плюсист":
                    chance = 70;
                    break;
            }
            if (random <= chance)
            {
                if (randomItem >= 90 && randomItem <= 100)
                {
                    TradeInventory[100] = "Синтаксический сахар";
                    listBoxTradeInventory.Items.Add(TradeInventory[100]);
                    MessageBox.Show($"Вам повезло и вы смогли украсть товар: {TradeInventory[100]}", "Воровская жизнь не лёгкая", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (randomItem >= 80 && randomItem <= 90)
                {
                    TradeInventory[120] = "Пачка сигарет \"Git\"";
                    listBoxTradeInventory.Items.Add(TradeInventory[120]);
                    MessageBox.Show($"Вам повезло и вы смогли украсть товар: {TradeInventory[120]}", "Воровская жизнь не лёгкая", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (randomItem >= 70 && randomItem <= 80)
                {
                    TradeInventory[150] = "Вино на кастылях";
                    listBoxTradeInventory.Items.Add(TradeInventory[150]);
                    MessageBox.Show($"Вам повезло и вы смогли украсть товар: {TradeInventory[150]}", "Воровская жизнь не лёгкая", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (randomItem >= 60 && randomItem <= 70)
                {
                    TradeInventory[50] = "Чай \"ZAML\"";
                    listBoxTradeInventory.Items.Add(TradeInventory[50]);
                    MessageBox.Show($"Вам повезло и вы смогли украсть товар: {TradeInventory[50]}", "Воровская жизнь не лёгкая", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (randomItem >= 50 && randomItem <= 60)
                {
                    TradeInventory[50] = "Кофе \"Мьютекс\"";
                    listBoxTradeInventory.Items.Add(TradeInventory[50]);
                    MessageBox.Show($"Вам повезло и вы смогли украсть товар: {TradeInventory[50]}", "Воровская жизнь не лёгкая", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (randomItem >= 40 && randomItem <= 50)
                {
                    TradeInventory[200] = "Медикаменты \"Подсостояние суперсостояния\"";
                    listBoxTradeInventory.Items.Add(TradeInventory[200]);
                    MessageBox.Show($"Вам повезло и вы смогли украсть товар: {TradeInventory[200]}", "Воровская жизнь не лёгкая", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (randomItem >= 30 && randomItem <= 40)
                {
                    TradeInventory[300] = "Статик Вилка";
                    listBoxTradeInventory.Items.Add(TradeInventory[300]);
                    MessageBox.Show($"Вам повезло и вы смогли украсть товар: {TradeInventory[300]}", "Воровская жизнь не лёгкая", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (randomItem >= 20 && randomItem <= 30)
                {
                    TradeInventory[320] = "Лямбда мыло";
                    listBoxTradeInventory.Items.Add(TradeInventory[320]);
                    MessageBox.Show($"Вам повезло и вы смогли украсть товар: {TradeInventory[320]}", "Воровская жизнь не лёгкая", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (randomItem >= 0 && randomItem <= 20) { MessageBox.Show($"Вам не повезло и вы ничего не нашли", "Воровская жизнь не лёгкая", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }


            }
            else
            {
                MessageBox.Show("Ваc поимали на воровстве и посадили в карцер. Вы провели там неделю.", "В карцер!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                IsArested = true;
                Days += 7;
                player.Health -= 1;
                player.Agility -= 1;
                player.Damage -= 1;
                player.Intelligence -= 1;
                if (TradeInventory.Count > 0)
                {
                    MessageBox.Show("Все ваши вещи были конфискованы.", "Жадность фраера сгубила!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TradeInventory.Clear();
                    listBoxTradeInventory.Items.Clear();
                }
                IsDeath();
            }
        }
        void IsDeath()
        {
            if (player.Health <= 0 || player.Damage <= 0 || player.Agility <= 0 || player.Agility <= 0 || player.Intelligence <= 0)
            {
                MessageBox.Show("Одна из ваших характеристик опустилась до нуля. Вы погибли", "Смерть.", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        void Shmon()
        {
            int shmon = random.Next(1, 100);
            if (shmon <= 100 && shmon >= 60)
            {
                MessageBox.Show("К вам в камеру резко зашла охрана и обшмонала вас", "\"АТАС ШМОН!\"", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBoxTradeInventory.Items.Clear();
            }
        }
        private void Button1_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void buttonTheif_Click(object sender, EventArgs e)
        {
            Theif();
        }
        private void buttonLibrary_Click(object sender, EventArgs e)
        {
            pictureBoxLocation.Image = Properties.Resources.library;
            listBoxBooks.Visible = true;
            listBoxTradeInventory.Visible = false;
            buttonTrade.Visible = false;
            buttonBuy.Enabled = true;
            buttonBuy.Visible = true;


        }
        private void buttonBuy_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedbook = listBoxBooks.SelectedItem.ToString();

                if (selectedbook == null)
                {
                    MessageBox.Show("Выберите товар для покупки", "Покупка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //listBoxBooks.SelectedItems.Remove($"{selectedbook}");

                switch (selectedbook)
                {
                    case "Питон Том I за 550 руб.":

                        if (player.Money < 550)
                        {
                            MessageBox.Show("У вас недостаточно денег");
                            break;
                        }
                        else if (player.RankName == "Питонист" || player.RankName == "Луанист")
                        {
                            MessageBox.Show("У вас уже есть знания из этой книги");
                            break;
                        }
                        else
                            player.Money -= 550;
                        MessageBox.Show($"Вы приобрели книгу {selectedbook}");
                        RankPoints += 1;
                        listBoxBooks.Items.Remove(selectedbook);
                        MessageBox.Show($"Денег: {player.Money} руб.");

                        break;
                    case "Питон Том II за 700 руб.":

                        if (player.Money < 700)
                        {
                            MessageBox.Show("У вас недостаточно денег");
                            break;
                        }
                        else if (player.RankName == "Питонист" || player.RankName == "Луанист")
                        {
                            MessageBox.Show("У вас уже есть знания из этой книги");
                            break;
                        }
                        else
                            player.Money -= 700;
                        MessageBox.Show($"Вы приобрели книгу {selectedbook}");
                        RankPoints += 1;
                        listBoxBooks.Items.Remove(selectedbook);
                        MessageBox.Show($"Денег: {player.Money} руб.");

                        break;
                    case "Луа: Исповедь Roblox за 890 руб.":

                        if (player.Money < 890)
                        {
                            MessageBox.Show("У вас недостаточно денег");
                            break;
                        }
                        else if (player.RankName == "Луанист")
                        {
                            MessageBox.Show("У вас уже есть знания из этой книги");
                            break;
                        }
                        else
                            player.Money -= 890;
                        MessageBox.Show($"Вы приобрели книгу {selectedbook}");
                        RankPoints += 1;
                        listBoxBooks.Items.Remove(selectedbook);
                        MessageBox.Show($"Денег: {player.Money} руб.");

                        break;
                    case "Основы OOП за 1000 руб.":

                        if (player.Money < 1000)
                        {
                            MessageBox.Show("У вас недостаточно денег", "Упс...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else
                            player.Money -= 1000;
                        MessageBox.Show($"Вы приобрели книгу {selectedbook}");
                        RankPoints += 1;
                        listBoxBooks.Items.Remove(selectedbook);
                        MessageBox.Show($"Денег: {player.Money} руб.");

                        break;
                    case "С#: Экспресс-курс за 1250 руб.":

                        if (player.Money < 1250)
                        {
                            MessageBox.Show("У вас недостаточно денег", "Упс...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else
                            player.Money -= 1250;
                        MessageBox.Show($"Вы приобрели книгу {selectedbook}");
                        RankPoints += 1;
                        listBoxBooks.Items.Remove(selectedbook);
                        MessageBox.Show($"Денег: {player.Money} руб.");

                        break;
                    case "Базы данных для детей за 1400 руб.":

                        if (player.Money < 1400)
                        {
                            MessageBox.Show("У вас недостаточно денег", "Упс...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else
                            player.Money -= 1400;
                        MessageBox.Show($"Вы приобрели книгу {selectedbook}");
                        RankPoints += 1;
                        listBoxBooks.Items.Remove(selectedbook);
                        MessageBox.Show($"Денег: {player.Money} руб.");

                        break;
                    case "С++: Основы за 1600 руб.":

                        if (player.Money < 1600)
                        {
                            MessageBox.Show("У вас недостаточно денег", "Упс...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else
                            player.Money -= 1600;
                        MessageBox.Show($"Вы приобрели книгу {selectedbook}");
                        RankPoints += 1;
                        listBoxBooks.Items.Remove(selectedbook);
                        MessageBox.Show($"Денег: {player.Money} руб.");

                        break;
                    case "С++: Работа с памятью за 1800 руб.":

                        if (player.Money < 1800)
                        {
                            MessageBox.Show("У вас недостаточно денег", "Упс...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else
                            player.Money -= 1800;
                        MessageBox.Show($"Вы приобрели книгу {selectedbook}");
                        RankPoints += 1;
                        listBoxBooks.Items.Remove(selectedbook);
                        MessageBox.Show($"Денег: {player.Money}   руб.");

                        break;
                    case "С++: Указатели за 2000 руб.":

                        if (player.Money < 2000)
                        {
                            MessageBox.Show("У вас недостаточно денег", "Упс...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else
                            player.Money -= 2000;
                        MessageBox.Show($"Вы приобрели книгу {selectedbook}");
                        RankPoints += 1;
                        listBoxBooks.Items.Remove(selectedbook);
                        MessageBox.Show($"Денег: {player.Money}   руб.");

                        break;
                    case "С++: Работа с памятью II за 2200 руб.":
                        if (player.Money < 2200)
                        {
                            MessageBox.Show("У вас недостаточно денег", "Упс...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else
                            player.Money -= 2200;
                        MessageBox.Show($"Вы приобрели книгу {selectedbook}");
                        RankPoints += 1;
                        listBoxBooks.Items.Remove(selectedbook);
                        MessageBox.Show($"Денег: {player.Money} руб.");

                        break;
                    case "Исскусство программирование на Assembler Том I за 2800 руб.":
                        if (player.Money < 2800)
                        {
                            MessageBox.Show("У вас недостаточно денег", "Упс...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else
                            player.Money -= 2800;
                        MessageBox.Show($"Вы приобрели книгу {selectedbook}");
                        RankPoints += 1;
                        listBoxBooks.Items.Remove(selectedbook);
                        MessageBox.Show($"Денег: {player.Money} руб.");

                        break;
                    case "Исскусство программирование на Assembler Том II за 3500 руб.":

                        if (player.Money < 3500)
                        {
                            MessageBox.Show("У вас недостаточно денег", "Упс...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else
                            player.Money -= 3500;
                        MessageBox.Show($"Вы приобрели книгу {selectedbook}");
                        RankPoints += 1;
                        listBoxBooks.Items.Remove(selectedbook);
                        MessageBox.Show($"Денег: {player.Money} руб.");

                        break;
                    case "Исскусство программирование на Assembler Том III за 4000 руб.":

                        if (player.Money < 4000)
                        {
                            MessageBox.Show("У вас недостаточно денег", "Упс...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else
                            player.Money -= 4000;
                        MessageBox.Show($"Вы приобрели книгу {selectedbook}");
                        RankPoints += 1;
                        listBoxBooks.Items.Remove(selectedbook);
                        MessageBox.Show($"Денег: {player.Money} руб.");

                        break;
                }
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show($"Вы не выбрали книгу", "Упс...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Упс...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonTrade_Click(object sender, EventArgs e)
        {
            try
            {
                string? selectedItem = listBoxTradeInventory.SelectedItem.ToString(); //отлов NullReferenceException

                if (TradeInventory.Count != 0)
                {
                    double MoneyTrade = 0;
                    double Comissoin = 0;

                    listBoxTradeInventory.Items.Remove(selectedItem);
                    switch (selectedItem)
                    {
                        case "Синтаксический сахар":
                            MoneyTrade += 100;
                            TradeInventory.Remove(100);
                            break;
                        case "Пачка сигарет \"Git\"":
                            MoneyTrade += 120;
                            TradeInventory.Remove(120);
                            break;
                        case "Вино на кастылях":
                            MoneyTrade += 150;
                            TradeInventory.Remove(150);
                            break;
                        case "Чай \"ZAML\"":
                            MoneyTrade += 50;
                            TradeInventory.Remove(50);
                            break;
                        case "Кофе \"Мьютекс\"":
                            MoneyTrade += 50;
                            TradeInventory.Remove(50);
                            break;
                        case "Медикаменты \"Подсостояние суперсостояния\"":
                            MoneyTrade += 200;
                            TradeInventory.Remove(200);
                            break;
                        case "Статик Вилка":
                            MoneyTrade += 300;
                            TradeInventory.Remove(300);
                            break;
                        case "Лямбда мыло":
                            MoneyTrade += 320;
                            TradeInventory.Remove(320);
                            break;

                    }


                    if (player.RankName == "Сишарпист")
                    {
                        ComissionPercent = 30;
                        Comissoin = (MoneyTrade / 100) * ComissionPercent;
                        MoneyTrade -= Comissoin;
                    }
                    if (player.RankName == "Плюсист")
                    {
                        ComissionPercent = 20;
                        Comissoin = (MoneyTrade / 100) * ComissionPercent;
                        MoneyTrade -= Comissoin;
                    }

                    MessageBox.Show($"Вы продали товар:{selectedItem}");
                    MessageBox.Show($"Ваша выручка с продажи составила: {MoneyTrade} руб.", "Барыга", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MoneyTrade += player.Money;
                }
                else
                    MessageBox.Show($"У вас нет товара на продажу или вы хотите продать уже купленный предмет", "Упс...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"У вас нет товара на продажу или вы хотите продать уже купленный предмет", "Упс...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex){
                MessageBox.Show($"Ошибка: {ex.Message}", "Упс...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonGym_Click(object sender, EventArgs e)
        {
            listBoxBooks.Visible = false;
            listBoxTradeInventory.Visible = false;
            buttonBuy.Visible = false;
            buttonTrade.Visible = false;


            pictureBoxLocation.Image = Properties.Resources.gym;
        }
        private void buttonStreet_Click(object sender, EventArgs e)
        {
            listBoxBooks.Visible = false;
            listBoxTradeInventory.Visible = true;
            buttonBuy.Visible = false;
            buttonTrade.Visible = true;
            pictureBoxLocation.Image = Properties.Resources.street;
        }
        private void buttonOpenBox_Click(object sender, EventArgs e)
        {
            if (IsOpened == false)
            {
                pictureBoxLocation.Image = Properties.Resources.ychik;
                listBoxInventoryBox.Visible = true;
                listBoxTradeInventory.Visible = true;
                buttonPutItem.Visible = true;
                IsOpened = true;

                if (listBoxInventoryBox.Items.Count == 0 && listBoxTradeInventory.Items.Count == 0)
                {
                    buttonPutItem.Enabled = false;
                }
                else
                    buttonPutItem.Enabled = true;
            }
            else
            {
                pictureBoxLocation.Image = Properties.Resources.prison_cell;
                IsOpened = false;
                listBoxInventoryBox.Visible = false;
                listBoxTradeInventory.Visible = false;
                buttonPutItem.Visible = false;

                if (listBoxInventoryBox.Items.Count == 0 && listBoxTradeInventory.Items.Count == 0)
                {
                    buttonPutItem.Enabled = false;
                }
                else
                    buttonPutItem.Enabled = true;
            }

        }
        private void buttonPutItem_Click(object sender, EventArgs e)
        {

            if (listBoxTradeInventory.SelectedItem != null)
            {
                listBoxInventoryBox.Items.Add(listBoxTradeInventory.SelectedItem);
                listBoxTradeInventory.Items.Remove(listBoxTradeInventory.SelectedItem);
            }
            else if (listBoxInventoryBox.SelectedItem != null)
            {
                listBoxTradeInventory.Items.Add(listBoxInventoryBox.SelectedItem);
                listBoxInventoryBox.Items.Remove(listBoxInventoryBox.SelectedItem);
            }
            else
                MessageBox.Show($"Выберите предмет", "Упс...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      
    }
}
