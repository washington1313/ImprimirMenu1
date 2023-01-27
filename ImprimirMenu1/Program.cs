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
            menuFinal(nomeInformado);

            Console.ReadKey();
        }

        static void menuFinal(string nomeUsuario)
        {
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.WriteLine("########## MENU ##########");
            Console.WriteLine("      " + nomeUsuario + " ");
            Console.WriteLine("##########################");
            Console.ResetColor();
        }
    }

}
