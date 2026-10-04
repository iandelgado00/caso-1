using System;
class Program
{
    static void Main(string[] args)
    {
        double nota;

        Console.Write("Digite la nota final: ");
        nota = double.Parse(Console.ReadLine());
        if (nota >= 0 && nota <= 100)
        {
            if (nota >= 70)
            {
                Console.WriteLine("El estudiante aprueba.");
            }
            else
            {
                Console.WriteLine("El estudiante reprueba.");
            }
        }
        else
        {
            Console.WriteLine("La nota no es valida.");
        }
    }
}
