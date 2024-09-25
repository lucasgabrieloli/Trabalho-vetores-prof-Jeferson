using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class FilaPaciente
    {
        private Paciente[] fila;
        private PacientePrioritario[] filapp;
        public int tamanho;
        public int tamanhopp; 

        public FilaPaciente()
        {
            filapp = new PacientePrioritario[10];
            fila = new Paciente[10];
            tamanho = 0;
            tamanhopp = 0; 
        }

        public void AdicionarPaciente(Paciente p)
        {
            if (tamanho == 10)
            {
                Console.WriteLine("\nFila cheia, não é possivel adicionar mais pacientes.\n");
                return;
            }
            for (int i = tamanho; i > 0; i--)
            {
                fila[i] = fila[i - 1];
            }

            fila[0] = p;
            tamanho++;
            Console.WriteLine($"\nPaciente {p.Nome} foi adicionado à fila.\n");
        }
        public void AdicionarPacientePrioritario(PacientePrioritario pp)
        {
            if (tamanhopp == 10)
            {
                Console.WriteLine("\nFila cheia! Não é possível adicionar mais pacientes.\n");
                return;
            }
            for (int i = tamanhopp; i > 0; i--)
            {
                filapp[i] = filapp[i - 1];
            }

            filapp[0] = pp;
            tamanhopp++;
            Console.WriteLine($"\nPaciente prioritário {pp.Nome} foi adicionado à frente da fila.\n");
        }
        public void ListarPaciente()
        {
            if (tamanho == 10 && tamanhopp == 10)
            {
                Console.WriteLine("\nA fila está vazia.");
                return;
            }
            Console.WriteLine("\nLista de pacientes na fila:\n");
            for (int i = 0; i < tamanhopp; i++)
            {
                filapp[i].ExibirInfo();
            }
            for (int i = 0; i < tamanho; i++) 
            {
                fila[i].ExibirInfo();
            }
        }

        public void atenderPacientes()
        {

            Console.WriteLine($"\nAtendendo paciente: {fila[0].Nome}\n");

            for (int i = 0; i < tamanho - 1; i++) {

                fila[i] = fila[i + 1];
            }

            tamanho--;

            fila[tamanho] = null;
        } 

        public void atenderPacientesPrioritarios() {

            if (tamanhopp == 0)
            {
                Console.WriteLine("\nA fila está vazia! Não há pacientes prioritários para atender.\n");
            }

            Console.WriteLine($"\nAtendendo paciente prioritário: {filapp[0].Nome}\n");

            for (int i = 0; i<tamanhopp-1;i++)
            {

                filapp[i] = filapp[i + 1];
            }
            
            tamanhopp--;

            filapp[tamanhopp] = null;

        }


    }
}
