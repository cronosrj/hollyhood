using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Hollywood.Dominio {
    class Participacao {
        public Filme filme { get; set; }
        public Artista artista { get; set; }
        public double desconto { get; set; }


        public Participacao(Artista artista, Filme filme, double desconto) {
            this.artista = artista;
            this.filme = filme;
            this.desconto = desconto;
        }

        public double calcDesconto() {
            return artista.cache - desconto; 
        }
        public override string ToString() {
            return artista.nome
                + ", Cachê: "
                + artista.cache
                + ", Desconto: "
                + desconto.ToString("F2", CultureInfo.InvariantCulture)
                + ", Custo: "
                + calcDesconto().ToString("F2", CultureInfo.InvariantCulture);
        }


    }

    
    
}
