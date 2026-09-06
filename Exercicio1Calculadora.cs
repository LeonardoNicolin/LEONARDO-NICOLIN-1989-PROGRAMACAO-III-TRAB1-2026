using System;

public class Exercicio1Calculadora
{
    public void Executar()
    {
        Console.WriteLine("=== Calculadora ===");

        Console.Write("Digite o primeiro numero: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo numero: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Escolha a operacao:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtracao");
        Console.WriteLine("3 - Multiplicacao");
        Console.WriteLine("4 - Divisao");
        Console.WriteLine("5 - Resto da divisao");
        Console.Write("Opcao: ");
        int opcao = Convert.ToInt32(Console.ReadLine());

  
        switch (opcao)
        {
            case 1:
                Console.WriteLine("Resultado: " + (numero1 + numero2));
                break;

            case 2:
                Console.WriteLine("Resultado: " + (numero1 - numero2));
                break;

            case 3:
                Console.WriteLine("Resultado: " + (numero1 * numero2));
                break;

            case 4:
               
                if (numero2 == 0)
                {
                    Console.WriteLine("Erro: nao e possivel dividir por zero.");
                }
                else
                {
                    Console.WriteLine("Resultado: " + (numero1 / numero2));
                }
                break;

            case 5:
                if (numero2 == 0)
                {
                    Console.WriteLine("Erro: nao e possivel calcular o resto com o segundo numero igual a zero.");
                }
                else
                {
                    Console.WriteLine("Resultado: " + (numero1 % numero2));
                }
                break;

            default:
                Console.WriteLine("Opcao invalida.");
                break;
        }
    }
}
