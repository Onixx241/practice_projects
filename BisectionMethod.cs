namespace Bisection{

    public class program{
        
        public static double input(){

            double input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter A Bracketing Number");
            return input;

        }

        public static double f(double num){

            sealed int COEFF_DEG_3 = 1; //Coefficient of x^3
            sealed int COEFF_DEG_2 = 4; //Coefficient of x^2
            sealed int COEFF_DEG_0 = -10; //Coefficient of x^0

            return (COEFF_DEG_3 * Math.Pow(num, 3) + COEFF_DEG_2 * Math.Pow(num, 2) + COEFF_DEG_0 * Math.Pow(num, 0));

        }

        public static double bisectionMethod(double f_of_a, double f_of_b, double a, double b){

            double c;
            double f_of_c;

            sealed double tolerance = 0.0001;

            while(Math.Abs(a - b) > tolerance){

                c = (a + b) / 2;
                f_of_c = f(c);

                if(f_of_c * f(a) == 0 || f_of_c * f(b) == 0)
                    return c;
                else if(f_of_c * f(a) > 0)
                    a = c;
                else
                    b = c;
                
                

            }

                return (a + b) / 2;

        }

        public static int poly_input(int degree){

            Console.WriteLine("Please Enter Coefficient For Degree " + degree);
            int input = Convert.ToInt32(Console.ReadLine());
            int coefficient = input;
            return coefficient;

        }

        public static void Main(){

            double a,b,c;
            double f_of_a,f_of_b;

            int highestDegree;

            Console.WriteLine("What Is The Highest Degree Of Your Polynomial? ");

            int input = Convert.ToInt32(Console.ReadLine());
            highestDegree = input;

            for(int i = highestDegree; i => 0; i--){
                int coeff_deg_i;
                coeff_deg_i = poly_input(i);
                Console.WriteLine(coeff_deg_i);
            }

            do {

                a = input();
                b = input();

                if(f(a) * f(b) => 0){

                    Console.WriteLine("Sorry the two numbers are not bracketing the root. Please try again.");

                }
            }while(f(a) * f(b) => 0);
            
            f_of_a = f(a);
            f_of_b = f(b);

            double root = bisectionMethod(f_of_a, f_of_b, a, b );

            Console.WriteLine("Root is: " + root);

        }
    }

}
