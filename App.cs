using System;
using cs;

namespace App;


    class App
    {
        static void Main (string[] args)
        {
            int menu = 0;
            do
            {
                Console.WriteLine("1 - Exercicio 1");
                Console.WriteLine("2 - Exercicio 2");
                Console.WriteLine("3 - Exercicio 3");
                Console.WriteLine("4 - Exercicio 4");
                Console.WriteLine("5 - Exercicio 5");
                Console.WriteLine("6 - Exercicio 6");

                menu = Int32.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        ExercicioUm.Call();
                        break;
                    // case 2:
                    //     ExercicioDois.Call();
                    //     break;
                    // case 3:
                    //     ExercicioTres.Call();
                    //     break;
                    // case 4:
                    //     ExercicioQuatro.Call();
                    //     break;
                    // case 5:
                    //     ExercicioCinco.Call();
                    //     break;
                    // case 6:
                    //     ExercicioCinco.Call();
                    //     break;
                }
            } while (menu != 0);
        }
    }
    