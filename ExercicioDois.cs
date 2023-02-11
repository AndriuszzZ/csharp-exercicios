using System;

namespace cs;

public class ExercicioDois
{
    public static void Call()
    {
        int menu = 0;
        do{
            Console.WriteLine("1 - Calcular médias e aprovação");
            Console.WriteLine("2 - Insira um número e descubra a que mês ele representa");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            menu = Int32.Parse(Console.ReadLine());
            switch (menu)
            {
                case 0:
                    Console.WriteLine("Valeu!!");
                    break;
//-----------------------------------------------------------------------------------------------------------
                case 1:
                    calculaMedias(10, 9, 7);
                    Console.WriteLine("Insura suas notas: ");
                    double notas = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("" + notas);
                    break;

                    default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
    } while (menu != 0);
}


            public static void calculaMedias(double n1, double n2, double n3){
                double notas = (n1 + n2 + n3) /3;

                if (notas >= 7)
                {
                    Console.WriteLine("\n Você foi aprovado!");
                }else if(notas <= 7)
                {
                    Console.WriteLine("\n Você foi reprovado :/");
                }

            }
}
