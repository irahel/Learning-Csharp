using System;

namespace TestFactorial
{
    public class FactorialClass
    {
        public static long Factorial(int n)
        {
            if ((n < 0) || (n > 20)) return -1;

            long temp = 1;
            for(int i = 0; i < n; i++)  temp *= i;
            return temp;
        }
    }

    class MainClass
    {
        static int Main(string[] args)
        {
            if (args.Length == 0) return -1;
            int? num;

            if(int.tryParse(args[0], out num))
            {
                long result = FactorialClass.Factorial(num);
                return result == -1? -1 : result;
            }
            else
            {
                return -1;
            }
        }
    }
}
