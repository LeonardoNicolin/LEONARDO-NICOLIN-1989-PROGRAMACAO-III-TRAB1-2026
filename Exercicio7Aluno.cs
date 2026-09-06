using System;

public class Aluno
{
    public string Nome { get; set; }
    public string RA { get; set; }
    public double NotaProva { get; set; }
    public double NotaTrabalho { get; set; }

    public double Frequencia { get; set; }

    public double CalcularMedia()
    {
        return (NotaProva * 0.7) + (NotaTrabalho * 0.3);
    }

    public string VerificarSituacaoPelaMedia()
    {
        if (CalcularMedia() >= 6)
        {
            return "Aprovado por media";
        }
        else
        {
            return "Reprovado por media";
        }
    }
    public string VerificarSituacaoPelaFrequencia()
    {
        if (Frequencia >= 60)
        {
            return "Aprovado por frequencia";
        }
        else
        {
            return "Reprovado por frequencia";
        }
    }
}

public class Exercicio7CadastroAluno
{
    public void Executar()
    {
        Console.WriteLine("=== Cadastro de aluno ===");

        Aluno aluno = new Aluno();

        Console.Write("Digite o nome do aluno: ");
        aluno.Nome = Console.ReadLine();

        Console.Write("Digite o RA do aluno: ");
        aluno.RA = Console.ReadLine();

        Console.Write("Digite a nota da prova (0 a 10): ");
        aluno.NotaProva = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a nota do trabalho (0 a 10): ");
        aluno.NotaTrabalho = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a frequencia do aluno em % (0 a 100): ");
        aluno.Frequencia = Convert.ToDouble(Console.ReadLine());

        double media = aluno.CalcularMedia();

        Console.WriteLine();
        Console.WriteLine("Dados do aluno:");
        Console.WriteLine("Nome: " + aluno.Nome);
        Console.WriteLine("RA: " + aluno.RA);
        Console.WriteLine("Nota da prova: " + aluno.NotaProva);
        Console.WriteLine("Nota do trabalho: " + aluno.NotaTrabalho);
        Console.WriteLine("Media: " + media);
        Console.WriteLine("Frequencia: " + aluno.Frequencia + "%");
        Console.WriteLine("Situacao pela media: " + aluno.VerificarSituacaoPelaMedia());
        Console.WriteLine("Situacao pela frequencia: " + aluno.VerificarSituacaoPelaFrequencia());
    }
}
