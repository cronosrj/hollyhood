using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Hollywood.Dominio {
    class Filme {
        public int cod { get; set; }
        public string titulo { get; set; }
        public int ano { get; set; }
        public List<Participacao> participacoes { get; set; }


        public Filme(int cod, string titulo, int ano) {
            this.cod = cod;
            this.titulo = titulo;
            this.ano = ano;
            participacoes = new List<Participacao>();
        }

        public double custoTotal() {
            double soma = 0.0;
            for (int i = 0; i < participacoes.Count; i++) {
                soma = soma + participacoes[i].calcDesconto();
            }
            return soma;
        }
        public override string ToString() {
            String s = "Filme " + cod
                + ", Título: " + titulo
                + ", Ano: " + ano + "\n"
                + "Participações:\n";
            for (int i = 0; i < participacoes.Count; i++) {
                s = s + participacoes[i] + "\n";
            }
            s = s + "Custo total do filme: " + custoTotal().ToString("F2", CultureInfo.InvariantCulture);
            return s;

        }
    }
}