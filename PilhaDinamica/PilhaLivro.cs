using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamica
{
    internal class PilhaLivro
    {
        Livro topo;
        int qtdLivros;

        public PilhaLivro()
        {
            topo = null;
            qtdLivros = 0;
        }

        public int getQtdLivros()
        {
            return qtdLivros;
        }

        public void push(Livro aux)
        {
            if(isEmpty())
            {
                topo = aux;
            }else
            {
                aux.setAnterior(topo);
                topo = aux;
            }
            qtdLivros++;
        }

        public bool pop()
        {
            if(!isEmpty())
            {
                topo = topo.getAnterior();
                qtdLivros--;
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool isEmpty()
        {
            return topo == null;
        }

        public void print()
        {
            Livro aux = topo;

            if(!isEmpty())
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.getAnterior();
                } while (aux != null);
            }
            else
            {
                Console.WriteLine("\n**Pilha vazia!**");
            }
        }

        public void buscarLivro(string titulo)
        {
            Livro aux = topo;
            bool encontrou = false;

            if (!isEmpty())
            {
                do
                {
                    if(aux.getTitulo() == titulo)
                    {
                        Console.WriteLine(aux.ToString());
                        encontrou = true;
                    }

                    aux = aux.getAnterior();
                } while (aux != null);

                if (!encontrou)
                {
                    Console.WriteLine("\n**Livro não encontrado!**");
                }
            }
            else
            {
                Console.WriteLine("\n**Pilha vazia!**");
            }
        }
    }
}
