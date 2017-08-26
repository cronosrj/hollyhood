using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hollywood.Dominio;

namespace Hollywood {
    class Program {

        //Iniciado projeto no GitHub

        public static List<Artista> artista = new List<Artista>();
        public static List<Filme> filme = new List<Filme>();

        static void Main(string[] args) {

            artista.Add(new Artista(101, "Scarlett Johansson", 4000000.00));
            artista.Add(new Artista(102, "Chris Evans", 2500000.00));
            artista.Add(new Artista(101, "Robert Downey Jr.", 3000000.00));
            artista.Add(new Artista(101, "Scarlett Johansson", 4000000.00));
            artista.Sort();

            int opcao = 0;

            while (opcao != 5) {
                Console.Clear();
                Tela.mostrarMenu();
                try {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception e) {
                    Console.WriteLine("Erro inesperado: " + e.Message);
                    opcao = 0;
                }
                Console.WriteLine();

                switch (opcao) {
                    case 1:
                        Tela.listaArtistas();
                        break;

                    case 2:
                        try {
                            Tela.cadastraArtista();
                        }
                        catch (Exception e) {
                        Console.WriteLine("Erro de negócio: " + e.Message);
                        }
                       break;

                    case 3:
                        try {
                            Tela.cadastraFilme();
                        }
                        catch (Exception e) {
                            Console.WriteLine("Erro de negócio: " + e.Message);
                        }
                        break;

                    case 4:
                        try {
                            Tela.mostrarFilme();
                        }
                        catch (Exception e) {
                            Console.WriteLine("Erro de negócio: " + e.Message);
                        }
                        break;

                    case 5:
                        Console.WriteLine("Fim do programa!");
                        break;
                }
                Console.ReadLine();
            }
            
        }
    }
}
