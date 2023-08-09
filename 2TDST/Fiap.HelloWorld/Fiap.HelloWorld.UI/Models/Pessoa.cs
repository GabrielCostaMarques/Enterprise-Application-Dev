﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Models
{
    public abstract class Pessoa
    {
        //Atributos
        private string _nome;
        private int _idade;

        //Propriedades (Getters e Setters)
        public string Cpf { get; set; }

        public string Nome 
        { 
            get { return _nome; } 
            set { _nome = value; } 
        }

        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }

        //métodos
        public abstract void Trabalhar();

        // "Virtual" permite a sobrescrita do método que esta na classe aluno
        public virtual void Andar()
        {
            Console.WriteLine("pessoa andando");
        }

        public void Andar(string destinos)
        {
            Console.WriteLine($"Andando ate o {destinos}");
        }
    }
}
