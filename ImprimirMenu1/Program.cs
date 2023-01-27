using System;

namespace ImprimirMenu1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            string nomeInformado = Console.ReadLine();
            Console.Clear();
            ImprimirMenuFinal(nomeInformado);

            Console.ReadKey();
        }

        static void ImprimirMenuFinal(string nomeUsuario)
        {
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.WriteLine("########## MENU ##########");
            Console.WriteLine("      " + nomeUsuario + " ");
            Console.WriteLine("##########################");
            Console.ResetColor();
        }
    }

}
