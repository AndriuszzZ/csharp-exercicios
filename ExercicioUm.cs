using System;

namespace NamespaceProgram
{
    public class ExercicioUm
    {
        public static void main(string[] args)
        {
            int menu = 0;

            do{
            Console.WriteLine("Exercicios");
            Console.WriteLine("menu: ");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Calculo de Média");
            Console.WriteLine("2 - Calculo de Área");
            Console.WriteLine("3 - Calculo de volume");
            Console.WriteLine("4 - Avalie se um valor é maior que o dobro de outro");
            Console.WriteLine("5 - Calculo de Bhaskara");
            Console.WriteLine("6 - Calculo da velocidade média de uma viagem, por km e tempo");
            Console.WriteLine("7 - Calculo do percentual de imposto pago");
            Console.WriteLine("8 - Teste se um número é ímpar ou par");
            Console.WriteLine("9 - Comparando dois strings");
            Console.WriteLine("10 - Variável com ponto em string e conversão para inteiro");
            Console.WriteLine("11 - Recebendo o salário e mostrando o valor de imposto de renda"); 

            
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 0:
                        Console.WriteLine("Sair");
                        break;
                    case 1:
                        calcularMedia();
                        break;
                    case 2:
                        calcularArea();
                        break;
                    case 3:
                        calcularVolume();
                        break;
                    case 4:
                        maiorqueoDobro();
                        break;
                    case 5:            
                        calcularBhaskara();
                        break;
                    case 6:
                        calcularVelocidade();
                        break;
                    case 7:
                        calcularImposto();
                        break;
                    case 8:
                        testeParImpar();
                        break;
                    case 9:
                        compString();
                        break;    
                    case 10:
                        pontoemString();
                        break;
                    case 11:
                        mostrarImposto();
                        break;

                    default:
                    Console.WriteLine("Opção não encontrada, tente novamente");
                    break;
                } 
            } while (menu != 0);
        }

        // 1 -----------------------------------------------------------------------------
        public static void calcularMedia()
        {
            int numeroUm = 9;
            int numeroDois = 7;
            int numerotres = 8;

            Console.writeLine($"A média é {(numeroUm + numeroDois + numeroTres)/ 3}");
        }

        // 2 -----------------------------------------------------------------------------
        public static void calcularArea()
        {
            int ladoUm = 10;
            int ladoDois = 5;

            Console.writeLine($"O resultado da área é {ladoUm * ladoDois2}");    
        }

        // 3 -----------------------------------------------------------------------------
        public static void calcularVolume()
        {
            double largura = 20;
            double altura = 12;
            double profundidade = 9;

            double volume = largura * altura * profundidade;

            Console.writeLine($"O cálculo total do volume é: " + volume);
        }

        // 4 -----------------------------------------------------------------------------
        public static void maiorqueoDobro()
        {
            double v1 = 10;
            double v2 = 25;

            if (v1>=v2*2)
            {
                Console.WriteLine($"\n Este valor é maior que o dobro");
            }else{
                Console.WriteLine($"Este valor não é maior que o dobro");
            }
        }

        // 5 -----------------------------------------------------------------------------
        public static void calcularBhaskara()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            double delta = (b * b) - (4 * a * c);
            double x1 = 0;
            double x2 = 0;

            if(delta < 0){
            console.writeLine($"Delta é negativo");
            }else if (delta == 0){
            x1 = - b / (2 * a);
            x2 = x1;
            }else{
            x1 = (-b + math.sqrt(delta)) / (2 * a);
            x1 = (-b + math.sqrt(delta)) / (2 * a);
            }
            Console.writeLine($"O valor de x1 é {(x1)}");
            Console.writeLine($"O valor de x2 é {(x2)}");
        }
        
        // 6 -----------------------------------------------------------------------------
        public static void calcularVelocidade()
        {
            double distancia = 500;
            double tempo = 2;

            Console.WriteLine($"A velocidade média da viagem é de {(distancia / tempo)}");
        }

        // 7 -----------------------------------------------------------------------------
        public static void calcularImposto()
        {
          double faturamento = 5;
          double qtdimposto = 50;

          Console.writeLine($"O persentual de imposto pago é {(qtdimposto * 100 / faturamento)}");
        }
        
        // 8 -----------------------------------------------------------------------------
        public static void testeParImpar()
        {
            int x;
            Console.Write("Informe um número: ");
            x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("\n Este é um número PAR");
            }
            else
            {
                Console.WriteLine("\n Este número é ÍMPAR");
            }
                Console.RealKey();
        }
        
        // 9 -----------------------------------------------------------------------------
        public static void compString()
        {
            string str1 = "teste";
            string str2 = "teste";

            if(string.Compare(str1, str2) == 0)
            {
                Console.WriteLine("Estas strings são iguais");
            }
            else
            {
                Console.WriteLine("Estas strings não são iguais");
            }
        }
        
        // 10 -----------------------------------------------------------------------------
        public static void pontoemString()
        {    
            string input = String.Empty;

            if (Int32.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine(j);
            }
            else
            {
                Console.WriteLine("String could not be parsed");
            }
        }
        
        // 11 -----------------------------------------------------------------------------
        public static void mostrarImposto()
        {
            double salario = 0;
            double persentual = -1;

            if(salario <= 1903.98){
                persentual = 0;
            }else if (salario <= 1903.98 && salario >= 2826.65){
                persentual = 7.5;
            }else if (salario <= 2826.65 && salario >= 3751.05){
                persentual = 15;
            }else if (salario <= 3751.06 && salario >= 5664.68){
                persentual = 22.5;
            }else if (salario > 5664.68 ){
                persentual = 27.5;
            }

            Console.WriteLine($"O percentual de imposto que foi pago é {(5,50)}");
        }
        
    }
}