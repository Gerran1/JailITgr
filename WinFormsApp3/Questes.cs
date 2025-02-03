﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    internal class Questes
    {

        public void FirstQuest()
        {
            MessageBox.Show("Вы начали квест \"Что ж ты, фронтэнд, подошёл.\"", "Начальный квест", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Цель игры:\n" +
                "Нужно занять как можно более высокую позицию в иерархии тюрьмы, преодолевая различные квесты, зарабатывая влияние и игровую валюту.\n" +
                "\nНачало игры:\n" +
                "1. Игроку предоставляется тест для проверки его знаний и для назначения ранга по результат теста.\n" +
                "После прохождения теста может присвоиться 3 различный ранга (1.- Паскаль, 2.- Питон, 3.- Луа), но также есть еще 3 ринга(4.- C#, 5.- C++, 6.- Assembly), который можно получить в ходе прохождения игры.\n" +
                "2. Каждый ход будет меняться локация и игрок может выполнять определенные действия:\n" +
                "- Выполнять различные квесты от арестантов за награду.\n" +
                "- Устраивать подлянки другим арестантам.\n" +
                "- Почитать книги в библиотекек для повышения ранга.\n" +
                "3. Игрок может столкнуться с испытаниями, например: шмон или подлянки от других арестантов, которые могут повлиять на их статистику.\n" +
                "4. Игрок может повысить свой ранг с помощью: Изученяи нового материала из книг в библиотеке или успешную торговлю с барыгами.\n" +
                "5. В тюрьме есть перекличка, где можно будет узнать совю статистику, а во время приема пищи будет доступно восполнение статистики.\n" +
                "6. Игра заканчивается, когда игрок достигает высшего рагна или когда у игрока закончилось все здоровье и средства.\n" +
                "Приятной игры!", "Начальный квест", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
    }
}
