using System;

namespace ListaExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("===== LISTA DE EXERCÍCIOS =====");
                Console.WriteLine("1 - Distância entre dois pontos");
                Console.WriteLine("2 - Cálculo de D");
                Console.WriteLine("3 - Peso ideal");
                Console.WriteLine("4 - Soma S");
                Console.WriteLine("5 - Salário com hora extra");
                Console.WriteLine("6 - Reajuste de preço");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                int.TryParse(Console.ReadLine(), out opcao);

                Console.Clear();

                switch (opcao)
                {
                    case 1: Exercicio01(); break;
                    case 2: Exercicio02(); break;
                    case 3: Exercicio03(); break;
                    case 4: Exercicio04(); break;
                    case 5: Exercicio05(); break;
                    case 6: Exercicio06(); break;
                    case 0: Console.WriteLine("Encerrando..."); break;
                    default: Console.WriteLine("Opção inválida!"); break;
                }

                if (opcao != 0)
                {
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                }

            } while (opcao != 0);
        }


        // EXERCÍCIO 01
        static void Exercicio01()
        {
            Console.Write("Digite x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Distância = " + distancia);
        }

        // EXERCÍCIO 02
        static void Exercicio02()
        {
            Console.Write("Digite A: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite C: ");
            int C = Convert.ToInt32(Console.ReadLine());

            double R = Math.Pow(A + B, 2);
            double S = Math.Pow(B + C, 2);
            double D = (R + S) / 2;

            Console.WriteLine("Valor de D = " + D);
        }

        // EXERCÍCIO 03
        static void Exercicio03()
        {
            Console.Write("Digite sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o sexo (M/F): ");
            char sexo = Convert.ToChar(Console.ReadLine().ToUpper());

            double pesoIdeal;

            if (sexo == 'M')
                pesoIdeal = (72.7 * altura) - 58;
            else
                pesoIdeal = (62.1 * altura) - 44.7;

            Console.WriteLine("Peso ideal = " + pesoIdeal);
        }

        // EXERCÍCIO 04
        static void Exercicio04()
        {
            double S = 0;
            int numerador = 1;

            for (int denominador = 1; denominador <= 50; denominador++)
            {
                S += (double)numerador / denominador;
                numerador += 2;
            }

            Console.WriteLine("Valor de S = " + S);
        }

        // EXERCÍCIO 05
        static void Exercicio05()
        {
            Console.Write("Horas trabalhadas no mês: ");
            double horasMes = Convert.ToDouble(Console.ReadLine());

            Console.Write("Valor da hora: ");
            double valorHora = Convert.ToDouble(Console.ReadLine());

            double salario;
            double horasNormais = 160;

            if (horasMes <= horasNormais)
            {
                salario = horasMes * valorHora;
            }
            else
            {
                double extras = horasMes - horasNormais;
                salario = (horasNormais * valorHora) + (extras * valorHora * 1.5);
            }

            Console.WriteLine("Salário total = R$ " + salario);
        }

        // EXERCÍCIO 06
        static void Exercicio06()
        {
            Console.Write("Venda média mensal: ");
            int venda = Convert.ToInt32(Console.ReadLine());

            Console.Write("Preço atual: ");
            double preco = Convert.ToDouble(Console.ReadLine());

            double novoPreco = preco;

            if (venda < 500 && preco < 30)
            {
                novoPreco = preco * 1.10;
                Console.WriteLine("Aumento de 10%");
            }
            else if (venda >= 500 && preco >= 30)
            {
                novoPreco = preco * 0.80;
                Console.WriteLine("Redução de 20%");
            }
            else
            {
                Console.WriteLine("Sem alteração");
            }

            Console.WriteLine("Novo preço = R$ " + novoPreco);
        }
    }
}
