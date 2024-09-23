using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class PacientePrioritario : Paciente
    {
        public PacientePrioritario(string nome, int idade) : base(nome, idade)
        {
        }
        public override void ExibirInfo()
        {
            Console.WriteLine($"[Prioritário] Paciente: {Nome}, Idade: {Idade}");
        }
    }


}

