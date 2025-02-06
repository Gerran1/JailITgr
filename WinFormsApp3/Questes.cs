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
            form2.UpdatePictureBoxImage(Properties.Resources.python_1);
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
            Quest.Add("1. Введение\r\nC++ — это компилируемый язык программирования общего назначения, разработанный как расширение C. Он поддерживает процедурное, объектно-ориентированное и обобщённое программирование.\r\nКомпиляция и запуск\r\nПрограммы на C++ можно писать в любом текстовом редакторе, но для удобства используют IDE, такие как Code::Blocks, CLion или Visual Studio.\r\nКомпиляция и запуск через терминал:\r\ng++ main.cpp -o main ./main ");
            Quest.Add("2. Основы синтаксиса\r\nКаждая программа начинается с функции main():\r\n#include <iostream> int main() { std::cout << \"Hello, world!\" << std::endl; return 0; } \r\n#include <iostream> — библиотека для ввода/вывода.\r\nstd::cout — вывод в консоль.\r\nstd::endl — перенос строки.\r\n3. Типы данных и переменные\r\nБазовые типы\r\nВвод данных\r\nint x; std::cin >> x; ");
            Quest.Add("4. Операторы\r\nАрифметические\r\n+, -, *, /, % (остаток от деления)\r\nint a = 10, b = 3; std::cout << (a % b); // 1 \r\nЛогические\r\n&& (и), || (или), ! (не)\r\nbool res = (5 > 3) && (3 < 10); // true \r\nОператоры сравнения\r\n==, !=, >, <, >=, <=\r\nОператоры присваивания\r\n=, +=, -=, *=, /=, %=");
            Quest.Add("5. Условные конструкции\r\nif (x > 0) { std::cout << \"Положительное\"; } else if (x < 0) { std::cout << \"Отрицательное\"; } else { std::cout << \"Ноль\"; } \r\nАльтернативный вариант:\r\nstd::string res = (x > 0) ? \"Положительное\" : \"Отрицательное\"; \r\nОператор switch\r\nswitch (x) { case 1: std::cout << \"Один\"; break; case 2: std::cout << \"Два\"; break; default: std::cout << \"Другое\"; } ");
            Quest.Add("6. Циклы\r\nЦикл for\r\nfor (int i = 0; i < 5; i++) { std::cout << i << \" \"; } \r\nЦикл while\r\nint i = 0; while (i < 5) { std::cout << i << \" \"; i++; } \r\nЦикл do...while\r\nint i = 0; do { std::cout << i << \" \"; i++; } while (i < 5); \r\n7. Функции\r\nОбъявление функции\r\nint sum(int a, int b) { return a + b; } \r\nПередача аргументов по ссылке\r\nvoid change(int &x) { x = 10; } ");
            Quest.Add("8. Указатели и ссылки\r\nУказатели\r\nint a = 5; int *ptr = &a; std::cout << *ptr; // 5 \r\nСсылки\r\nint a = 10; int &ref = a; ref = 20; std::cout << a; // 20 \r\n9. Массивы и строки\r\nМассивы\r\nint arr[3] = {1, 2, 3}; std::cout << arr[0]; // 1 \r\nСтроки\r\nstd::string str = \"Hello\"; std::cout << str.length(); ");
            Quest.Add("10. Классы и объекты\r\nСоздание класса\r\nclass Car { public: std::string brand; int year; void show() { std::cout << brand << \" \" << year; } }; int main() { Car car1; car1.brand = \"Toyota\"; car1.year = 2020; car1.show(); } \r\nКонструктор\r\nclass Car { public: std::string brand; Car(std::string b) { brand = b; } }; \r\n11. Работа с файлами\r\nЗапись в файл\r\n#include <fstream> std::ofstream file(\"test.txt\"); file << \"Hello!\"; file.close(); \r\nЧтение из файла\r\nstd::ifstream file(\"test.txt\"); std::string text; file >> text; std::cout << text; file.close(); ");
            Quest.Add("12. Основы STL (Standard Template Library)\r\nВекторы (std::vector)\r\n#include <vector> std::vector<int> v = {1, 2, 3}; v.push_back(4); std::cout << v[0]; // 1 \r\nМножество (std::set)\r\n#include <set> std::set<int> s = {1, 2, 3}; s.insert(4); \r\nСловарь (std::map)\r\n#include <map> std::map<std::string, int> m; m[\"apple\"] = 10; std::cout << m[\"apple\"]; // 10 ");
            Form2 form2 = new Form2(Quest);
            form2.UpdatePictureBoxImage(Properties.Resources.C_1);
            form2.Show();
        }
        public void C_2()
        {
            Quest.Clear();
            Quest.Add("Введение\r\n\r\nРабота с памятью в C++ требует внимания, так как неправильное управление ресурсами может привести к утечкам памяти, неопределённому поведению и сбоям программы. В данном пособии рассмотрены основные аспекты работы с памятью: динамическое выделение, управление ресурсами и отладка.");
            Quest.Add("1. Виды памяти в C++\r\n\r\nВ C++ существует несколько областей памяти:\r\n\r\nСтек (Stack) – используется для локальных переменных и управления вызовами функций. Выделение памяти происходит автоматически.\r\n\r\nКуча (Heap) – используется для динамического выделения памяти. Память выделяется вручную оператором new и освобождается delete.\r\n\r\nСтатическая память (Static Storage) – для глобальных и статических переменных. Существует в течение всего времени работы программы.\r\n\r\nПамять для констант (Constant Storage) – используется для строковых литералов и других неизменяемых данных.");
            Quest.Add("2. Динамическое выделение памяти\r\n\r\n2.1 Операторы new и delete\r\n\r\nДля выделения памяти в куче используются new и delete:\r\n\r\nint* ptr = new int(42);  // Выделение памяти для одного int\r\ndelete ptr;              // Освобождение памяти\r\n\r\nДля массивов используются new[] и delete[]:\r\n\r\nint* arr = new int[10];  // Выделение памяти для массива из 10 элементов\r\ndelete[] arr;            // Освобождение памяти\r\n\r\nВажно! Использование delete вместо delete[] для массива приведёт к неопределённому поведению.");
            Quest.Add("2.2 std::unique_ptr и std::shared_ptr (RAII)\r\n\r\nВручную управлять памятью опасно. Поэтому лучше использовать умные указатели.\r\n\r\n2.2.1 std::unique_ptr (уникальный указатель)\r\n\r\nГарантирует, что объект будет автоматически удалён при выходе из области видимости.\r\n\r\n#include <memory>\r\n\r\nstd::unique_ptr<int> ptr = std::make_unique<int>(42);");
            Quest.Add("2.2.2 std::shared_ptr (разделяемый указатель)\r\n\r\nИспользует подсчёт ссылок, удаляя объект, когда на него больше нет ссылок.\r\n\r\n#include <memory>\r\n\r\nstd::shared_ptr<int> ptr1 = std::make_shared<int>(42);\r\nstd::shared_ptr<int> ptr2 = ptr1;  // Оба указателя ссылаются на один объект");
            Form2 form2 = new Form2(Quest);
            form2.UpdatePictureBoxImage(Properties.Resources.C_1);
            form2.Show();
        }
        public void C_3()
        {
            Quest.Clear();
            Quest.Add("Методичка по указателям в C++\r\n\r\n1. Введение в указатели\r\n\r\nУказатели — это переменные, которые хранят адреса других переменных. Они позволяют работать с динамической памятью, изменять значения переменных по адресу и использовать структуры данных, такие как списки и деревья.\r\n\r\nОбъявление указателей\r\n\r\nСинтаксис объявления указателя:\r\n\r\nтип_данных* имя_указателя;\r\n\r\nПример:\r\n\r\nint* ptr;  // указатель на переменную типа int\r\n\r\nЗдесь ptr — это указатель, который может хранить адрес переменной типа int.");
            Quest.Add("2. Операции с указателями\r\n\r\nПолучение адреса переменной\r\n\r\nОператор & позволяет получить адрес переменной:\r\n\r\nint a = 10;\r\nint* ptr = &a; // ptr хранит адрес переменной a\r\n\r\nРазыменование указателя\r\n\r\nОператор * позволяет получить значение переменной, на которую указывает указатель:\r\n\r\nint b = 20;\r\nint* p = &b;\r\ncout << *p; // Выведет 20\r\n\r\nИзменение значения через указатель\r\n\r\nint x = 5;\r\nint* px = &x;\r\n*px = 15;  // Теперь x = 15");
            Quest.Add("3. Динамическое выделение памяти\r\n\r\nC++ позволяет выделять память в куче (heap) с помощью оператора new:\r\n\r\nint* p = new int; // Выделение памяти под один int\r\n*p = 42;\r\n\r\nДля освобождения памяти используется delete:\r\n\r\ndelete p;\r\n\r\nДля массивов:\r\n\r\nint* arr = new int[5]; // Выделение массива из 5 элементов\r\ndelete[] arr;          // Освобождение памяти");
            Quest.Add("4. Арифметика указателей\r\n\r\nУказатели поддерживают арифметические операции:\r\n\r\nint arr[3] = {10, 20, 30};\r\nint* p = arr; // Указатель на первый элемент массива\r\n\r\ncout << *p;   // 10\r\np++;          // Переход на следующий элемент\r\ncout << *p;   // 20");
            Quest.Add("5. Указатели и массивы\r\n\r\nМассивы в C++ тесно связаны с указателями:\r\n\r\nint arr[3] = {1, 2, 3};\r\nint* p = arr; // Указатель на первый элемент\r\n\r\ncout << p[1]; // Выведет 2 (эквивалентно *(p + 1))");
            Quest.Add("6. Указатели и функции\r\n\r\nПередача указателей в функцию\r\n\r\nvoid increment(int* num) {\r\n    (*num)++;\r\n}\r\n\r\nint main() {\r\n    int x = 5;\r\n    increment(&x);\r\n    cout << x; // Выведет 6\r\n}\r\n\r\nВозвращение указателя из функции\r\n\r\nint* createInt() {\r\n    int* p = new int(100);\r\n    return p;\r\n}");
            Quest.Add("7. Константные указатели\r\n\r\nУказатель на константу\r\n\r\nconst int* p; // Нельзя изменять значение через p\r\n\r\nКонстантный указатель\r\n\r\nint* const p = &x; // p всегда указывает на x\r\n\r\nКонстантный указатель на константу\r\n\r\nconst int* const p = &x; // Нельзя менять и указатель, и значение");
            Quest.Add("8. Умные указатели (Smart Pointers)\r\n\r\nВ C++11 добавлены unique_ptr, shared_ptr и weak_ptr:\r\n\r\n#include <memory>\r\n\r\nstd::unique_ptr<int> p1 = std::make_unique<int>(42);");
            Quest.Add("9. Итог\r\n\r\nУказатели — мощный инструмент, но требуют аккуратного обращения. Ошибки с указателями могут привести к утечкам памяти и неопределенному поведению. Используйте smart pointers и всегда освобождайте динамически выделенную память.");
            Form2 form2 = new Form2(Quest);
            form2.UpdatePictureBoxImage(Properties.Resources.C_1);
            form2.Show();
        }
        public void C_4()
        {
            Quest.Clear();
            Quest.Add("3. Проблемы работы с памятью\r\n\r\n3.1 Утечки памяти\r\n\r\nВозникают, если забыть освободить выделенную память:\r\n\r\nvoid leak() {\r\n    int* ptr = new int(42);  // Утечка памяти, так как delete не вызывается\r\n}\r\n\r\nИспользуйте умные указатели (std::unique_ptr, std::shared_ptr), чтобы избежать таких ситуаций.");
            Quest.Add("3.2 Висячие указатели (Dangling pointers)\r\n\r\nУказатель, который указывает на уже освобождённую память.\r\n\r\nint* ptr = new int(42);\r\ndelete ptr;\r\n*ptr = 10;  // Ошибка! Доступ к освобождённой памяти\r\n\r\nПосле освобождения памяти обнуляйте указатель:\r\n\r\ndelete ptr;\r\nptr = nullptr;");
            Quest.Add("3.3 Двойное освобождение памяти\r\n\r\nПроисходит, если дважды вызвать delete для одного указателя:\r\n\r\nint* ptr = new int(42);\r\ndelete ptr;\r\ndelete ptr;  // Ошибка! Повторное освобождение памяти\r\n\r\nРешение: Обнулять указатель после удаления (ptr = nullptr;).");
            Quest.Add("3.4 Доступ к неинициализированной памяти\r\n\r\nИспользование памяти до её инициализации ведёт к неопределённому поведению:\r\n\r\nint* ptr;\r\nstd::cout << *ptr;  // Ошибка! ptr не указывает на выделенную память\r\n\r\nРешение: Всегда инициализируйте указатели (ptr = nullptr;).");
            Quest.Add("4. Отладка проблем с памятью\r\n\r\n4.1 Использование valgrind (Linux)\r\n\r\nЗапустите программу с valgrind, чтобы проверить утечки памяти:\r\n\r\nvalgrind --leak-check=full ./your_program\r\n\r\n4.2 asan (AddressSanitizer)\r\n\r\nКомпилируйте программу с asan, чтобы выявлять ошибки работы с памятью:\r\n\r\ng++ -fsanitize=address -g main.cpp -o main\r\n./main");
            Quest.Add("5. Советы по работе с памятью\r\n\r\nИспользуйте умные указатели (std::unique_ptr, std::shared_ptr).\r\nВсегда обнуляйте указатели после delete.\r\nИзбегайте сырого new и delete, если есть альтернативы (RAII, STL-контейнеры).\r\nИспользуйте инструменты для отладки (valgrind, asan).");
            Quest.Add("Заключение\r\n\r\nПравильная работа с памятью в C++ – залог безопасных и эффективных программ. Используйте умные указатели, избегайте утечек и проверяйте код на ошибки, чтобы минимизировать проблемы с управлением памятью.");
            Form2 form2 = new Form2(Quest);
            form2.UpdatePictureBoxImage(Properties.Resources.C_1);
            form2.Show();
        }
        public void Assembler1()
        {
            Quest.Clear();
            Quest.Add("Часть 1: Основы Assembler\r\n\r\n1.1 Введение в язык Assembler\r\n\r\nAssembler (ассемблер) — это низкоуровневый язык программирования, который представляет собой текстовую форму машинных инструкций процессора. Он позволяет работать напрямую с аппаратными ресурсами компьютера, такими как регистры, память и порты ввода-вывода.");
            Quest.Add("1.2 Архитектура процессора и регистры\r\n\r\nПеред программированием на Assembler важно понимать архитектуру процессора.\r\n\r\n1.2.1 Основные компоненты процессора\r\n\r\nALU (Арифметико-логическое устройство) – выполняет арифметические и логические операции.\r\n\r\nРегистры – небольшая сверхбыстрая память внутри процессора.\r\n\r\nШина данных, адреса и управления – каналы передачи информации между компонентами.");
            Quest.Add("1.2.2 Основные регистры x86\r\n\r\nОбщие регистры (GPR - General Purpose Registers):\r\n\r\nEAX – аккумулятор, используется для арифметических операций.\r\n\r\nEBX – базовый регистр.\r\n\r\nECX – счётчик циклов.\r\n\r\nEDX – регистр данных.");
            Quest.Add("Указатели и индексы:\r\n\r\nESI (Source Index) и EDI (Destination Index) – используются при работе с массивами.\r\n\r\nESP (Stack Pointer) – указывает на вершину стека.\r\n\r\nEBP (Base Pointer) – используется для доступа к переменным в стеке.\r\n\r\n\r\nСегментные регистры:\r\n\r\nCS, DS, SS, ES, FS, GS – используются для адресации памяти.\r\n\r\n\r\nФлаговый регистр (EFLAGS) – хранит флаги состояния процессора.");
            Quest.Add("1.3 Основные инструкции Assembler\r\n\r\n1.3.1 Перемещение данных\r\n\r\nMOV – копирует данные между регистрами и памятью.\r\n\r\nMOV EAX, 5    ; загрузка числа 5 в EAX\r\nMOV EBX, EAX  ; копирование значения EAX в EBX\r\n\r\nPUSH / POP – работа со стеком.\r\n\r\nPUSH EAX    ; сохранить EAX в стеке\r\nPOP EBX     ; извлечь значение в EBX");
            Quest.Add("1.3.2 Арифметические и логические операции\r\n\r\nADD, SUB – сложение и вычитание.\r\n\r\nADD EAX, 2   ; EAX = EAX + 2\r\nSUB EAX, 1   ; EAX = EAX - 1\r\n\r\nMUL, DIV – умножение и деление.\r\n\r\nAND, OR, XOR, NOT – битовые операции.");

            Form2 form2 = new Form2(Quest);
            form2.UpdatePictureBoxImage(Properties.Resources.Assembler1);
            form2.Show();
        }
        public void Assembler2()
            {
            Quest.Clear();
            Quest.Add("Часть 2: Программирование на Assembler\r\n\r\n2.1 Условные операторы и циклы\r\n\r\n2.1.1 Условные операторы\r\n\r\nИспользуются команды CMP (сравнение) и условные переходы (JE, JNE, JG, JL).\r\n\r\nMOV EAX, 10\r\nCMP EAX, 5\r\nJE equal_label  ; если EAX == 5, перейти к метке equal_label");
            Quest.Add("2.1.2 Циклы\r\n\r\nЦикл с LOOP:\r\n\r\nMOV ECX, 5\r\nloop_start:\r\n    DEC ECX\r\n    JNZ loop_start ; Повторять, пока ECX != 0\r\n\r\n2.2 Работа с памятью\r\n\r\n2.2.1 Адресация в памяти\r\n\r\nПрямой доступ:\r\n\r\nMOV EAX, [var] ; загрузить значение переменной var в EAX\r\n\r\nКосвенный доступ:\r\n\r\nMOV EAX, [EBX] ; загрузить значение по адресу в EBX");
            Quest.Add("2.3 Вызов функций\r\n\r\n2.3.1 Стандартный вызов процедуры\r\n\r\nCALL my_function\r\n...\r\nmy_function:\r\n    RET  ; возврат из функции");
            

            Form2 form2 = new Form2(Quest);
            form2.UpdatePictureBoxImage(Properties.Resources.Assembler1);
            form2.Show();
        }
        public void Assembler3()
        {
            Quest.Clear();
            Quest.Add("Часть 3: Системное программирование и оптимизация\r\n\r\n3.1 Взаимодействие с ОС\r\n\r\n3.1.1 Вызов системных функций в Windows (через API)\r\n\r\nПример вызова MessageBox в Windows:\r\n\r\nextern MessageBoxA\r\nsection .data\r\n    message db \"Hello, World!\", 0\r\n    title db \"Message\", 0\r\nsection .text\r\nglobal main\r\nmain:\r\n    push 0\r\n    push title\r\n    push message\r\n    push 0\r\n    call MessageBoxA\r\n    ret");
            Quest.Add("3.1.2 Вызов системных функций в Linux\r\n\r\nПример syscall для вывода текста:\r\n\r\nsection .data\r\n    msg db \"Hello, World!\", 0xA\r\n    len equ $ - msg\r\n\r\nsection .text\r\nglobal _start\r\n\r\n_start:\r\n    mov eax, 4        ; syscall: sys_write\r\n    mov ebx, 1        ; stdout\r\n    mov ecx, msg      ; адрес сообщения\r\n    mov edx, len      ; длина сообщения\r\n    int 0x80          ; вызов ядра\r\n\r\n    mov eax, 1        ; syscall: sys_exit\r\n    xor ebx, ebx\r\n    int 0x80");
            Quest.Add("3.2 Оптимизация кода\r\n\r\n3.2.1 Использование регистров вместо памяти\r\n\r\nЧастые обращения к памяти замедляют выполнение программы. Используйте регистры:\r\n\r\nMOV EAX, [mem_var]  ; плохо (медленно)\r\nMOV EBX, EAX        ; лучше (быстрее)");
            Quest.Add("3.2.2 Разворачивание циклов\r\n\r\nОбычный цикл:\r\n\r\nMOV ECX, 3\r\nloop_start:\r\n    ADD EAX, 1\r\n    LOOP loop_start\r\n\r\nРазвёрнутый вариант (может быть быстрее):\r\n\r\nADD EAX, 1\r\nADD EAX, 1\r\nADD EAX, 1");
            

            Form2 form2 = new Form2(Quest);
            form2.UpdatePictureBoxImage(Properties.Resources.Assembler1);
            form2.Show();
        }
    }
}
