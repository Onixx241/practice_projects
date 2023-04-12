

namespace prog { 

    public class Program {

        public static void DisplayGameResult(bool won){
            
            if(won)
                Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
            else
                Console.WriteLine("The city has been destroyed. The Manticore and the Uncoded One have won.");
        
        }
        public static int getCannonDmg(int round) {

            int damage = 1;

            if (round % 3 == 0 || round % 5 == 0){

                damage = 3;

            }

            if(round % 3 == 0 &&  round % 5 == 0) { 
            
                damage = 10;

            }

            return damage;            
        }
        public static string resolveEffect(int cannonPos, int manticorePos ) {

            if (cannonPos == manticorePos)
                return "was a DIRECT HIT";
            if (cannonPos < manticorePos)
                return "FELL SHORT of the target";
            if (cannonPos > manticorePos)
                return "OVERSHOT THE TARGET";
            else
                return "";
            
        }

          public static void Main(string[] args)
        {
            int CityHp = 15;
            int ManticoreHp = 10;
            int round = 1;

            while (CityHp > 0 && ManticoreHp > 0) {

                if (CityHp <= 0)
                    break;

                if (ManticoreHp <= 0)
                    break;

                //Take Manticore's Distance
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Choose Manticore's Distance, Player 1.");
                int manticorePos = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                //gameLoop
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Player 2, It Is Your Turn. ");
                Console.WriteLine("----------------------------------------");

                Console.WriteLine($"STATUS: Round {round} City: {CityHp}/15 Manticore: {ManticoreHp}/10");
                Console.WriteLine($"The cannon is expected to deal {getCannonDmg(round)} damage this round");

                Console.WriteLine("Enter Desired Cannon Range: ");
                int cannonPos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"That Round {resolveEffect(cannonPos, manticorePos)}");

                Console.ReadKey();
                

                if (cannonPos == manticorePos)
                {
                    ManticoreHp = ManticoreHp - getCannonDmg(round);

                }
                else {
                    CityHp = CityHp - 1;
                }
                 
                Console.Clear();
                round++;
                
                 
            }
            
            bool won = CityHp > 0;
            DisplayGameResult(won);
        }

    }

}
