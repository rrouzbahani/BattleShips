using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShips
{
    sealed class Board
    {
        private int[,] size;
        public string Style { get; set; }
        private int amount;

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public Board()
        {
            int[,] size = new int[0, 0];
            Style = "";
            int amount = 0;
        }

        public Board(int s)
        {
            int[,] size = new int[7, 7];
            Style = "Lake";
            int amount = 3;
        }

        public Board(int s, int m)
        {
            int[,] size = new int[10, 10];
            Style = "Sea";
            int amount = 4;
        }

        public Board(int s, int m, int l)
        {
            int[,] size = new int[20, 20];
            Style = "Ocean";
            int amount = 5;
        }
    }
}
