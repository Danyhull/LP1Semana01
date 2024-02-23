using System;
using System.Diagnostics;
using System.Text;

namespace VariousType
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variaveis Inteiros
            sbyte var1 = 8;
            byte var2 = 55;
            short var3 = 2768;
            ushort var4 = 5535;
            int var5 = 2;
            Console.WriteLine(var1 + " " + var2 + " " + var3 + " " + var4 +" "+ var5);

            //Variaveis Char
            char estrela = '\u2606';
            char netuno = '\u2646';
            Console.WriteLine(estrela + " " + netuno);

        }
    }
}
