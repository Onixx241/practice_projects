namespace program{

    public class prog{

        public static void Main(){

            bool running = true;

            while(running){
                
                    Console.Write("User 1, enter a number between 0 and 100: ");
                
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    bool numberEntered = true;

                while(numberEntered){

                        Console.Write("User 2, guess the number ");

                         int answer = Convert.ToInt32(Console.ReadLine());

                         if(answer < number){
                              Console.WriteLine("The answer is too low !");
                    }

                         if(answer > number){
                              Console.WriteLine("The answer is too high !");
                    }
                    
                        if(answer == number){
                              Console.WriteLine("That's the correct answer !");
                              numberEntered = false;
                    }

                }
            } 

        }

    }

}
