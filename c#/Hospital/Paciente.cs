using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Paciente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Paciente(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public virtual void ExibirInfo()
        {
            Console.WriteLine($"Paciente: {Nome}, Idade: {Idade}");
        }
    }
}   


