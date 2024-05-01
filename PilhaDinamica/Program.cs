namespace PilhaDinamica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PilhaLivro minhaPilha = new PilhaLivro();

            menu(minhaPilha);
            
        }


        static void menu(PilhaLivro pilha)
        {
            int op;

            do
            {
                Console.Clear();
                
                Console.WriteLine("Pilha de livros:");
                Console.WriteLine("1 - Inserir Livro");
                Console.WriteLine("2 - Remover Livro");
                Console.WriteLine("3 - Imprimir pilha");
                Console.WriteLine("4 - Buscar por titulo");
                Console.WriteLine("5 - Ver tamanho da pilha");
                Console.WriteLine("6 - Sair");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        cadastrarLivro(pilha);
                        break;
                    case 2:
                        removerLivro(pilha);
                        break;
                    case 3:
                        pilha.print();
                        Console.ReadKey();
                        break;
                    case 4:
                        buscarLivro(pilha);
                        break;
                    case 5:
                        Console.WriteLine($"\nQuantidade de livros na pilha: {pilha.getQtdLivros()}");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (op != 6);
        }

        static void cadastrarLivro(PilhaLivro p)
        {
            Console.WriteLine("\nDigite o título do livro:");
            p.push(new Livro(Console.ReadLine()));

            Console.WriteLine("\nLivro adicionado com sucesso!");
            Console.ReadKey();
        }

        static void removerLivro(PilhaLivro p)
        {
            if (p.pop())
            {
                Console.WriteLine("\nLivro removido com sucesso!");
            }
            else
            {
                Console.WriteLine("\n**Pilha vazia!**");
            }
            Console.ReadKey();
        }

        static void buscarLivro(PilhaLivro p)
        {
            if (!p.isEmpty())
            {
                Console.WriteLine("\nDigite o titulo do livro a ser buscado:");
                p.buscarLivro(Console.ReadLine());
            }
            else
                Console.WriteLine("\n**Pilha Vazia!**");

            Console.ReadKey();
        }
    }
}
