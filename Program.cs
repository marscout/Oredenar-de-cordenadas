using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ExceptionServices;


namespace OdenarDados
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            
            Dados dados = new Dados();
            List<Dados> OrdemDados = new List<Dados>();
            do
            {
                Console.Write("Entre com os dados: (X, Y) ");
                dados.X = int.Parse(Console.ReadLine());

                dados.Y = int.Parse(Console.ReadLine());
                string dadosJuntos = Dados.JuntarDados(dados.X, dados.Y);
                Dados.ListarDados(dadosJuntos,OrdemDados);
                Dados.ExibirLista(OrdemDados);
            } while (i == 0);
            Console.ReadKey();
        }
    }
}
