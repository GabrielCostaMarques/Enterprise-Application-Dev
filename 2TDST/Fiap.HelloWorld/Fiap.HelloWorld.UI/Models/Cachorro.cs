using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Models
{
    internal class Cachorro : Animal
    {

        public string Nome { get; set; }
        public string Raca { get; set; }
        public string Dono { get; set; }

        //construtor que "chama" o construtor de animal (Peso, Idade)

        public Cachorro(int idade, float peso) : base(idade, peso)
        {

        }

        //Construtor que recebe peso, idade e o nome
        public Cachorro(int idade,float peso, string Nome):base(idade,peso)

        {
            this.Nome = Nome;
            this.Raca = Raca;
            this.Dono = Dono;

        }
    }
}
