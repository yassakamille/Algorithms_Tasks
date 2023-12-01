using System;
public class Program
{
    public static double PowNum(double A, int power)
    {
        if (power == 1)
        {
            return A;
        }
        else if (power == 0)
        {
            return 1;
        }
        int half = power / 2;
        double P = PowNum(A, half);
        if (power % 2 != 0)
        {
            return P * P * A;
        }
        else
        {
            return P * P;
        }
    }
    public static void Main(string[] args)
    {
        double A = 2.5;
        int N = 5;
        double result = PowNum(A, N);
        Console.WriteLine("The result is: " + result);
    }
}
 