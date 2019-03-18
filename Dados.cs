using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace OdenarDados
{
    class Dados
    {
        public int X, Y;
        double Uniao;


        public static string JuntarDados(int X1, int Y1)
        {
            string UniaoString = Convert.ToString(X1) + '.' + Convert.ToString(Y1);


            return UniaoString;

        }

        public static void ListarDados(string Uniao, List<Dados> OrdemDados)
        {
            Dados dados = new Dados();
            int indexPonto;
            string valorX, valorY;
            int  indexY;

            indexPonto = Uniao.IndexOf('.');
            indexY = Uniao.Length - indexPonto;
            valorX = Uniao.Substring(0, indexPonto);
            valorY = Uniao.Substring(indexPonto + 1);


            
            dados.X = Convert.ToInt32(valorX);
            dados.Y = Convert.ToInt32(valorY);

            int YSemsinal = Math.Abs(Convert.ToInt32(valorY));

            Uniao = valorX + "." + Convert.ToString(YSemsinal);

            double DadoParaInserir = Convert.ToDouble(Uniao);

            if (OrdemDados.Count == 0)
            {

                dados.Uniao = DadoParaInserir;
                OrdemDados.Add(dados);
            }
            else
            {


                for (int i = 1; i <= OrdemDados.Count; i++)
                {
                    int? indice = FindIdex(OrdemDados, DadoParaInserir);
                    if (!indice.HasValue)
                    {

                        OrdemDados.Add(dados);
                        break;
                    }
                    else

                        OrdemDados.Insert(indice.Value, dados);
                    break;

                }
            }
        }

        public static void ExibirLista(List<Dados> OrdemDados)
        {
            Console.WriteLine("(X, Y)");
            foreach (Dados a in OrdemDados)
            {
                Console.WriteLine($"({a.X}, {a.Y})");
            }
        }
        public static int? FindIdex(List<Dados> OrdemDados, double DadoParaInserir)
        {
            int? indice = null;
            for (int i = 1; i <= OrdemDados.Count; i++)
            {
                if (OrdemDados.Count == 0) return indice;
                else if (OrdemDados[i - 1].Uniao >= DadoParaInserir)
                {
                    indice = i - 1;
                    return indice;
                }
                else indice = i;

            }
            return indice;
        }
    }
}
