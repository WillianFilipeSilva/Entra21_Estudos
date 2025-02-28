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
        public override void Exercicio1() 
        {
            try
            {
                Console.WriteLine("Vamos calcular uma Potência\n");

                Console.Write("Digite a base: ");
                int baseNum = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o expoente: ");
                int expoente = int.Parse(Console.ReadLine());

                Console.WriteLine($"A potência de {baseNum} elevado a {expoente} é: {Potencia(baseNum, expoente)}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao executar o exercício 1: {ex.Message}");
            }
        }

        public int Potencia(int baseNum, int expoente)
        {
            if (expoente == 0)
                return 1;

            int potencia = baseNum * Potencia(baseNum, expoente -1);
            return potencia;
        }

        //Exercício 2: Soma de Números Inteiros
        //Crie uma função recursiva chamada Soma que recebe um número inteiro positivo n como parâmetro e retorna a soma de todos os números inteiros de 1 até n.
        public override void Exercicio2() 
        {
            Console.WriteLine("Vamos calcular a soma de todos os numeros até seu numero\n");

            Console.WriteLine("Digite o seu numero: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"A soma dos seus numeros é: {Soma(numero)}");
        }

        public int Soma(int numero)
        {
            if(numero == 0)
                return 0;

            var soma = Soma(numero - 1) + numero;
            return soma;
        }

        //Exercício 3: Fibonacci
        //Desenvolva uma função recursiva chamada Fibonacci que recebe um número inteiro n como parâmetro e retorna o n-ésimo termo da sequência de Fibonacci.
        public override void Exercicio3() 
        {
            Console.WriteLine("Vamos calcular o Fibonacci da posição que voce passar\n");

            Console.WriteLine("Digite o seu numero: ");
            int numero = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"O seu numero na sequencia de fibonacci é: {Fibonacci(numero)}");
        }

        public int Fibonacci(int n) 
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        //Exercício 4: Contagem Regressiva
        //Escreva uma função recursiva chamada ContagemRegressiva que recebe um número inteiro positivo n como parâmetro e exibe uma contagem regressiva de n até 1.
        public override void Exercicio4() 
        {
            Console.WriteLine($"Vamos fazer uma contagem regressiva até seu numero\n");
            Console.WriteLine("Digite o seu numero: ");

            int numero = int.Parse(Console.ReadLine());

            ContagemRegressiva(numero);
        }

        public void ContagemRegressiva(int n)
        {
            if (n > 0)
            {
                Console.WriteLine(n);
                ContagemRegressiva(n - 1);
            }
        }

        //Exercício 5: Máximo Divisor Comum (MDC)
        //Crie uma função recursiva chamada MDC que recebe dois números inteiros positivos a e b como parâmetros e retorna o máximo divisor comum entre eles.
        public override void Exercicio5()
        {
            Console.WriteLine($"Vamos calcular o minimo divisor comum\n");

            Console.WriteLine("Digite o primeiro numero: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"O MDC de {numero1} e {numero2} é: {MDC(numero1, numero2)}");
        }

        public int MDC(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return MDC(b, a % b);
        }
    }
}