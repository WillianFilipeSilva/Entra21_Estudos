﻿using ExerciciosCSharp.ExerciciosLogica;

namespace ExerciciosCSharp
{
    public class Teste
    {
        public static void Main(string[] args)
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
                vetoresEListas.Executar();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERRO: {ex.Message}");
            }
        }
    }
}