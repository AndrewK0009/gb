using System;

class dz2
{
    static void Main()
    {
        Console.WriteLine("Enter first num m:");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second num n:");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = Ackermann(m, n);
        Console.WriteLine("Ackermann result: " + result);
    }

    static int Ackermann(int m, int n){
    if (m == 0) return n + 1;
    else if (n == 0) return Ackermann(m - 1, n);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}
}