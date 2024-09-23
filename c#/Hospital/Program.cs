using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FilaPaciente fila = new FilaPaciente();
            int opcao;

            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("\n1. Cadastrar Paciente");
                Console.WriteLine("\n2. Cadastrar paciente prioritário");
                Console.WriteLine("\n3. Listar pacientes");
                Console.WriteLine("\n4. Sair");
                Console.WriteLine("\nEscolha uma opção");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.Write("Nome paciente:\n");
                    string nome = Console.ReadLine();
                    Console.Write("Idade:\n");
                    int idade = int.Parse(Console.ReadLine());

                    Paciente p = new Paciente(nome, idade);
                    fila.AdicionarPaciente(p);
                }
                else if (opcao == 2)
                {
                    Console.Write("Nome do paciente:\n");
                    string nome = Console.ReadLine();
                    Console.Write("Idade:\n");
                    int idade = int.Parse(Console.ReadLine());

                    Paciente p = new PacientePrioritario(nome, idade);
                    fila.AdicionarPacientePrioritario(p);
                }
                else if (opcao == 3)
                {
                    fila.ListarPaciente();
                }
            } while (opcao != 4);
            


                }
            }
}
