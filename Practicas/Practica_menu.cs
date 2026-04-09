using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("===== MENU =====");
            Console.Write("Elige una opcion: ");
            Console.WriteLine("1 Sacar la potencia");
            Console.WriteLine("2 Km a metros");
            Console.WriteLine("3 Pesos a dolares");
            Console.WriteLine("4 Celcius C a Fahrenheit F");
            Console.WriteLine("5 Ordenar 3 numeros");
            Console.WriteLine("6 FizzBuzz");
            Console.WriteLine("0 Salir");

            opcion= int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    int baseNum;
					  int resultado = 1;
                    int exponente;
					  int i = 0;

                    Console.Write("Ingresa la base: ");
                    baseNum = int.Parse(Console.ReadLine());

                    Console.Write("Ingresa el exponente: ");
                    exponente = int.Parse(Console.ReadLine());

                    while (i < exponente)
                    {
                        resultado = resultado * baseNum;
                        i++;
                    }

                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case 2:
                    double km;

                    Console.Write("Ingresa kilometros: ");
                    km = double.Parse(Console.ReadLine());

                    Console.WriteLine("Metros: " + (km * 1000));
                    break;

                case 3:
                    double pesos;
					  double tipoCambio;

                    Console.Write("Ingresa pesos: ");
                    pesos = double.Parse(Console.ReadLine());

                    Console.Write("Tipo de cambio: ");
                    tipoCambio = double.Parse(Console.ReadLine());

                    Console.WriteLine("Dolares: " + (pesos / tipoCambio));
                    break;

                case 4:
                    double C;
					  double F;

                    Console.Write("Ingresa grados Celsius: ");
                    C= double.Parse(Console.ReadLine());

                    F= (C* 9/5) + 32;

                    Console.WriteLine("Fahrenheit: " + F);
                    break;

                case 5:
                    int n1;
					  int n2;
					  int n3;
					  int temp;

                    Console.Write("Numero 1: ");
                    n1 = int.Parse(Console.ReadLine());

                    Console.Write("Numero 2: ");
                    n2 = int.Parse(Console.ReadLine());

                    Console.Write("Numero 3: ");
                    n3 = int.Parse(Console.ReadLine());

                    // Ordenar manualmente (burbuja básica)
                    if (n1 > n2)
                    {
                        temp = n1;
                        n1 = n2;
                        n2 = temp;
                    }

                    if (n1 > n3)
                    {
                        temp = n1;
                        n1 = n3;
                        n3 = temp;
                    }

                    if (n2 > n3)
                    {
                        temp = n2;
                        n2 = n3;
                        n3 = temp;
                    }

                    Console.WriteLine("Ordenados: " + n1 + ", " + n2 + ", " + n3);
                    break;

                case 6:
                    int num;
					  int j = 1;

                    Console.Write("Hasta que numero: ");
                    num = int.Parse(Console.ReadLine());

                    while (j <= num)
                    {
                        if (j % 3 == 0 && j % 5 == 0)
                            Console.WriteLine("FizzBuzz");
                        else if (j % 3 == 0)
                            Console.WriteLine("Fizz");
                        else if (j % 5 == 0)
                            Console.WriteLine("Buzz");
                        else
                            Console.WriteLine(j);

                        j++;
                    }
                    break;

                case 0:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }

            Console.WriteLine("\nPresiona una tecla para continuar...");
            Console.ReadKey();

        } while (opcion != 0);
    }
}
