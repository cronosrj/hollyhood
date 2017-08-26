using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Hollywood.Dominio {
    class Artista : IComparable {
        public int cod { get; set; }
        public string nome { get; set; }
        public double cache { get; set; }
     
         public Artista(int cod, string nome, double cache) {
            this.cod = cod;
            this.nome = nome;
            this.cache = cache;
         }
        public override string ToString() {
            return cod
                + ", "
                + nome
                + ", Cachê: "
                + cache.ToString("F2", CultureInfo.InvariantCulture);
        }
        public int CompareTo(object obj) {
            Artista outro = (Artista)obj;
            return nome.CompareTo(outro.nome);
        }

    }
}
