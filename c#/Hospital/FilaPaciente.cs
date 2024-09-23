using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class FilaPaciente
    {
        private Paciente[] fila;
        private int tamanho;

        public FilaPaciente()
        {
            fila = new Paciente[10];
            tamanho = 0;
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
        public void AdicionarPacientePrioritario(Paciente p)
        {
            if (tamanho == 10)
            {
                Console.WriteLine("\nFila cheia! Não é possível adicionar mais pacientes.\n");
                return;
            }
            for (int i = tamanho; i > 0; i--)
            {
                fila[i] = fila[i - 1];
            }

            fila[0] = p;
            tamanho++;
            Console.WriteLine($"\nPaciente prioritário {p.Nome} foi adicionado à frente da fila.\n");
        }
        public void ListarPaciente()
        {
            if (tamanho == 10)
            {
                Console.WriteLine("\nA fila está vazia.");
                return;
            }
            Console.WriteLine("\nLista de pacientes na fila:");
            for (int i = 0; i < tamanho; i++)
            {
                fila[i].ExibirInfo();
            }
        }

       
    }
}
