// See https://aka.ms/new-console-template for more information
using Fiap.HelloWorld.UI;
using Fiap.HelloWorld.UI.Models;

Console.WriteLine("Hello, World!");

//Instanciar um Aluno
Aluno aluno = new Aluno();

//Atribuir o nome ao aluno
aluno.Nome = "João";
aluno.Cpf = "1234234";

//Exibir o nome
Console.WriteLine(aluno.Nome);
Console.WriteLine(aluno.Cpf);


//Instanciar Cachorro

Cachorro dog = new Cachorro(5,15,"Brutus")
{
    Dono="Gabriel"
};

Console.WriteLine($"Nome:{dog.Nome}, Peso{dog.Peso}, Idade: {dog.Idade}, Dono: {dog.Dono}");
//Teste de git