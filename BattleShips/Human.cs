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
                
                string chosen = "";
                string ab, bc, cd, de, ef = "";
                int size = 0;
                string[] shipArray;
                int i = 1;
               Random rGen = new Random();
                int rNum = rGen.Next(7);
                
                switch (chosen)
                {
                    case "Lake":
                        {
                            shipArray = new string[7];
                            do
                            {
                                switch(rNum)
                                {
                                    case 1:
                                        {
                                            Ships sub = new Ships();
                                            shipArray[i] = sub.ShipName;
                                            break;
                                        }
                                    case 2:
                                        {
                                            Ships Frigate = new Ships(ab);
                                            shipArray[i] = Frigate.ShipName;
                                            break;
                                        }
                                    case 3:
                                        {
                                            Ships Dest = new Ships(ab, bc);
                                            shipArray[i] = Dest.ShipName;
                                            break;
                                        }
                                    case 4:
                                        {

                                            break;
                                        }
                                    case 5:
                                        {

                                            break;
                                        }
                                    case 6:
                                        {

                                            break;
                                        }
                                }


                                i++;
                            }while(i == size);

                            break;
                        }
                    case "Sea":
                        {
                            shipArray = new string[10];
                            break;
                        }
                    case "Ocean":
                        {
                            shipArray = new string[20];
                            break;
                        }
                }



            }
        }
        public override void Firing()
        {
            
        }
    }
}
