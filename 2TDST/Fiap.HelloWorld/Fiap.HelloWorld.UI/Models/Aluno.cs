using Fiap.HelloWorld.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Fiap.HelloWorld.UI
{
    public class Aluno : Pessoa
    {
        //Propriedades

        //Chamando o enumerador Genero para ser usado em Pessoa
        public Genero Genero { get; set; }
        public DateTime DataMatricula { get; set; }
        public bool Ativo { get; set; }

        public override void Trabalhar()
        {
            Console.WriteLine("Alluno trabalhando");
        }

        //Sobrescrever o método andar

        public override void Andar()
        {
            Console.WriteLine("Aluno esta andando");
        }
    }

    public enum Genero
    {
        Masculino, Feminino, Outros
    }
}

    