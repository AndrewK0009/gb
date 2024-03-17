using System;

class dz1
{
    static void Main()
    {
        Console.Write("Enter first num m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter last num n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        GetNumbers(m,n);

    static void GetNumbers(int m, int n)
    {
        if (m <= n){
            Console.WriteLine(m);
            GetNumbers(m + 1, n);
        }
    }
    }
}