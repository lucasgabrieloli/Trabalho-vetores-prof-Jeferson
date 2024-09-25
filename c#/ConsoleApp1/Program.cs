using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FilaPaciente fila = new FilaPaciente();
            string opcao;

            do
            {
                Console.WriteLine("\n\tMenu:");
                Console.WriteLine("\nDigite 'A' para Cadastrar Paciente");
                Console.WriteLine("\nDigite 'B' para Cadastrar paciente prioritário");
                Console.WriteLine("\nDigite 'C' para Listar pacientes na fila");
                Console.WriteLine("\nDigite 'D' para atender o próximo paciente(prioritários têm preferência)");
                Console.WriteLine("\nDigite 'Q' para sair do programa");
                Console.WriteLine("\nEscolha uma opção");
                opcao = Console.ReadLine();

                if (opcao == "a" || opcao == "A")
                {
                    Console.Write("\nNome paciente:");
                    string nome = Console.ReadLine();
                    Console.Write("\nIdade:");
                    int idade = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nCPF:");
                    string CPF = Console.ReadLine();
                    Console.WriteLine("\nTelefone:");
                    string telefone = Console.ReadLine();
                    string genero;
                    do
                    {
                        Console.WriteLine("\nGênero (Digite 'M' para 'masculino', 'F' para 'feminino' e 'P' para 'Prefiro não dizer'):");
                        genero = Console.ReadLine().ToUpper();
                    } while (genero != "M" && genero != "P" && genero != "F");


                    Paciente p = new Paciente(nome, idade, CPF, telefone, genero);
                    fila.AdicionarPaciente(p);
                }
                else if (opcao == "b" || opcao == "B")
                {
                    Console.Write("\nNome do paciente:");
                    string nome = Console.ReadLine();
                    Console.Write("\nIdade:");
                    int idade = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nCPF:");
                    string CPF = Console.ReadLine();
                    Console.WriteLine("\nTelefone:");
                    string telefone = Console.ReadLine();
                    string genero;
                    do
                    {
                        Console.WriteLine("\nGênero (Digite 'M' para 'masculino', 'F' para 'feminino' e 'P' para 'Prefiro não dizer'):");
                        genero = Console.ReadLine().ToUpper();
                    }
                    while (genero != "M" && genero != "F" && genero != "P");


                    PacientePrioritario pp = new PacientePrioritario(nome, idade, CPF, telefone, genero);
                    fila.AdicionarPacientePrioritario(pp);
                }


                else if (opcao == "c" || opcao == "C")
                {
                    fila.ListarPaciente();
                }
                else if (opcao == "d" || opcao == "D") {
                    if (fila.tamanhopp > 0)
                    {
                        fila.atenderPacientesPrioritarios();
                    }
                    else
                    {
                        fila.atenderPacientes();
                    }
                }




            }while (opcao != "q" || opcao != "Q");

            Console.ReadKey();
        }
    }
}
