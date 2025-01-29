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
            public int Salary = 3;
            public string RankName = "Паскаль";

            public Pascal()
            {
                Health = 3;
                Damage = 3;
                Agility = 3;
                Intelligence = 3;
                Salary = 3;
                RankName = "Паскаль";
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


    }
}
