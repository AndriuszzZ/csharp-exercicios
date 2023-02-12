using System;

namespace cs;
{
    public class ExercicioDois
    {
        public static void Call()
        {
            int menu = 0;

            do{
                Console.WriteLine("0 - Sair")
                Console.WriteLine("1 - Calcular médias e aprovação");
                Console.WriteLine("2 - Insira um número e descubra a que mês ele representa");
                Console.WriteLine("3 - Forca");
                Console.WriteLine("4 - Tabuada");
                Console.WriteLine("5 - Letra a Letra");
                Console.WriteLine("6 - Número ímpares multiplos de 7");
                Console.WriteLine("7 - Calcule a média de notas informadas");
                Console.WriteLine("8 - Fatorial");
                Console.WriteLine("9 - Calculo IMC");
                Console.WriteLine("10 - Operadores");
                Console.WriteLine("11 - Desafio");

                menu = Int32.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 0:
                        Console.WriteLine("Valeu!!");
                        break;
                    case 1:
                        double media, n1, n2, n3;
                        Console.WriteLine("Digite o valor da nota 1: ");
                        n1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o valor do nota 2: ");
                        n2 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o valor do nota 3: ");
                        n3 = double.Parse(Console.ReadLine());                           
                        break;
                    case 2:
                        Console.WriteLine("insira um número de 1 a 12: ");
                        int numeroMes = int32.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Digite a palavra oculta");
                        String palavra = Console.ReadLine();
                        Console.WriteLine("Digite a quantidade de tentativas");
                        int tentativas = console.ReadLine();

                        for (int i = tentativas; i > 0; i--)
                        {
                            Console.WriteLine("Digite a palavra da tentativa" + i + ": ");
                            String palavraTentativa = scanner.next();

                            if (palavra.equals(palavraTentativa))
                            {
                                Console.WriteLine("Acertou");
                                Break;
                            }
                            else
                            {
                                Console.WriteLine("Errou");
                                if(i == 1) 
                                {
                                    Console.WriteLine("Enforcado");
                                }                              
                            }
                        }
                        break;
                    case 4:
                        tabuada();
                        break;
                    case 5:
                        Console.WriteLine("Digite a palavra: ");
                        String palavraLetraALetra = Console.ReadLine();
                        char[] letras = letraALetra(palavraLetraALetra);

                        for (char letra : letras)
                        {
                            Console.WriteLine(letra);
                        }
                        break;
                    case 6:
                        Console.WriteLine("A soma dos números ímpares e múltiplos de 7 entre 1 e 500 é: " + numerosImpares());
                        break;
                        //------NÃO FIZ-------------
                    case 7:
                        mediaNotas();
                        break;
                        //--------------------------
                    case 8:
                        Console.WriteLine("Digite o número: ");
                        int numero = console.ReadLine();
                        Console.WriteLine(fatorial(numero));
                        break;
                    case 9:
                        Console.WriteLine("Digite a altura: ");
                        double altura = console.ReadLine();
                        Console.WriteLine("Digite o peso: ");
                        double peso = console.ReadLine();
                        double imc = imc(altura, peso);
                        if (imc < 18.5) {
                            Console.WriteLine("Abaixo do peso");
                        } else if (imc >= 18.5 && imc <= 24.9) {
                            Console.WriteLine("Peso ideal");
                        } else if (imc >= 25 && imc <= 29.9) {
                            Console.WriteLine("Levemente acima do peso");
                        } else if (imc >= 30 && imc <= 34.9) {
                            Console.WriteLine("Obesidade grau I");
                        } else if (imc >= 35 && imc <= 39.9) {
                            Console.WriteLine("Obesidade grau II");
                        } else if (imc >= 40) {
                            Console.WriteLine("Obesidade grau III");
                        }
                        break;
                    case 10:
                        Console.WriteLine("Digite o promeiro valor");
                        int valorUm = console.ReadLine();
                        Console.WriteLine("Digite o segundo valor");
                        int valorDois = console.ReadLine();
                        Console.WriteLine("Digite a operação (+ - * /)");
                        char operacao = console.ReadLine().charAt(0);

                        bouble resultado = operador(valorUm, valorDois, operacao);

                        Console.WriteLine("O valor da operação é " + resultado);
                        break;
                    case 11:
                        Console.WriteLine("Digite o valor em reais: ");
                        double valor = console.ReadLine().doubleValue;
                        int[] notas = notasNecessarias(valor);
                        Console.WriteLine(Arrays.ToString(notas));
                        default:
                            Console.WriteLine("Operação inválida");
                        break;

                    default:
                    Console.WriteLine("Opção não encontrada, tente novamente");
                    break;
                                
                }
            } while (menu != 0);
        }

