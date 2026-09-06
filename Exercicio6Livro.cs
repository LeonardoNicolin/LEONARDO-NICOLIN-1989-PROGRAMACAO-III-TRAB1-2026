using System;

public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public double Valor { get; set; }
}

public class Exercicio6CadastroLivro
{
    public void Executar()
    {
        Console.WriteLine("=== Cadastro de livro ===");

        Livro livro = new Livro();

        Console.Write("Digite o titulo do livro: ");
        livro.Titulo = Console.ReadLine();

        Console.Write("Digite o autor do livro: ");
        livro.Autor = Console.ReadLine();

        Console.Write("Digite o valor do livro: ");
        livro.Valor = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Livro cadastrado:");
        Console.WriteLine("Titulo: " + livro.Titulo);
        Console.WriteLine("Autor: " + livro.Autor);
        Console.WriteLine("Valor: R$ " + livro.Valor);
    }
}
