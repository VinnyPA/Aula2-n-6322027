using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_nº6322027
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filme fl = new Filme();
            Entrada ent = new Entrada();


            Console.Write("Digite o nome do filme: ");
            fl.setTitulo(Console.ReadLine());
            Console.Write("Digite a Sinopse do filme: ");
            fl.setSinopse(Console.ReadLine());
            Console.Write("Digite o genero do filme: ");
            fl.setGenero(Console.ReadLine());
            Console.Write("Digite o classificação indicada para o filme: ");
            fl.setClassificacao(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("==============================================================================================================");


            Console.Write("Digite o valor cobrado do ingresso: R$ ");
            ent.setValor(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Digite a poltrona escolhida: ");
            ent.setPoltrona(Console.ReadLine());
            Console.Write("Digite a data da sessão do filme: ");
            ent.setData(Console.ReadLine());
            Console.Write("Digite a hora da sessão do filme: ");
            ent.setHora(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Seu filme: " + fl.getTitulo() + "\nSinopse: " + fl.getSinopse() + "\nGenero do seu filme: " + fl.getGenero() + "\nA classificação indicada é: " + fl.getClassificacao());

            Console.WriteLine("==============================================================================================================");

            Console.WriteLine("Valor cobrado: " + ent.getValor().ToString("C") + "\nSua poltrona: " + ent.getPoltrona() + "\nData: "  + ent.getData() + "\nHorário: " + ent.getHora());

            Console.ReadKey();

        }
    }
}
