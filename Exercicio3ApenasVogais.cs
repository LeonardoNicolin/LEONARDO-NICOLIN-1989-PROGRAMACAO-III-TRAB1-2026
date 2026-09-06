using System;

public class Exercicio3ApenasVogais
{
    public void Executar()
    {
        Console.WriteLine("=== Apenas vogais ===");
        Console.Write("Digite uma palavra ou frase: ");
        string texto = Console.ReadLine();

        string vogaisEncontradas = "";

        foreach (char letra in texto)
        {
            char letraMinuscula = char.ToLower(letra);

            if (letraMinuscula == 'a' || letraMinuscula == 'e' || letraMinuscula == 'i' ||
                letraMinuscula == 'o' || letraMinuscula == 'u')
            {
         
                vogaisEncontradas = vogaisEncontradas + letra;
            }
        }

        Console.WriteLine("Vogais encontradas: " + vogaisEncontradas);
    }
}
