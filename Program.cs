using System;

class Program
{
    static void Main(string[] args)
    {
    }

    public static double divide(double a, double b)
    {
        if (b != 0)
            return a / b;
        else 
            if (a >= 0)
                return double.PositiveInfinity;
            else 
                return double.NegativeInfinity;
    }

    public static bool scp(double a)
    {
        for (int i = 0; i < a; i++)
        {
            if ( (int)Math.Sqrt(a) == i)
                return true;
        }
        return false;
    }

}



