using System;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("PROGRAMACAO III - TRABALHO 1");
            Console.WriteLine("========================================");
            Console.WriteLine("1 - Calculadora");
            Console.WriteLine("2 - Quantidade de vogais");
            Console.WriteLine("3 - Apenas vogais");
            Console.WriteLine("4 - Apenas consoantes");
            Console.WriteLine("5 - Faixa etaria");
            Console.WriteLine("6 - Cadastro de livro");
            Console.WriteLine("7 - Cadastro de aluno");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opcao: ");

            string opcaoDigitada = Console.ReadLine();
            int opcao;

            bool conseguiuConverter = int.TryParse(opcaoDigitada, out opcao);

            if (!conseguiuConverter)
            {
                Console.WriteLine("Opcao invalida. Digite um numero do menu.");
                Console.WriteLine("Pressione ENTER para continuar...");
                Console.ReadLine();
                continue;
            }

            Console.WriteLine();

            switch (opcao)
            {
                case 1:
                    Exercicio1Calculadora exercicio1 = new Exercicio1Calculadora();
                    exercicio1.Executar();
                    break;

                case 2:
                    Exercicio2QuantidadeVogais exercicio2 = new Exercicio2QuantidadeVogais();
                    exercicio2.Executar();
                    break;

                case 3:
                    Exercicio3ApenasVogais exercicio3 = new Exercicio3ApenasVogais();
                    exercicio3.Executar();
                    break;

                case 4:
                    Exercicio4ApenasConsoantes exercicio4 = new Exercicio4ApenasConsoantes();
                    exercicio4.Executar();
                    break;

                case 5:
                    Exercicio5FaixaEtaria exercicio5 = new Exercicio5FaixaEtaria();
                    exercicio5.Executar();
                    break;

                case 6:
                    Exercicio6CadastroLivro exercicio6 = new Exercicio6CadastroLivro();
                    exercicio6.Executar();
                    break;

                case 7:
                    Exercicio7CadastroAluno exercicio7 = new Exercicio7CadastroAluno();
                    exercicio7.Executar();
                    break;

                case 0:
                    Console.WriteLine("Encerrando o programa. Ate mais!");
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opcao invalida. Escolha um numero de 0 a 7.");
                    break;
            }

            if (continuar)
            {
                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para voltar ao menu...");
                Console.ReadLine();
            }
        }
    }
}
