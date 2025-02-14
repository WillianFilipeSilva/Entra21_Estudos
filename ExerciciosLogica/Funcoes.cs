using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExerciciosCSharp.ExerciciosLogica
{
    public class Funcoes : Base
    {
        public override void Executar()
        {
            try
            {
                lista = new Dictionary<int, (string, Action)>
                {
                    { 1, ("Soma de Dois Números", Exercicio1) },
                    { 2, ("Fatorial de um Número", Exercicio2) },
                    { 3, ("Verificar Número Primo", Exercicio3) },
                    { 4, ("Maior Valor da Lista", Exercicio4) },
                    { 5, ("Inverter String", Exercicio5) },
                    { 6, ("Média de uma Lista de Números", Exercicio6) },
                    { 7, ("Verificar Palíndromo", Exercicio7) },
                    { 8, ("Converter Celsius para Fahrenheit", Exercicio8) },
                    { 9, ("Contar Strings com Mais de 5 Caracteres", Exercicio9) },
                    { 10, ("Máximo Divisor Comum (MDC)", Exercicio10) },
                    { 11, ("Lista de Números Pares", Exercicio11) },
                    { 12, ("Contagem de Elementos na Lista", Exercicio12) },
                    { 13, ("Alternar Maiúsculas e Minúsculas", Exercicio13) },
                    { 14, ("Série de Fibonacci", Exercicio14) },
                    { 15, ("Verificar Número Positivo, Negativo ou Zero", Exercicio15) },
                    { 16, ("Calculadora Simples", Exercicio16) },
                    { 17, ("Verificação de Número Primo", Exercicio17) },
                    { 18, ("Sequência de Fibonacci", Exercicio18) },
                    { 19, ("Contagem de Dígitos", Exercicio19) },
                    { 20, ("Média de Três Números", Exercicio20) }
                };

                Menu(lista);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro na execução do menu: {ex.Message}");
            }
        }

        //1. Crie uma função que recebe dois números inteiros como parâmetros e retorna a sua soma.
        public override void Exercicio1() { }

        //2. Escreva uma função que calcule o fatorial de um número inteiro passado como argumento.
        public override void Exercicio2() { }

        //3. Desenvolva uma função que verifique se um número é primo ou não.
        public override void Exercicio3() { }

        //4. Implemente uma função que receba uma lista de inteiros e retorne o maior valor presente na lista.
        public override void Exercicio4() { }

        //5. Crie uma função que inverta uma string passada como parâmetro (sem usar funções de inversão embutidas).
        public override void Exercicio5() { }

        //6. Escreva uma função que calcule a média de uma lista de números reais.
        public override void Exercicio6() { }

        //7. Desenvolva uma função que verifique se uma string é um palíndromo(ela lê o mesmo de trás para frente) ou não.
        public override void Exercicio7() { }

        //8. Implemente uma função que receba um valor em graus Celsius e retorne o equivalente em Fahrenheit.
        public override void Exercicio8() { }

        //9. Crie uma função que receba um array de strings e retorne a quantidade de strings que possuem mais de 5 caracteres.
        public override void Exercicio9() { }

        //10. Escreva uma função que calcule o máximo divisor comum (MDC) entre dois números inteiros.
        public override void Exercicio10() { }

        //11. Desenvolva uma função que receba uma lista de inteiros e retorne uma nova lista com os números pares.
        public override void Exercicio11() { }

        //12. Implemente uma função que conte quantas vezes um determinado elemento aparece em uma lista.
        public override void Exercicio12() { }

        //13. Crie uma função que receba uma string e retorne outra string com todas as letras maiúsculas convertidas para minúsculas e vice-versa.
        public override void Exercicio13() { }

        //14. Escreva uma função que calcule o valor da série de Fibonacci para um dado número de termos.
        public override void Exercicio14() { }

        //15. Desenvolva uma função que determine se um número é positivo, negativo ou zero.
        public override void Exercicio15() { }

        //16: Calculadora Simples - Crie uma função chamada Calculadora que recebe dois números e um operador (+, -, *, /) como parâmetros e retorna o resultado da operação.
        public override void Exercicio16() { }

        //17: Verificação de Número Primo - Escreva uma função chamada Primo que recebe um número inteiro como parâmetro e retorna true se o número for primo e false caso contrário.
        public override void Exercicio17() { }

        //18: Sequência de Fibonacci - Implemente uma função chamada Fibonacci que recebe um número inteiro n como parâmetro e retorna uma lista contendo os primeiros n números da sequência de Fibonacci.
        public override void Exercicio18() { }

        //19: Contagem de Dígitos - Crie uma função chamada ContarDigitos que recebe um número inteiro como parâmetro e retorna o número de dígitos no número.
        public override void Exercicio19() { }

        //20: Média de Números - Desenvolva uma função chamada CalcularMedia que recebe 3 números e retorna a média dos itens.
        public override void Exercicio20() { }
    }
}