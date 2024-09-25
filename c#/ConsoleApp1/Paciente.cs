using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Paciente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Genero { get; set; }


        public Paciente(string nome, int idade, string CPF, string telefone, string genero)
        {
            Nome = nome;
            Idade = idade;
            Cpf = CPF;
            Telefone = telefone;
            Genero = genero;
        }
        public virtual void ExibirInfo()
        {
            Console.WriteLine($"\n\t Paciente: {Nome}\n\t Idade: {Idade}\n\t CPF: {Cpf}\n\t Telefone: {Telefone}\n\t Gênero: {Genero}");
        }
    }
}
