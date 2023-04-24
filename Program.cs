namespace hw4FuncSquareEquation
{
    internal class Program
    {

        public static int Square(double a, double b, double c, ref double x1, ref double x2)
        {

            double d = Math.Pow(b, 2) - 4 * a * c;



            if (d < 0)
            {


                return -1;

            }
            else if (d == 0)
            {
                x1 = (-b / 2 * a);

                return 0;
            }
            else if (d > 0)
            {
                x1 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2;
                x2 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2;

                return 1;
            }
            else
            {
                return 2;
            }




        }


        static void Main(string[] args)
        {

            double x1 = 0;
            double x2 = 0;
            double a, b, c, d;

            Console.WriteLine("Коэфициенты a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Коэфициенты b:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Коэфициенты c:");
            c = double.Parse(Console.ReadLine());


            int sol = Square(a, b, c, ref x1, ref x2);

            if (sol == -1)
            {
                Console.WriteLine($"Корней уравнения с коэффициентами {a} , {b} , {c}  нет.");

            }
            else if (sol == 0)
            {
                Console.WriteLine($"Корней уравнения с коэффициентами {a} , {b} , {c}  x1 = x2 = {x1}.");

            }

            else if (sol == 1)
            {
                Console.WriteLine($"Корней уравнения с коэффициентами {a} , {b} , {c}  x1 = {x1},  x2 = {x2}.");

            }





        }
    }
}