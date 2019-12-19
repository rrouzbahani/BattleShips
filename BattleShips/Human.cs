using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShips
{
    sealed class Human : Player
    {
        //AutoImplementedProperties
        public bool RandomSelection { get; set; }
        public List<string> PowerUpsDuring;
        public string InitialPowerups;

        //Constructor
        public Human()
        {
            Name = "";
            Wins = 0;
            Losses = 0;
            Turn = true;
            ShipsLeft = 3;
            RandomSelection = true;
        }
        public Human(string playerName)
        {
            Name = playerName;
            Wins = 0;
            Losses = 0;
            Turn = true;
            ShipsLeft = 0;
            RandomSelection = false;
        }
        public override void ShipSelect()
        {
            if (RandomSelection == true)
            {
                Board array = new Board();
               
            }
        }
        public override void Firing()
        {
            
        }
    }
}
