using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientLab.Classes
{
    public static class Util
    {
        public static void ParadaNoConsole(string texto)
        {
            Console.WriteLine(texto);
            Console.ReadLine(); //adiciona parada no sistema
        }

        public static void Loading(string texto, int milesegundos, int qtdPontos, ConsoleColor corFundo, ConsoleColor corFonte)
        {
            Console.BackgroundColor = corFundo;
            Console.ForegroundColor = corFonte;
            Console.Write($"{texto}");

            for (int i = 0; i <= qtdPontos; i++)
            {
                Console.Write($" .");
                Thread.Sleep(milesegundos);
            }

            Console.ResetColor();
        }
    }
}