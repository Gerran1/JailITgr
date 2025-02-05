using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    internal class Questes
    {

        public List<string> Quest  = new List<string>();
        



        public void FirstQuest()
        {
            MessageBox.Show("Вы начали квест \"Что ж ты, фронтэнд, подошёл.\"", "Начальный квест", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Quest.Clear();
            Quest.Add("Цель игры:\n" +
              "Нужно занять как можно более высокую позицию в иерархии тюрьмы, преодолевая различные препятствия, зарабатывая влияние и игровую валюту.\n");
            Quest.Add("\nНачало игры:\n" +
                "1. Игроку предоставляется тест для проверки его знаний и для назначения ранга по результат теста.\n" +
                "После прохождения теста может присвоиться 3 различный ранга (1.- Паскаль, 2.- Питон, 3.- Луа), но также есть еще 3 ранга (4.- C#, 5.- C++, 6.- Assembly), которые можно получить в ходе прохождения игры.\n");
            Quest.Add("2. Каждый ход будет меняться локация и игрок может выполнять определенные действия:\n - Воровать товар на работе, для дальнейшей его продажи.\n " +
                "- Прятать вещи от шмона охранников.\n" +
                "- Читать книги в библиотеке для повышения ранга.");
            Quest.Add("3. Игрок может столкнуться с испытаниями, например: шмон или подлянки от других арестантов, которые могут повлиять на инвентарь игрока и его статистику.\n");
            Quest.Add("4. Игрок может повысить свой ранг с помощью: изучения нового материала из книг в библиотеке.\n");
            Quest.Add("5. В тюрьме есть перекличка, где можно будет узнать свою статистику, а во время приема пищи в обед будет доступно восполнение статистики.\n");
            Quest.Add("6. Игра заканчивается, когда игрок достигает высшего ранга или когда у игрока закончилось все здоровье и средства.\n");
            Form2 form2 = new Form2(Quest);
            form2.UpdatePictureBoxImage(Properties.Resources.gide);
            form2.Show();
        }

        public void python_1()
        {
            Quest.Clear();
            Quest.Add("Синтаксис и базовые конструкции\n" +
                "Переменные и типы данных:\n" +
                "Целые числа (int), вещественные числа (float), строки (str), списки (list), кортежи (tuple), множества (set), словари (dict).\r\nПример:\r\nx = 10\r\nname = \"Alice\"\r\nnumbers = [1, 2, 3]");
            Quest.Add("Условные операторы:\r\n\r\nИспользуются для выполнения кода в зависимости от условий.\r\nПример:\r\nif x > 5:\r\n    print(\"Больше пяти\")");
            Quest.Add("Циклы:\r\n\r\nfor для итерации по коллекциям, while для выполнения до достижения условия.\r\nПример:\r\nfor i in range(5):\r\n    print(i)");
            Quest.Add("Встроенные функции:\r\n\r\nprint(), len(), type(), input().\r\nПример:\r\nprint(\"Hello, World!\")");
            Quest.Add("Функции:\n\r\nОпределение и вызов:\r\nСоздание функций для повторного использования кода.\r\nПример:\r\ndef greet(name):\r\n    return f\"Hello, {name}\"\r\n\r\nprint(greet(\"Alice\"))");
            Quest.Add("Работа с файлами:\n\r\nЧтение и запись:\r\nПример:\r\nwith open('file.txt', 'r') as file:\r\n    content = file.read()");
            Quest.Add("Основы ООП:\n\r\nКлассы и объекты:\r\nПример:\r\nclass Dog:\r\n    def __init__(self, name):\r\n        self.name = name\r\n\r\ndog = Dog(\"Buddy\")");
            Form2 form2 = new Form2(Quest);
            form2.UpdatePictureBoxImage(Properties.Resources.python_1);
            form2.Show();
        }
        
        
        public void python_2()
        {
            Quest.Clear();
            Quest.Add("Углубленное изучение встроенных типов данных\n" +
                "Методы строк:\r\n\r\nПример:\r\ntext = \"hello\"\r\nprint(text.upper())");
            Quest.Add("Методы списков:\r\n\r\nПример:\r\nnumbers = [1, 2, 3]\r\nnumbers.append(4)");
            Quest.Add("Обработка исключений\r\nКонструкции:\r\nПример:\r\ntry:\r\n    result = 10 / 0\r\nexcept ZeroDivisionError:\r\n    print(\"Деление на ноль!\")");
            Quest.Add("Модули и пакеты\r\nИмпорт:\r\nПример:\r\nimport math\r\nprint(math.sqrt(16))");
            Quest.Add("ООП\r\nНаследование:\r\nПример:\r\nclass Animal:\r\n    def speak(self):\r\n        pass\r\n\r\nclass Dog(Animal):\r\n    def speak(self):\r\n        return \"Woof!\"");
            Quest.Add("Работа с данными\r\nМодули:\r\nПример работы с JSON:\r\nimport json\r\ndata = json.loads('{\"name\": \"Alice\"}')");
            Quest.Add("Продвинутое ООП\r\nАбстрактные классы:\r\nПример:\r\nfrom abc import ABC, abstractmethod\r\n\r\nclass Animal(ABC):\r\n    @abstractmethod\r\n    def speak(self):\r\n        pass");
            Quest.Add("Функциональное программирование\r\nЛямбда-функции:\r\nПример:\r\nadd = lambda x, y: x + y\r\nprint(add(2, 3))");
            Quest.Add("Работа с базами данных\r\nSQLite:\r\nПример:\r\nimport sqlite3\r\nconn = sqlite3.connect('example.db')");
            Quest.Add("Асинхронное программирование\r\nAsyncio:\r\nПример:\r\nimport asyncio\r\n\r\nasync def main():\r\n    print(\"Hello\")\r\nasyncio.run(main())");
            Quest.Add("Тестирование\r\nМодульное тестирование:\r\nПример:\r\nimport unittest\r\n\r\nclass TestSum(unittest.TestCase):\r\n    def test_sum(self):\r\n        self.assertEqual(sum([1, 2, 3]), 6)");
            Quest.Add("Оптимизация и отладка\r\nПрофилирование:\r\nПример:\r\nimport cProfile\r\ncProfile.run('sum(range(1000))')");
            
            Form2 form2 = new Form2(Quest);
            form2.UpdatePictureBoxImage(Properties.Resources.python_3);
            form2.Show();
        }
        public void Lua()
        {
            Quest.Clear();
            Quest.Add("Новичок\r\nСинтаксис и базовые конструкции\r\nПеременные и типы данных:\r\n\r\nИспользуйте local для создания локальных переменных. Основные типы данных: числа, строки, таблицы.\r\nПример:\r\nlocal x = 10\r\nlocal name = \"Alice\"\r\nlocal isGameActive = true");
            Quest.Add("Условные операторы:\r\n\r\nИспользуются для выполнения кода в зависимости от условий.\r\nПример:\r\nif x > 5 then\r\n    print(\"Больше пяти\")\r\nelse\r\n    print(\"Пять или меньше\")\r\nend");
            Quest.Add("Циклы:\r\n\r\nfor, while для повторения блоков кода.\r\nПример:\r\nfor i = 1, 5 do\r\n    print(i)\r\nend\r\n\r\nlocal count = 0\r\nwhile count < 5 do\r\n    print(count)\r\n    count = count + 1\r\nend");
            Quest.Add("Функции:\r\n\r\nОпределение и вызов функций для повторного использования кода.\r\nПример:\r\nfunction greet(name)\r\n    return \"Hello, \" .. name\r\nend\r\n\r\nprint(greet(\"Alice\"))");
            Quest.Add("Работа с таблицами\r\nСоздание и использование таблиц:\r\nТаблицы в Lua аналогичны спискам и словарям.\r\nПример:\r\nlocal player = {name = \"Alice\", score = 100}\r\nprint(player.name)\r\nplayer.level = 5");
            Quest.Add("Основы ООП\r\nМетатаблицы:\r\nИспользуются для создания объектов и симуляции классов.\r\nПример:\r\nlocal Dog = {}\r\nDog.__index = Dog\r\n\r\nfunction Dog.new(name)\r\n    local self = setmetatable({}, Dog)\r\n    self.name = name\r\n    return self\r\nend\r\n\r\nfunction Dog:bark()\r\n    print(\"Woof!\")\r\nend\r\n\r\nlocal myDog = Dog.new(\"Buddy\")\r\nmyDog:bark()");
            Quest.Add("Джун\r\nУглубленное изучение таблиц\r\nМетоды работы с таблицами:\r\nВставка и удаление элементов.\r\nПример:\r\nlocal numbers = {1, 2, 3}\r\ntable.insert(numbers, 4)\r\ntable.remove(numbers, 1)\r\nprint(table.concat(numbers, \", \"))");
            Quest.Add("Обработка ошибок\r\nКонструкция pcall:\r\nИспользуется для безопасного выполнения функций.\r\nПример:\r\nlocal success, result = pcall(function()\r\n    return 10 / 0\r\nend)\r\n\r\nif not success then\r\n    print(\"Ошибка: \" .. result)\r\nend");
            Quest.Add("Модули и пакеты\r\nИмпорт и использование модулей:\r\nПозволяет организовать код.\r\nПример:\r\nlocal myModule = require(game.ServerScriptService.MyModule)\r\nmyModule.myFunction()");
            Quest.Add("ООП\r\nНаследование:\r\nСоздание подклассов с использованием метатаблиц.\r\nПример:\r\nlocal Animal = {}\r\nAnimal.__index = Animal\r\n\r\nfunction Animal.new()\r\n    local self = setmetatable({}, Animal)\r\n    return self\r\nend\r\n\r\nfunction Animal:speak()\r\n    print(\"Some sound\")\r\nend\r\n\r\nlocal Dog = setmetatable({}, {__index = Animal})\r\n\r\nfunction Dog:speak()\r\n    print(\"Woof!\")\r\nend\r\n\r\nlocal myDog = Dog.new()\r\nmyDog:speak()");
            Quest.Add("Мидл\r\nАсинхронное программирование\r\nКорутины:\r\nИспользуются для выполнения асинхронных задач.\r\nПример:\r\nlocal function asyncFunction()\r\n    print(\"Start\")\r\n    wait(1)\r\n    print(\"End\")\r\nend\r\n\r\ncoroutine.wrap(asyncFunction)()");
            Quest.Add("Работа с событиями\r\nСвязывание и обработка событий:\r\nИспользуйте для взаимодействия с игровыми событиями.\r\nПример:\r\nlocal function onPlayerAdded(player)\r\n    print(player.Name .. \" присоединился к игре.\")\r\nend\r\n\r\ngame.Players.PlayerAdded:Connect(onPlayerAdded)");
            Quest.Add("Оптимизация и отладка\r\nПрофилирование и логирование:\r\nИспользуйте print() и warn() для отладки и анализа производительности.\r\nПример:\r\nprint(\"Отладочное сообщение\")\r\nwarn(\"Предупреждение о потенциальной проблеме\")");
            
            Form2 form2 = new Form2(Quest);
            form2.UpdatePictureBoxImage(Properties.Resources.Lua1);
            form2.Show();
        }
        public void OOP() { 

            Quest.Clear();
            Quest.Add("Введение в ООП\r\nОбъектно-ориентированное программирование (ООП) — это парадигма программирования, основанная на концепции «объектов», которые могут содержать данные и код для обработки этих данных. Основные принципы ООП — это инкапсуляция, наследование и полиморфизм.");
            Quest.Add("Основные концепции\r\n1. Классы и объекты\r\nКласс — это шаблон или чертеж для создания объектов. Он определяет свойства (атрибуты) и методы (функции), которые будут у объектов.\r\nОбъект — это экземпляр класса. Объекты — это конкретные реализации классов.\r\nПример:\r\n\r\nclass Car:\r\n    def __init__(self, brand, model):\r\n        self.brand = brand\r\n        self.model = model\r\n\r\n    def drive(self):\r\n        print(f\"{self.brand} {self.model} is driving.\")\r\n\r\nmy_car = Car(\"Toyota\", \"Corolla\")\r\nmy_car.drive()");
            Quest.Add("2. Инкапсуляция\r\nИнкапсуляция — это концепция сокрытия деталей реализации и предоставления только необходимого интерфейса для взаимодействия с объектом. Это достигается с помощью модификаторов доступа (например, private, public).\r\n\r\nПример:\r\n\r\nclass BankAccount:\r\n    def __init__(self, balance):\r\n        self.__balance = balance\r\n\r\n    def deposit(self, amount):\r\n        self.__balance += amount\r\n\r\n    def get_balance(self):\r\n        return self.__balance");
            Quest.Add("3. Наследование\r\nНаследование позволяет создавать новый класс на основе существующего. Новый класс, называемый подклассом, наследует свойства и методы родительского класса.\r\n\r\nПример:\r\n\r\nclass Vehicle:\r\n    def __init__(self, brand):\r\n        self.brand = brand\r\n\r\nclass Car(Vehicle):\r\n    def __init__(self, brand, model):\r\n        super().__init__(brand)\r\n        self.model = model");
            Quest.Add("4. Полиморфизм\r\nПолиморфизм позволяет использовать единый интерфейс для работы с разными типами объектов. Это достигается через переопределение методов в подклассах.\r\n\r\nПример:\r\n\r\nclass Animal:\r\n    def sound(self):\r\n        pass\r\n\r\nclass Dog(Animal):\r\n    def sound(self):\r\n        return \"Woof\"\r\n\r\nclass Cat(Animal):\r\n    def sound(self):\r\n        return \"Meow\"\r\n\r\ndef make_sound(animal):\r\n    print(animal.sound())\r\n\r\nmake_sound(Dog())\r\nmake_sound(Cat())");
            Quest.Add("Преимущества ООП\r\n1.Упрощение понимания и поддержки кода: Разделение на классы и объекты делает код более структурированным и читаемым.\r\n2.Повторное использование кода: Наследование позволяет создавать новые классы на основе существующих, что экономит время и усилия.\r\n3.Гибкость и расширяемость: Полиморфизм и инкапсуляция упрощают добавление новых функций и модификацию существующих.");

            Form2 form2 = new Form2(Quest);
            form2.UpdatePictureBoxImage(Properties.Resources.OOP);
            form2.Show();
        }

        public void С__()
        {
            Quest.Clear();
            Quest.Add("Введение\r\nC# — это объектно-ориентированный язык программирования, разработанный Microsoft. Он используется для создания разнообразных приложений, включая веб, десктоп и игры.\r\n\r\nОсновы синтаксиса\r\nПеременные и типы данных\r\nint number = 10;\r\ndouble price = 99.99;\r\nstring name = \"John\";\r\nbool isActive = true;\r\n\nОсновные операторы\r\nАрифметические: +, -, *, /, %\r\nЛогические: &&, ||, !\r\nСравнения: ==, !=, <, >, <=, >=");
            Quest.Add("Условные конструкции\r\nint age = 18;\r\nif (age >= 18)\r\n{\r\n    Console.WriteLine(\"Adult\");\r\n}\r\nelse\r\n{\r\n    Console.WriteLine(\"Minor\");\r\n}");
            Quest.Add("Циклы\r\nFor\r\nfor (int i = 0; i < 5; i++)\r\n{\r\n    Console.WriteLine(i);\r\n}\r\nWhile\r\nint i = 0;\r\nwhile (i < 5)\r\n{\r\n    Console.WriteLine(i);\r\n    i++;\r\n}\r\nФункции\r\nint Add(int a, int b)\r\n{\r\n    return a + b;\r\n}\r\n\r\nint result = Add(5, 3);\r\nConsole.WriteLine(result);");
            
            Quest.Add("Объектно-ориентированное программирование\r\nКлассы и объекты\r\nclass Car\r\n{\r\n    public string Brand { get; set; }\r\n    public string Model { get; set; }\r\n\r\n    public void Drive()\r\n    {\r\n        Console.WriteLine($\"{Brand} {Model} is driving.\");\r\n    }\r\n}\r\n\r\nCar myCar = new Car { Brand = \"Toyota\", Model = \"Corolla\" };\r\nmyCar.Drive();");
            Quest.Add("Наследование\r\nclass Vehicle\r\n{\r\n    public string Brand { get; set; }\r\n}\r\n\r\nclass Car : Vehicle\r\n{\r\n    public string Model { get; set; }\r\n}");
            Quest.Add("Полиморфизм\r\nclass Animal\r\n{\r\n    public virtual void Speak()\r\n    {\r\n        Console.WriteLine(\"Some sound\");\r\n    }\r\n}\r\n\r\nclass Dog : Animal\r\n{\r\n    public override void Speak()\r\n    {\r\n        Console.WriteLine(\"Woof\");\r\n    }\r\n}\r\n\r\nAnimal myDog = new Dog();\r\nmyDog.Speak();");
            Quest.Add("Инкапсуляция\r\nclass BankAccount\r\n{\r\n    private decimal balance;\r\n\r\n    public void Deposit(decimal amount)\r\n    {\r\n        balance += amount;\r\n    }\r\n\r\n    public decimal GetBalance()\r\n    {\r\n        return balance;\r\n    }\r\n}");
            Quest.Add("Работа с коллекциями\r\nМассивы\r\nint[] numbers = { 1, 2, 3, 4, 5 };\r\nConsole.WriteLine(numbers[0]);\r\nСписки\r\nList<string> names = new List<string> { \"Alice\", \"Bob\", \"Charlie\" };\r\nnames.Add(\"Dave\");\r\nConsole.WriteLine(names[2]);");

            Form2 form2 = new Form2(Quest);
            form2.UpdatePictureBoxImage(Properties.Resources.C__1);
            form2.Show();
        }
        public void Database()
        {
            Quest.Clear();
            Quest.Add("Введение в базы данных\r\n1. Определение и виды баз данных:\r\n\r\nРеляционные базы данных (RDBMS): Организация данных в таблицы. Примеры: MySQL, PostgreSQL, Oracle.\r\nДокументо-ориентированные базы данных: Хранение данных в формате документов. Примеры: MongoDB, CouchDB.\r\nКлюч-значение: Простая структура данных. Примеры: Redis, Memcached.\r\nГрафовые базы данных: Оптимизированы для работы с графами. Примеры: Neo4j, ArangoDB.\r\n2. Основные концепции:\r\n\r\nТаблица: Набор данных, организованных в строки и столбцы.\r\nЗапись (строка): Единичный набор связанных данных.\r\nПоле (столбец): Определенный тип данных в таблице.\r\nПервичный ключ: Уникальный идентификатор записи.\r\nВнешний ключ: Поле, связанное с первичным ключом другой таблицы.");
            Quest.Add("Проектирование баз данных\r\n1. Нормализация:\r\n\r\nПервая нормальная форма (1NF): Отсутствие повторяющихся групп.\r\nВторая нормальная форма (2NF): Устранение частичной зависимости.\r\nТретья нормальная форма (3NF): Устранение транзитивной зависимости.\r\n2. Денормализация: Балансировка между производительностью и избыточностью данных.");
            Quest.Add("Язык запросов SQL\r\n1. Основные команды:\r\n\r\nSELECT: Извлечение данных.\r\nINSERT: Добавление данных.\r\nUPDATE: Обновление данных.\r\nDELETE: Удаление данных.\r\n2. Условия и фильтрация:\r\n\r\nWHERE: Условие выборки.\r\nJOIN: Объединение таблиц.\r\nGROUP BY: Группировка данных.\r\nORDER BY: Сортировка данных.");
            Quest.Add("Администрирование баз данных\r\n1. Резервное копирование и восстановление:\r\n\r\nРегулярные бэкапы.\r\nТестирование восстановления данных.\r\n2. Безопасность:\r\n\r\nУправление доступом пользователей.\r\nШифрование данных.\r\n3. Мониторинг и оптимизация:\r\n\r\nИндексы для ускорения запросов.\r\nАнализ производительности.Современные тенденции\r\nNoSQL: Гибкость и масштабируемость.\r\nBig Data: Обработка больших объемов данных.\r\nОблачные базы данных: AWS RDS, Google Cloud SQL.");
            Quest.Add("Современные тенденции\r\nNoSQL: Гибкость и масштабируемость.\r\nBig Data: Обработка больших объемов данных.\r\nОблачные базы данных: AWS RDS, Google Cloud SQL.");
            
            Form2 form2 = new Form2(Quest);
            form2.UpdatePictureBoxImage(Properties.Resources.DataBase);
            form2.Show();
        }

        public void C_1()
        {
            Quest.Clear();
            Quest.Add("");
            Quest.Add("");
            Quest.Add("");
            Quest.Add("");
            Quest.Add("");
            Quest.Add("");
            Quest.Add("");
            Form2 form2 = new Form2(Quest);
            form2.UpdatePictureBoxImage(Properties.Resources.C_1);
            form2.Show();
        }
        public void C_2()
        {
            Quest.Clear();
            Quest.Add("");
            Quest.Add("");
            Quest.Add("");
            Quest.Add("");
            Quest.Add("");
            Quest.Add("");
            Quest.Add("");
            Form2 form2 = new Form2(Quest);
            form2.UpdatePictureBoxImage(Properties.Resources.C_1);
            form2.Show();
        }
        public void C_3()
        {
            Quest.Clear();
            Quest.Add("");
            Quest.Add("");
            Quest.Add("");
            Quest.Add("");
            Quest.Add("");
            Quest.Add("");
            Quest.Add("");
            Form2 form2 = new Form2(Quest);
            form2.UpdatePictureBoxImage(Properties.Resources.C_1);
            form2.Show();
        }
        public void C_4()
        {
            Quest.Clear();
            Quest.Add("");
            Quest.Add("");
            Quest.Add("");
            Quest.Add("");
            Quest.Add("");
            Quest.Add("");
            Quest.Add("");
            Form2 form2 = new Form2(Quest);
            form2.UpdatePictureBoxImage(Properties.Resources.C_1);
            form2.Show();
        }
    }
}
