# Trabalho 1 – Programação III

Aluno: Leonardo Nicolin
Disciplina: Programação III
Ano: 2026

## 1. Objetivo

O objetivo deste trabalho foi colocar em prática os conteúdos estudados em Programação III, usando C# e Programação Orientada a Objetos.

Foram feitos 7 exercícios diferentes. Cada exercício fica em uma classe própria e pode ser acessado pelo menu principal do programa.

## 2. Tecnologias utilizadas

  C#
 .NET 8
 Visual Studio
 Aplicação de Console

## 3. Como o programa funciona

O programa começa mostrando um menu com as opções dos 7 exercícios.

O usuário escolhe uma opção digitando o número correspondente. O `Program.cs` controla esse menu usando um `while` para manter o programa funcionando e um `switch` para identificar qual exercício deve ser executado.

Cada exercício possui sua própria classe e um método `Executar()`, onde fica a lógica do exercício.

## 4. Exercícios

Exercício 1 – Calculadora
Permite fazer soma, subtração, multiplicação, divisão e resto da divisão entre dois números. Também verifica se o usuário tentou dividir por zero.

Exercício 2 – Quantidade de vogais
Recebe uma frase ou palavra e conta quantas vogais existem nela, aceitando letras maiúsculas e minúsculas.

Exercício 3 – Apenas vogais
Recebe um texto e mostra somente as vogais encontradas.

Exercício 4 – Apenas consoantes
Recebe um texto e mostra somente as consoantes, ignorando espaços, números e caracteres especiais.

Exercício 5 – Faixa etária
Recebe a idade de uma pessoa e informa se ela é Jovem, Adulta ou Idosa. Também impede que seja informada uma idade negativa.

Exercício 6 – Cadastro de livro
Permite cadastrar um livro informando título, autor e valor. As informações ficam armazenadas somente enquanto o programa está aberto.

Exercício 7 – Cadastro de aluno
Cadastra um aluno, calcula sua média final usando a nota da prova e do trabalho e verifica se ele foi aprovado pela nota e pela frequência.


### Exercício 5

Para a idade, foi considerado:

  0 a 19 anos: Jovem
 20 a 59 anos: Adulto
 60 anos ou mais: Idoso

Assim, uma pessoa com exatamente 60 anos é considerada Idosa.

### Exercício 7

Foi considerado que o limite de faltas é de 40% de 40 aulas, ou seja, 16 faltas.

Com isso, o aluno precisa ter pelo menos 60% de frequência para ser aprovado nesse requisito.

A média final é calculada com:

* 70% da nota da prova
* 30% da nota do trabalho

A média mínima para aprovação é 7,0.

## 6. Como executar

Primeiro, é necessário ter o .NET 8 instalado.

Depois:

1. Abra o terminal na pasta do projeto.
2. Execute o comando:

dotnet run

3. O menu será exibido no console.
4. Digite o número do exercício que deseja executar.
5. Para fechar o programa, escolha a opção 0.
