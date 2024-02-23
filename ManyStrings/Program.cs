using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex4
            string A = "\u261A";
            string B = "Good\\Night \u263E";
            string C = "Good Morning!";
            string D = "simbolos \u2767 \u1F41 \u1F90 ";
            Console.WriteLine(A + " " + B + " " + C + " " + " "+ D);

            //Ex5
            string E = "Cão " + 3 + "Gato";
            string F = "Ouvi dizer" + C;
            string G = "Levanta-te " + "e " + "Ri";
            string H = "um simbolo " + A + " mais " + D;
            E += " x vezes ";
            string I = $"{A} mais {C} é igual a {A+C}";
            string J = $"pasta {B}";
            Console.WriteLine(E + "  " + F + "  " + G + "  " + H +
             "  " + I + "  " + J);
        }
    }
}
