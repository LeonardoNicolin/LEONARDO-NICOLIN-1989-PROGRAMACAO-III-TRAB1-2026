using System;

public class Exercicio2QuantidadeVogais
{
    public void Executar()
    {
        Console.WriteLine("=== Quantidade de vogais ===");
        Console.Write("Digite uma palavra ou frase: ");
        string texto = Console.ReadLine();

        int quantidadeVogais = 0;

      
        foreach (char letra in texto)
        {
            char letraMinuscula = char.ToLower(letra);

            if (letraMinuscula == 'a' || letraMinuscula == 'e' || letraMinuscula == 'i' ||
                letraMinuscula == 'o' || letraMinuscula == 'u')
            {
                quantidadeVogais++;
            }
        }

        Console.WriteLine("Quantidade de vogais encontradas: " + quantidadeVogais);
    }
}
