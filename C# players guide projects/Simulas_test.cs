

namespace prog { 

    public class Program {

        

        public static void Main(string[] args)
        {
            chestState State = chestState.locked;

            
            while (true)
            {
                Console.WriteLine($"The Chest Is {State}, What Do You Want To Do ?");
                string input = Console.ReadLine();

                if (State == chestState.locked && input == "unlock")
                    State = chestState.closed;
                if (State == chestState.closed && input == "open")
                    State = chestState.open;
                if (State == chestState.open && input == "close")
                    State = chestState.closed;
                if (State == chestState.closed && input == "lock")
                    State= chestState.locked;


            }
        }
        enum chestState
        {
            locked,
            closed,
            open
            

        }
    }

}