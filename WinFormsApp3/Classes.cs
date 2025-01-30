using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    internal class Classes
    {

        public interface IPrisoner
        {
            public int Health { get; set; }
            public int Damage { get; set; }
            public int Agility { get; set; }
            public int Intelligence { get; set; }
            public int Salary { get; set; }
            public string RankName { get; set; }



        }
        public class Player : IPrisoner
        {
            public int Health { get; set; }
            public int Damage { get; set; }
            public int Agility { get; set; }
            public int Intelligence { get; set; }
            public int Salary { get; set; }
            public string RankName { get; set; }
            public int Money { get; set; }

            public Player(int Health, int Damage, int Agility, int Intelligence, int Salary, string RankName, int Money)
            {
                this.Health = Health;
                this.Damage = Damage;
                this.Agility = Agility;
                this.Intelligence = Intelligence;
                this.Salary = Salary;
                this.RankName = RankName;
                this.Money = Money;

            }

            public void ReadABook()
            {
                MessageBox.Show("Чтение книги");
            }
            public void ExerciseInTheGym()
            {
                MessageBox.Show("Качалка");
            }
            public void PutItemInABox()
            {
                MessageBox.Show("Спрятал");
            }
        }

        public class Pascal
        {
            public int Health;
            public int Damage;
            public int Agility;
            public int Intelligence;
            public int Salary;
            public string RankName;

            public Pascal()
            {
                Health = 3;
                Damage = 3;
                Agility = 3;
                Intelligence = 3;
                Salary = 100;
                RankName = "Паскаль";
            }
        }

        public class Python
        {
            public int Health;
            public int Damage;
            public int Agility;
            public int Intelligence;
            public int Salary;
            public string RankName;

            public Python()
            {
                Health = 8;
                Damage = 2;
                Agility = 7;
                Intelligence = 5;
                Salary = 200;
                RankName = "Питонист";
            }
        }

        public class Lua
        {
            public int Health;
            public int Damage;
            public int Agility;
            public int Intelligence;
            public int Salary;
            public string RankName;

            public Lua()
            {
                Health = 5;
                Damage = 5;
                Agility = 7;
                Intelligence = 5;
                Salary = 300;
                RankName = "Луанист";
            }
        }

        public class CSharp
        {
            public int Health;
            public int Damage;
            public int Agility;
            public int Intelligence;
            public int Salary;
            public string RankName;

            public CSharp()
            {
                Health = 7;
                Damage = 6;
                Agility = 5;
                Intelligence = 6;
                Salary = 400;
                RankName = "Сишарпист";
            }
        }

        public class Cpp
        {
            public int Health;
            public int Damage;
            public int Agility;
            public int Intelligence;
            public int Salary;
            public string RankName;
            public Cpp ()
            {
                Health = 7;
                Damage = 6;
                Agility = 6;
                Intelligence = 7;
                Salary = 500;
                RankName = "Плюсист";
            }
        }

        public class Assembly
        {
            public int Health;
            public int Damage;
            public int Agility;
            public int Intelligence;
            public int Salary;
            public string RankName;

            public Assembly()
            {
                Health = 9;
                Damage = 9;
                Agility = 9;
                Intelligence = 9;
                Salary = 600;
                RankName = "Ассемблер";
            }
        }

        public class PascalAdapter : IPrisoner
        {
            readonly Pascal _playerRank;

            public int Health { get { return this._playerRank.Health; } set { this.Health = value; } }
            public int Damage { get { return this._playerRank.Damage; } set { this.Damage = value; } }
            public int Agility { get { return this._playerRank.Agility; } set { this.Agility = value; } }
            public int Intelligence { get { return this._playerRank.Intelligence; } set { this.Intelligence = value; } }
            public int Salary { get { return this._playerRank.Salary; } set { this.Salary = value; } }
            public string RankName { get { return this._playerRank.RankName; } set { this.RankName = value; } }

            public PascalAdapter(Pascal playerRank)
            {
                this._playerRank = playerRank;
            }              
        }

        public class PythonAdapter : IPrisoner
        {
            readonly Python _playerRank;

            public int Health { get { return this._playerRank.Health; } set { this.Health = value; } }
            public int Damage { get { return this._playerRank.Damage; } set { this.Damage = value; } }
            public int Agility { get { return this._playerRank.Agility; } set { this.Agility = value; } }
            public int Intelligence { get { return this._playerRank.Intelligence; } set { this.Intelligence = value; } }
            public int Salary { get { return this._playerRank.Salary; } set { this.Salary = value; } }
            public string RankName { get { return this._playerRank.RankName; } set { this.RankName = value; } }

            public PythonAdapter(Python playerRank)
            {
                this._playerRank = playerRank;
            }
        }

        public class LuaAdapter : IPrisoner
        {
            readonly Lua _playerRank;

            public int Health { get { return this._playerRank.Health; } set { this.Health = value; } }
            public int Damage { get { return this._playerRank.Damage; } set { this.Damage = value; } }
            public int Agility { get { return this._playerRank.Agility; } set { this.Agility = value; } }
            public int Intelligence { get { return this._playerRank.Intelligence; } set { this.Intelligence = value; } }
            public int Salary { get { return this._playerRank.Salary; } set { this.Salary = value; } }
            public string RankName { get { return this._playerRank.RankName; } set { this.RankName = value; } }

            public LuaAdapter(Lua playerRank)
            {
                this._playerRank = playerRank;
            }
        }

        public class CSharpAdapter : IPrisoner
        {
            readonly CSharp _playerRank;

            public int Health { get { return this._playerRank.Health; } set { this.Health = value; } }
            public int Damage { get { return this._playerRank.Damage; } set { this.Damage = value; } }
            public int Agility { get { return this._playerRank.Agility; } set { this.Agility = value; } }
            public int Intelligence { get { return this._playerRank.Intelligence; } set { this.Intelligence = value; } }
            public int Salary { get { return this._playerRank.Salary; } set { this.Salary = value; } }
            public string RankName { get { return this._playerRank.RankName; } set { this.RankName = value; } }

            public CSharpAdapter(CSharp playerRank)
            {
                this._playerRank = playerRank;
            }
        }

        public class CppAdapter : IPrisoner
        {
            readonly Cpp _playerRank;

            public int Health { get { return this._playerRank.Health; } set { this.Health = value; } }
            public int Damage { get { return this._playerRank.Damage; } set { this.Damage = value; } }
            public int Agility { get { return this._playerRank.Agility; } set { this.Agility = value; } }
            public int Intelligence { get { return this._playerRank.Intelligence; } set { this.Intelligence = value; } }
            public int Salary { get { return this._playerRank.Salary; } set { this.Salary = value; } }
            public string RankName { get { return this._playerRank.RankName; } set { this.RankName = value; } }

            public CppAdapter(Cpp playerRank)
            {
                this._playerRank = playerRank;
            }
        }

        public class AssemblyAdapter : IPrisoner
        {
            readonly Assembly _playerRank;

            public int Health { get { return this._playerRank.Health; } set { this.Health = value; } }
            public int Damage { get { return this._playerRank.Damage; } set { this.Damage = value; } }
            public int Agility { get { return this._playerRank.Agility; } set { this.Agility = value; } }
            public int Intelligence { get { return this._playerRank.Intelligence; } set { this.Intelligence = value; } }
            public int Salary { get { return this._playerRank.Salary; } set { this.Salary = value; } }
            public string RankName { get { return this._playerRank.RankName; } set { this.RankName = value; } }

            public AssemblyAdapter(Assembly playerRank)
            {
                this._playerRank = playerRank;
            }
        }

    }
}
