// See https://aka.ms/new-console-template for more information
using System;

namespace NamespaceProgram
{
    public class program
    {
        public static void main(string[] args)
    {
        Console.WriteLine("Exercicios");
        Console.WriteLine("menu: ");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("1 - Calculo de Média");
        Console.WriteLine("2 - Calculo de Área");
        int menu = 0;
        do {
            menu = int32.parse(Console.ReadLine{});
            switch (menu)
            {
                case 0:
                    Console.writeline("Valeu!!!");
                    break;
                case 1:
                    int numeroUm = 9;
                    int numeroDois = 7;
                    int numeroTres = 8;

                    Console.writeline($"A média é {( int numeroUm + int numeroDois + int numeroTres) / 3}");
                    break;
                case 2:
                    calculaArea();
                    break;
                default:
                    Console.WriteLine("Opção não disponível");
                    break;    
            }
        } while (menu != 0);

        public static void calculaArea() {
            int ladoUm = 10;
            int ladoDois = 5;

            Console.writeline($A Area é {ladoUm + ladoDois});

        }