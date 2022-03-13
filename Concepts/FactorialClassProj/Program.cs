using System;

public class FactorialClass
{
    public static long Factorial(int n)
    {
        if ((n < 0) || (n > 20)) return -1;

        long temp = n;
        for(int i = n-1; i > 0; i--)  temp *= i;        
        return temp;
    }
}

class MainClass
{
    static int Main(string[] args)
    {
        if (args.Length == 0) return -1;
        int num;      
        if(int.TryParse(args[0], out num))
        {
            long result = FactorialClass.Factorial(num);
            var final = result == -1 ? "Valor Invalido" : $"{args[0]}! = {result.ToString()}";
            Console.WriteLine(final);
            return 1;
        }
        
        return -1;            
    }
}