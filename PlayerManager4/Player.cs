using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager4
{
    public class Player
    {
        public string Name { get; }
        public int Score { get; set; }

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public int CompareTo(Player other)
        {
            return other.Score.CompareTo(this.Score);
        }

        public override string ToString()
        {
            return $"Nome: {Name}, Score: {Score}";
        }
    }

    public class CompareByName : IComparer<Player>
    {
        private bool ascending;

        public CompareByName(bool ascending)
        {
            this.ascending = ascending;
        }

        public int Compare(Player x, Player y)
        {
            if (ascending)
                return string.Compare(x.Name, y.Name);
            else
                return string.Compare(y.Name, x.Name);
        }
    }
}