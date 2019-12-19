using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShips
{
    abstract class Player
    {
        //Fields
        private string name;
        private int wins;
        private int losses;
        private int shipsleft;
        private bool turn;
        private bool playerwins;
        //Properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Wins
        {
            get
            {
                return wins;
            }
            set
            {
                wins = value;
            }
        }
        public int Losses
        {
            get
            {
                return losses;
            }
            set
            {
                losses = value;
            }
        }
        public int ShipsLeft
        {
            get
            {
                return shipsleft;
            }
            set
            {
                shipsleft = value;
            }
        }
        public bool Turn
        {
            get
            {
                return turn;
            }
            set
            {
                turn = value;
            }
        }
        public bool PlayerWins
        {
            get
            {
                return playerwins;
            }
            set
            {
                playerwins = value;
            }
        }
        //Methods
        abstract public void ShipSelect();
        abstract public void Firing();
        public void UpdateWinsLosses()
        {
            if (PlayerWins == true)
            {
                wins++;
            }
            else
            {
                losses++;
            }
        }
    }
}
