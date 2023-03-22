
namespace tileCost{

    public class costFinder{


        static int Tiles(int width, int height, int cost){
        
        int area = width * height;

        return area*cost;

        }

        static void Main(){

            Console.WriteLine($"The cost for the tiles will be... ${Tiles(5,5,10)}");

        }
    }
}
