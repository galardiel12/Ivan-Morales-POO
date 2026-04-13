using System;

class Program
{
    static void Main()
    {
        int suma=1;

        for (int i=2; i<=100; i++)
        {
            int numAnterior=suma;
            suma=suma+i;

            Console.WriteLine(numAnterior+" + " + i + " = " + suma);
        }
    }
}
