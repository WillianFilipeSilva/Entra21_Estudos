namespace ExerciciosCSharp.ExerciciosLogica
{
    public class Recursividade : Base
    {
        public override void Executar()
        {
            try
            {
                lista = new Dictionary<int, (string, Action)>
                {
                    { 1, ("Potência", Exercicio1) },
                    { 2, ("Soma de Números Inteiros", Exercicio2) },
                    { 3, ("Fibonacci", Exercicio3) },
                    { 4, ("Contagem Regressiva", Exercicio4) },
                    { 5, ("Máximo Divisor Comum (MDC)", Exercicio5) }
                };

                Menu(lista);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro na execução do menu: {ex.Message}");
            }
        }

        //Exercício 1: Potência
        //Implemente uma função recursiva chamada Potencia que recebe dois parâmetros base e expoente e calcula a potência de base elevado a expoente.
        public override void Exercicio1() { }

        //Exercício 2: Soma de Números Inteiros
        //Crie uma função recursiva chamada Soma que recebe um número inteiro positivo n como parâmetro e retorna a soma de todos os números inteiros de 1 até n.
        public override void Exercicio2() { }

        //Exercício 3: Fibonacci
        //Desenvolva uma função recursiva chamada Fibonacci que recebe um número inteiro n como parâmetro e retorna o n-ésimo termo da sequência de Fibonacci.
        public override void Exercicio3() { }

        //Exercício 4: Contagem Regressiva
        //Escreva uma função recursiva chamada ContagemRegressiva que recebe um número inteiro positivo n como parâmetro e exibe uma contagem regressiva de n até 1.
        public override void Exercicio4() { }

        //Exercício 5: Máximo Divisor Comum (MDC)
        //Crie uma função recursiva chamada MDC que recebe dois números inteiros positivos a e b como parâmetros e retorna o máximo divisor comum entre eles.
        public override void Exercicio5() { }
    }
}