using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_nº6322027
{
    internal class Filme
    {
        string titulo;
        string sinopse;
        string genero;
        double classificacao;

        public void setTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public string getTitulo()
        {
            return this.titulo;
        }
        public void setSinopse(string sinopse)
        {
            this.sinopse = sinopse;
        }
        public string getSinopse()
        {
            return this.sinopse;
        }
        public void setGenero(string genero)
        {
            this.genero = genero;
        }
        public string getGenero()
        {
            return this.genero;
        }
        public void setClassificacao(double classificacao)
        {
            this.classificacao = classificacao;
        }
        public double getClassificacao()
        {
            return this.classificacao;
        }
    }
}
