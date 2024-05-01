using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamica
{
    internal class Livro
    {
        string titulo;
        Livro anterior;

        public Livro(string titulo)
        {
            this.titulo = titulo;
            anterior = null;
        }

        public string getTitulo()
        {
            return titulo;
        }

        public void setAnterior(Livro anterior)
        {
            this.anterior = anterior;
        }

        public Livro getAnterior()
        {
            return anterior;
        }

        public override string? ToString()
        {
            return $"\nTitulo: {titulo}";
        }
    }
}
