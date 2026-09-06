using System;

public class Exercicio4ApenasConsoantes
{
    public void Executar()
    {
        Console.WriteLine("=== Apenas consoantes ===");
        Console.Write("Digite uma palavra ou frase: ");
        string texto = Console.ReadLine();

        string consoantesEncontradas = "";

        foreach (char letra in texto)
        {
            char letraMinuscula = char.ToLower(letra);

            bool ehVogal = letraMinuscula == 'a' || letraMinuscula == 'e' || letraMinuscula == 'i' ||
                           letraMinuscula == 'o' || letraMinuscula == 'u';

            
            if (char.IsLetter(letra) && !ehVogal)
            {
                consoantesEncontradas = consoantesEncontradas + letra;
            }
        }

        Console.WriteLine("Consoantes encontradas: " + consoantesEncontradas);
    }
}
