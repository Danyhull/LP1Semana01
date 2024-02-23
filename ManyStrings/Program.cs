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
        }
    }
}
