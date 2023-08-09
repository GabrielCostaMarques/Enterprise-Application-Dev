// See https://aka.ms/new-console-template for more information
using Fiap.HelloWorld.UI;
using Fiap.HelloWorld.UI.Models;
using System.Globalization;

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

//fazer o aluno andar

aluno.Andar();
aluno.Andar("Escola");


//Setar genero do aluno
aluno.Genero = Genero.Masculino;
//Exibir
Console.WriteLine(aluno.Genero);

//Interfaces começam com a letra "I"

//Criar uma lista de cachorro
IList<Cachorro>lista = new List<Cachorro>();

//Adicionar Dois cachorros na lista
var dog1 = new Cachorro(15, 2, "Pandora");
var dog2 = new Cachorro(2, 20, "Caramelo");

lista.Add(dog1);
lista.Add(dog2);


//Exibir quantidade 
Console.WriteLine($"Quantidade de cachorro é: {lista.Count()}");

//Exibir Dados
for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"Nome: {lista[i].Nome} Idade: {lista[i].Idade}");
   
}
