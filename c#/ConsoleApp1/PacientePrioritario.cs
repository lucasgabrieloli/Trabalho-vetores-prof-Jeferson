using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class PacientePrioritario : Paciente
    {
        public PacientePrioritario(string nome, int idade, string CPF, string telefone, string genero) : base(nome, idade, CPF, telefone, genero)
        {
        }
        public override void ExibirInfo()
        {
            Console.WriteLine($"\n\t[Prioritário]\n\t Paciente: {Nome}\n\t Idade: {Idade}\n\t CPF: {Cpf}\n\t Telefone: {Telefone}\n\t Gênero: {Genero}");
        }
    }
}
