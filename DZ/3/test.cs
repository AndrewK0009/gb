using System;

class dz3
{
    static void Main()
    {
        void GetReverseMass(string[] mas, int index){
        if(index < 0) return;
        Console.WriteLine(mas[index]);
        GetReverseMass(mas, index - 1);
        }
     string[] array = {"hello", "5", "kazak","Sum41"};
     GetReverseMass(array,array.Length -1);
    }
}