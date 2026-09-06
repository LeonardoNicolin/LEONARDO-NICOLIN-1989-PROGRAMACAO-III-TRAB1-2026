using System;

public class Exercicio5FaixaEtaria
{
    public void Executar()
    {
        Console.WriteLine("=== Faixa etaria ===");
        Console.Write("Digite a idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade < 0)
        {
            Console.WriteLine("Idade invalida. Nao existe idade negativa.");
            return;
        }
        if (idade <= 19)
        {
            Console.WriteLine("Classificacao: Jovem");
        }
        else if (idade >= 20 && idade <= 59)
        {
            Console.WriteLine("Classificacao: Adulto");
        }
        else
        {
            Console.WriteLine("Classificacao: Idoso");
        }
    }
}
