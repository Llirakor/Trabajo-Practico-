using System;

namespace TomasRodriguezEjercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado1, lado2;

            Console.Write("Ingrese El Lado 1: ");
            lado1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese El Lado 2: ");
            lado2 = int.Parse(Console.ReadLine());

            double Hipotenusa = Math.Sqrt((lado1 * lado1) + (lado2 * lado2));
            Console.WriteLine("La hipotenusa es: " + Hipotenusa);

            double Superficie = (lado1 + lado2) / 2;
            Console.WriteLine("El perimetro es: " + Superficie);

            double Perimetro = lado1 + lado2 + Hipotenusa;
            Console.WriteLine("El perimetro es: " + Perimetro);

            Console.ReadKey();
        }
    }
}
