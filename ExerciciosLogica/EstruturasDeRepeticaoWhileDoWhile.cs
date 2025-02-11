namespace ExerciciosCSharp.ExerciciosLogica
{
    public class EstruturasDeRepeticaoWhileDoWhile : Base
    {
        public void Executar()
        {
           var lista = new Dictionary<int, (string, Action)>
            {
                { 1, ("Contagem Crescente", Exercicio1) },
                { 2, ("Adivinhe o Número", Exercicio2) },
                { 3, ("Calculadora Simples", Exercicio3) },
                { 4, ("Soma de Números", Exercicio4) },
                { 5, ("Fatorial", Exercicio5) },
                { 6, ("Tabela de Multiplicação", Exercicio6) },
                { 7, ("Média de Notas", Exercicio7) },
                { 8, ("Contagem Regressiva", Exercicio8) },
                { 9, ("Soma dos Dígitos", Exercicio9) },
                { 10, ("Adivinhe o Número (Do While)", Exercicio10) }
            };

            Menu(lista);
        }

        // Exercício 1 - Contagem Crescente: Imprima os números de 1 a 10 em ordem crescente.
        public override void Exercicio1() 
        {
            Console.WriteLine($"Contando até 10:\n");

            int contador = 1;
            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }
        }

        // Exercício 2 - Adivinhe o Número: Gere um número aleatório e peça ao usuário para adivinhar até acertar.
        public override void Exercicio2() 
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 100);

            List<int> numerosUsuario = new List<int>();

            Console.WriteLine("Advinhe o numero de 1 a 100");
            int numeroUsuario = int.Parse(Console.ReadLine());

            while (numeroUsuario != numeroAleatorio)
            {
                Console.WriteLine($"Numero {numeroUsuario} errado!");

                numerosUsuario.Add(numeroUsuario);

                Console.Write("Numeros que voce ja tentou:");
                foreach (var numero in numerosUsuario) Console.Write($" {numero}");

                Console.WriteLine("\nDigite outro numero");
                numeroUsuario = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Acertou!\n O numero era: {numeroAleatorio}");
        }

        // Exercício 3 - Calculadora Simples: Peça dois números e uma operação (+, -, *, /) e exiba o resultado.
        public override void Exercicio3() 
        {
            Console.WriteLine("Iniciando Calculadora");

            int opção = 1;
            while (opção != 0)
            {
                Console.Write("Digite o primeiro número: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                Console.Write("Digite o operador (+, -, *, /): ");
                char operador = Console.ReadLine()[0];

                double resultado = 0;
                bool valido = true;

                switch (operador)
                {
                    case '+':
                        resultado = num1 + num2;
                        break;
                    case '-':
                        resultado = num1 - num2;
                        break;
                    case '*':
                        resultado = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                            resultado = num1 / num2;
                        else
                        {
                            Console.WriteLine("Divisão por zero não é permitida.");
                            valido = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Operador inválido.");
                        valido = false;
                        break;
                }
                if (valido)
                    Console.WriteLine("Resultado: " + resultado);

                Console.WriteLine("Digite 0 para parar a calculadora");
                opção = int.Parse(Console.ReadLine());
            }
        }

        // Exercício 4 - Soma de Números: Some uma sequência de números informados pelo usuário até que ele digite 0.
        public override void Exercicio4() 
        {
            Console.WriteLine("Vamos somar os proximos numeros, digite 0 para parar a inserção");

            var numero = 1;
            var soma = 0;

            while(numero != 0){
                numero = int.Parse(Console.ReadLine());
                soma += numero;
            }
            Console.WriteLine($"A soma dos numeros é: {soma}");
        }

        // Exercício 5 - Fatorial: Calcule e exiba o fatorial de um número informado pelo usuário.
        public override void Exercicio5() { }

        // Exercício 6 - Tabela de Multiplicação: Exiba a tabuada de um número informado pelo usuário.
        public override void Exercicio6() { }

        // Exercício 7 - Média de Notas: Peça várias notas e calcule a média, parando quando o usuário digitar -1.
        public override void Exercicio7() { }

        // Exercício 8 - Contagem Regressiva: Imprima uma contagem regressiva a partir de um número informado.
        public override void Exercicio8() { }

        // Exercício 9 - Soma dos Dígitos: Some os dígitos de um número informado pelo usuário.
        public override void Exercicio9() { }

        // Exercício 10 - Adivinhe o Número (Do While): Versão do Exercício 2 usando um loop `do while`.
        public override void Exercicio10() { }
    }
}