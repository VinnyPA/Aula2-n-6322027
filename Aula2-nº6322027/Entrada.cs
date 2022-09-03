using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_nº6322027
{
    internal class Entrada
    {
        double valor;
        string poltrona;
        string data;
        string hora;

        public void setValor(double valor)
        {
            this.valor = valor;
        }
        public double getValor()
        {
            return this.valor;
        }
        public void setPoltrona(string poltrona)
        {
            this.poltrona = poltrona;
        }
        public string getPoltrona()
        {
            return this.poltrona;
        }
        public void setData(string data)
        {
            this.data = data;
        }
        public string getData()
        {
            return this.data;
        }
        public void setHora(string hora)
        {
            this.hora = hora;
        }
        public string getHora()
        {
            return this.hora;
        }

    }
}