        // 1 --------------------------------------------------------------------------
        public static void calculaMedias(double n1, double n2, double n3)
        {
                double media = (n1+n2+n3)/3;
                if(media>=7)
                    Console.WriteLine("Aprovado");
                if(media<3)
                    Console.WriteLine("Reprovado");
                if(media>=3&&media<7)
                    Console.WriteLine("Prova final");
                Console.WriteLine("O valor do media: " + media);
                Console.WriteLine();
        }
        // 2 --------------------------------------------------------------------------
        public static void numeroMes(int numeroMes)
        {
            switch(numeroMes)
            {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;
                case 2:
                    Console.WriteLine("Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("Março");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Maio");
                    break;
                case 6:
                    Console.WriteLine("Junho");
                    break;
                case 7:
                    Console.WriteLine("Julho");
                    break;                    
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Setembro");
                    break;
                case 10:
                    Console.WriteLine("Outubro");
                    break;
                case 11:
                    Console.WriteLine("Novembro");
                    break;
                case 12:
                    Console.WriteLine("Dezembro");
                    break; 

                default:
                    Console.WhiteLine("Erro, tente novamente");
                    break;
            }
        }
        // 4 --------------------------------------------------------------------------
        public static void tabuada(){
                for (int i = 0; i <= 10; i++)
                {
                Console.WriteLine("Tabuada do " + i);
                for (int j = 0; j <= 10; j++)
                {
                Console.WriteLine(i + " x " + j + " = " + (i * j));
                }
                Console.WriteLine();
                }
            }
        // 5 --------------------------------------------------------------------------
        public static char[] letraALetra(String palavra)
        {
        char[] letras = new char[palavra.length()];

        for (int i = 0; i < letras.length; i++) 
        {
            letras[i] = palavra.charAt(i);
        }
        return letras;
        }
        // 6 --------------------------------------------------------------------------
        public static int numerosImpares()
        {
            int soma = 0;
            for (int i = 1; i < 500; i++)
            {
                if(1 % 2 != 0 && 1 % 7 == 0)
                {
                    soma = soma + i;
                }
            }
            return soma;
        }
        // 8 --------------------------------------------------------------------------
        public static int fatorial(int numero)
        {
            int fatorial = 1;
            Console.WriteLine(numero + "! =");
            for (int i = numero; i > 0; i--)
            {
                fatorial *= i;
                Console.WriteLine(i + (i != 1 ? "x" :""));
            }
            Console.WriteLine("=");
            return fatorial;
        }
        // 9 --------------------------------------------------------------------------
        public static double imc(double altura, double peso) {
            return peso / (altura * altura);
        }
        // 10 --------------------------------------------------------------------------
        public static double operador(int valorUm, int valorDois, char operacao) 
        {
        double resultado = 0;
        switch (operacao) 
            {
                case '+':
                    resultado = valorUm + valorDois;
                    break;
                case '-':
                    resultado = valorUm - valorDois;
                    break;
                case '*':
                    resultado =  valorUm * valorDois;
                    break;
                case '/':
                    resultado = (double) valorUm / valorDois;
                    break;        
                default:
                    break;
            }
            return resultado;
        }
        // 11 --------------------------------------------------------------------------
        public static int[] notasNecessarias(double valor) {
        /*
         * [0] - notas 200
         * [1] - notas 100
         * [2] - notas 50
         * [3] - notas 10
         * [4] - notas 5
         * [5] - notas 1
         */
        double[] notas = new double[] { 200, 100, 50, 20, 10, 5, 1, 0.5 };
        int[] valorNotas = new int[notas.length];

        // 250 / 200 = 1
        /*valorNotas[0] = (int) (valor / 200);
        valor -= valorNotas[0] * 200; // 50

        valorNotas[1] = (int) (valor / 100);
        valor -= valorNotas[1] * 100;

        valorNotas[2] = (int) (valor / 50);
        valor -= valorNotas[2] * 50;

        valorNotas[3] = (int) (valor / 10);
        valor -= valorNotas[3] * 10;

        valorNotas[4] = (int) (valor / 5);
        valor -= valorNotas[4] * 5;

        valorNotas[5] = valor;*/
        
        for (int i = 0; i < notas.length; i++) {
            valorNotas[i] = (int) (valor / notas[i]);
            valor -= valorNotas[i] * notas[i];
        }

        return valorNotas;   
        }
    }
}
