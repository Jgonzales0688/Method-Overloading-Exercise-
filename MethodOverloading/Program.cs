namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2, 3));
            Console.WriteLine(Add(2.0, 3.5));
            Console.WriteLine(Add(2, 3, true));
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool withDollars)
        {
            if (withDollars && (x + y) > 1)
            {
                return $"{x + y} dollars";
            }
            else if (withDollars && (x + y) == 1)
            {
                return $"{x + y} dollar";
            }
            else
            {
                return $"{x + y}";
            }
        }
    }
}


