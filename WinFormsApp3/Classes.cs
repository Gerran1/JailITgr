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
            public int Health = 3;
            public int Damage = 3;
            public int Agility = 3;
            public int Intelligence = 3;
            public int Salary = 100;
            public string RankName = "Паскаль";

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
            public int Health = 8;
            public int Damage = 2;
            public int Agility = 7;
            public int Intelligence = 5;
            public int Salary = 200;
            public string RankName = "Питонист";

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
            public int Health = 5;
            public int Damage = 5;
            public int Agility = 7;
            public int Intelligence = 5;
            public int Salary = 300;
            public string RankName = "Луанист";

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
            public int Health = 7;
            public int Damage = 6;
            public int Agility = 5;
            public int Intelligence = 6;
            public int Salary = 400;
            public string RankName = "Сишарпист";

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
            public int Health = 7;
            public int Damage = 6;
            public int Agility = 6;
            public int Intelligence = 7;
            public int Salary = 500;
            public string RankName = "Плюсист";

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
            public int Health = 9;
            public int Damage = 9;
            public int Agility = 9;
            public int Intelligence = 9;
            public int Salary = 600;
            public string RankName = "Ассемблер";

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
