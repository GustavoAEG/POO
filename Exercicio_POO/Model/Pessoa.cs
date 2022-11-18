using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_POO.Model
{
    public class Pessoa
    {   
        public Pessoa()
        {
            
        }
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        private string nome;
        public string Nome { get; set; }
        public int Idade
        {
            get { return Idade; }
            set
            {
                if (value > 0)
                {
                    Idade = value;
                }
                else
                {
                    Idade = 0;
                }
            }
        }
        public void ExibirDados()
        {

            Console.WriteLine("A maior idade é de " + Idade + " E seu nome é" + Nome);
        }

    }

}
