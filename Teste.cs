using ExerciciosCSharp.ExerciciosLogica;
using ExerciciosCSharp.ExerciciosPOO.Principal;

namespace ExerciciosCSharp
{
    public class Teste
    {
        public static void Main()
        {
            try
            {
                //Variáveis
                Variaveis variaveis = new();
                //variaveis.Executar();

                //EstruturasDeSelecao
                EstruturasDeSelecao estruturasDeSelecao = new();
                //estruturasDeSelecao.Executar();

                //Exercicios de repetição
                EstrurutasDeRepeticaoFor estrurutasDeRepeticaoFor = new();
                //estrurutasDeRepeticaoFor.Executar();

                //Estruturas de Repetição
                EstruturasDeRepeticaoWhileDoWhile estruturasDeRepeticaoWhileDoWhile = new();
                //estruturasDeRepeticaoWhileDoWhile.Executar();

                //Funções
                Funcoes funcoes = new();
                //funcoes.Executar();

                //Vetores e Listas
                VetoresEListas vetoresEListas = new();
                //vetoresEListas.Executar();

                //Exercicios de Matrizes
                Matrizes matrizes = new();
                //matrizes.Executar();

                //Exercicios de Funções
                Recursividade recursividade = new();
                //recursividade.Executar();

                //---------------------------\\

                //ExerciciosPOO
                Lanchonete lanchonete = new();
                lanchonete.Executar();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Houve um erro na excecução: {e.Message}");
            }
        }
    }
}