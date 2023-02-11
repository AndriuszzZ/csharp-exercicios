using System;

namespace cs 
{
    public class teste
    {
        public static void Call()
        {
            int menu = 0;
            do{
            Console.WriteLine("Listagem de exercícios em C#");
            Console.WriteLine("0 - Sair do programa");
            Console.WriteLine("1 - Calcule a Média");
            Console.WriteLine("2 - Calcule a área");
            Console.WriteLine("3 - Calcule o volume");
            Console.WriteLine("4 - Avalie se um valor é maior que o dobro de outro");
            Console.WriteLine("5 - Cálculo de Bhaskara");
            Console.WriteLine("6 - Calculo da velocidade média de uma viagem, por km e tempo");
            Console.WriteLine("7 - Cálculo do percentual de imposto pago");
            Console.WriteLine("8 - Teste se um número é ímpar ou par");
            Console.WriteLine("9 - Comparando dois strings");
            Console.WriteLine("10 - Variável com ponto em string e conversão para inteiro");
            Console.WriteLine("11 - Recebendo o salário e mostrando o valor de imposto de renda");
          
            menu = Int32.Parse(Console.ReadLine());
                switch(menu)
                {
                    case 0:
                        Console.WriteLine("Obrigado por utilizar :)");
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
                        calculoImposto();
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
                // calcular média
                public static void calcularMedia(){
                    int numeroUm = 9;
                    int numeroDois = 7;
                    int numeroTres = 8;

                    Console.WriteLine($"A média é {(numeroUm + numeroDois + numeroTres)/ 3}");
                }

                // calcular área
                public static void calcularArea()
                {
                    int ladoUm = 10;
                    int ladoDois = 5;

                    Console.WriteLine($"A área calculada é {ladoUm * ladoDois}");
                }

                // bhaskara
                public static void calcularBhaskara()
                {
                    int a = 0;
                    int b = 0;
                    int c = 0;
                    double delta = (b * b) - (4 * a * c);
                    double x1 =  0;
                    double x2 = 0;

                    if(delta < 0){
                    Console.WriteLine($"Delta é negativo");
                    }else if (delta == 0){
                    x1 = - b / (2 * a);
                    x2 = x1;
                    }else{
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    }
                    Console.WriteLine($"O valor de x1 é {(x1)}");
                    Console.WriteLine($"O valor de x2 é {(x2)}");
                }
                
                //calcular imposto
                public static void calculoImposto()
                {
                    double salario = 0;
                    double percentual = -1;


                    if(salario <= 1903.98) {
                    percentual = 0;
                    }else if (salario <= 1903.99 && salario >= 2826.65){
                        percentual = 7.5;
                    }else if (salario <= 2826.66 && salario >= 3751.05){
                        percentual = 15;
                    }else if (salario <= 3751.06 && salario >= 5664.68){
                        percentual = 22.5;
                    }else if (salario > 5664.69){
                        percentual = 27.5;
                    }

                    Console.WriteLine($"O percentual de imposto que foi pago, foi {(5,50)}");
                    
                }

                // calcular velocidade
                    public static void calcularVelocidade(){
                    double distancia = 500;
                    double tempo = 2;

                    Console.WriteLine($"A velocidade média da viagem é de {(distancia / tempo)}");
                }

                // calcular volume
                    public static void calcularVolume(){
                    double largura = 20;
                    double altura = 12;
                    double profundidade = 9;

                    double volume = largura * altura * profundidade;

                    Console.WriteLine("O cálculo total do volume é:  " + volume);
                }

                // teste Par ou Ímpar
                    public static void testeParImpar(){
                    int x;
                    Console.Write("Informe um número: ");
                    x = int.Parse(Console.ReadLine());

                    if (x % 2 == 0){
                        Console.WriteLine("\n Este é um número PAR");
                    }
                    else
                    {
                        Console.WriteLine("\n Este número é ÍMPAR");
                    }
                        Console.ReadKey();
                }


                    // comparação de strings
                    public static void compString(){
                        string str1 = "banana";
                        string str2 = "banana";

                    if(string.Compare(str1, str2) == 0){
                        Console.WriteLine("Estas strings são iguais");
                    }
                    else{
                        Console.WriteLine("Estas strings são diferentes");
                        }                    
                    }

                    // ponto em string
                    public static void pontoemString(){
                        string input = String.Empty;

                        if (Int32.TryParse("-105", out int j))
                        {
                            Console.WriteLine(j);
                        }else{
                            Console.WriteLine("String could not be parsed.");
                        }
                    }

                    // valor maior que o dobro
                    public static void maiorqueoDobro(){
                        double v1 = 10;
                        double v2 = 25;

                        if (v1>=v2*2)
                        {
                            Console.WriteLine($"\n Este valor é maior que o dobro");
                        }
                        else{
                            Console.WriteLine("Este valor não é maior que o dobro");
                        }
                    } 

                    // imposto do salário
                    public static void mostrarImposto(){
                        
                    } 
    }
}
