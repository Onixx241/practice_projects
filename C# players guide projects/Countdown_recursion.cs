using System.Diagnostics.CodeAnalysis;

namespace prog { 

    public class Program {

        public static void recursLoop(int num) {
            
            if(num == 0) return;

            

            Console.WriteLine(num);
            recursLoop(num - 1);
        }

          public static void Main(string[] args)
        {
            recursLoop(20);
        }
    
    }

}