using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciciosCSharp.ExerciciosLogica;

namespace ExerciciosCSharp
{
    public class Teste
    {
        public static void Main(string[] args)
        {
            //Variáveis
            Variaveis variaveis = new();
            //variaveis.Executar();

            //EstruturasDeSelecao
            EstruturasDeSelecao estruturasDeSelecao = new();
            //estruturasDeSelecao.Executar();

            //Exercicios de repetição
            EstrurutasDeRepeticaoFor repeticao = new();
            //repeticao.Executar();

           //Estruturas de Repetição
           EstruturasDeRepeticaoWhileDoWhile estruturasDeRepeticao = new();
            estruturasDeRepeticao.Executar();
        }
    }
}
