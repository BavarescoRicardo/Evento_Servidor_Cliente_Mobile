using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival.or
{
    public class Apresentacao
    {
        public Apresentacao()
        {

        }

        public Apresentacao(int id_apresentacao, string musica, string artista, Cantor cantor, Categoria categoria)
        {
            this.id_apresentacao = id_apresentacao;
            this.musica = musica;
            this.fk_cantor = cantor;
            this.fk_categoria = categoria;
        }

        public virtual int id_apresentacao { get; set; }
        public virtual string musica { get; set; }
        public virtual string artista { get; set; }
        public virtual Cantor fk_cantor { get; set; }
        public virtual Categoria fk_categoria { get; set; }
    }
}
