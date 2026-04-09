using System;

namespace emojisAleatorios{
	//En el namespace en lugar de punto y coma puse llaves poque en la versión de c# de iphone es mas vieja y es asi.
}

public static class Programa
{
    public static void Main()
    {
        Random generador = new Random();
        int maximo = 100;

        Console.WriteLine();

        int parteA = generador.Next(0, 101);
        Console.WriteLine("Cantidad A: " + parteA);

        maximo = maximo - parteA;

        int parteB = generador.Next(0, maximo);
        Console.WriteLine("Cantidad B: " + parteB);

        int sumaParcial = parteA + parteB;
        int parteC = 100 - sumaParcial;

        Console.WriteLine("Cantidad C: " + parteC);

        for (int contador = 1; contador <= 100; contador++)
        {
            if (contador <= parteA)
            {
                string simbolo1 = "😎";
                Console.WriteLine(contador + " -> " + simbolo1);
            }
            else if (contador <= parteA + parteB)
            {
                string simbolo2 = "🥸";
                Console.WriteLine(contador + " -> " + simbolo2);
            }
            else
            {
                string simbolo3 = "🫪";
                Console.WriteLine(contador + " -> " + simbolo3);
            }
        }
    }
}
