using System;
using System.Collections.Generic;

namespace ConsoleApp.RoboTupiniquim
{
    internal class RoboTupiniquim
    {
        // - 2 ENTRADA
        //– O resto das entradas deve ser os comandos que o robô deve executar.Cada comando deve ser enviado em 2 partes: a primeira parte é a posição inicial do robô
        //e a segunda uma série de instruções que aquele robô deve seguir para explorar a área.
        //A posição é dada com 2 inteiros e uma letra, separados por espaços, correspondendo pelas coordenadas X e Y e a orientação do robô.Cada robô vai executar as
        //instruções de forma sequencial: o segundo robô só iniciará suas ações quando o primeiro terminar.

        static void Main(string[] args)
        {

            // coordenadas do canto superior direito da área
            Console.WriteLine("Informe as coordenadas do canto superior direito da área: ");
            string[] coordenadasSupDireita = Console.ReadLine().Split(' ');
            int superiorDireitaX = int.Parse(coordenadasSupDireita[0]);
            int superiorDireitaY = int.Parse(coordenadasSupDireita[1]);

            // Nova lista para armazenar múltiplos objetos
            List<Robo> robos = new List<Robo>();

            //– Comandos que o robô deve executar.Cada comando deve ser enviado em 2 partes:
            //a primeira parte é a posição inicial do robô
            //e a segunda uma série de instruções que aquele robô deve seguir para explorar a área.
            while (true)
            {
                Console.WriteLine("Digite a posição inicial do robô e a série de instruções, separe as instruções com espaço:");
                string[] entrada = Console.ReadLine().Split(' ');

                if (entrada.Length != 2)
                {
                    Console.WriteLine("Entrada inválida. Por favor, tente novamente.");
                    continue;
                }


                string instructions = entrada[1].ToUpper();
            }
        }


    


