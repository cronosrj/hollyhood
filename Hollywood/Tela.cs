using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Hollywood.Dominio;

namespace Hollywood {
    class Tela {
        public static void mostrarMenu() {
            Console.WriteLine("1 - Listar artistas ordenadamente");
            Console.WriteLine("2 - Cadastrar artista");
            Console.WriteLine("3 - Cadastrar filme");
            Console.WriteLine("4 - Mostrar dados de um filme");
            Console.WriteLine("5 - Sair");
            Console.Write("Digite uma opção: ");
        }


        public static void listaArtistas() {
            Console.WriteLine("Listagem de artistas:");
            for (int i = 0; i < Program.artista.Count; i++) {
                Console.WriteLine(Program.artista[i]);
            }
            Console.WriteLine();
        }


        public static void cadastraArtista() {
            Console.WriteLine("Digite os dados do artista: ");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Valor do cache: ");
            double cache = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Artista x = new Artista(codigo, nome, cache);
            Program.artista.Add(x);
        }
        public static void cadastraFilme() {
            Console.WriteLine("Digite os dados do Filme: ");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Título: ");
            string titulo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Filme novoFilme = new Filme(codigo, titulo, ano);

            Console.Write("Quantas participações? ");
            int participacoes = int.Parse(Console.ReadLine());
            for (int i = 1; i <= participacoes; i++) {
                Console.WriteLine("Digite os dados da" + i + "º" + "participação:");
                Console.Write("Artista (código): ");
                int codartista = int.Parse(Console.ReadLine());
                int pos = Program.artista.FindIndex(x => x.cod == codartista);
                if (pos == -1) {
                    throw new Exception("Código do produto não encontrado: " + codartista);
                }
                Console.Write("Desconto: ");
                double desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Participacao filme = new Participacao(Program.artista[pos], novoFilme, desconto);
                novoFilme.participacoes.Add(filme);
            }
            Program.filme.Add(novoFilme);

        }
        public static void mostrarFilme() {
            Console.Write("Digite o código do filme: ");
            int codFilme = int.Parse(Console.ReadLine());
            int pos = Program.filme.FindIndex(x => x.cod == codFilme);
            if (pos == -1) {
                throw new Exception("Código de filme não encontrado: " + codFilme);
            }
            Console.WriteLine(Program.filme[pos]);
            Console.WriteLine();

        }

    }
}

