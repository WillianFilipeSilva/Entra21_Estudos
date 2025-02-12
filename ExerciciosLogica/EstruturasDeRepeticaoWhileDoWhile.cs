using System.Diagnostics;

namespace ExerciciosCSharp.ExerciciosLogica
{
    public class EstruturasDeRepeticaoWhileDoWhile : Base
    {
        public void Executar()
        {
            try
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
            catch (Exception ex)
            {
                Console.WriteLine($"Erro na execução do menu: {ex.Message}");
            }
        }

        // Exercício 1 - Contagem Crescente: Imprima os números de 1 a 10 em ordem crescente.
        public override void Exercicio1()
        {
            Console.WriteLine($"Contando até 10:\n");

            try
            {

                int contador = 1;
                while (contador <= 10)
                {
                    Console.WriteLine(contador);
                    contador++;
                }
            } 
            catch (Exception ex)
            {
                throw new Exception($"Erro ao executar o exercício 1: {ex.Message}");
            }
        }

        // Exercício 2 - Adivinhe o Número: Gere um número aleatório e peça ao usuário para adivinhar até acertar.
        public override void Exercicio2() 
        {
            Console.WriteLine("Advinhe o numero de 1 a 100");

            try
            {
                Random random = new Random();
                int numeroAleatorio = random.Next(1, 100);

                List<int> numerosUsuario = new List<int>();

                Console.WriteLine("Digite um numero de 1 a 100");

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
            catch (Exception ex)
            {
                throw new Exception($"Erro ao executar o exercício 2: {ex.Message}");
            }
        }

        // Exercício 3 - Calculadora Simples: Peça dois números e uma operação (+, -, *, /) e exiba o resultado.
        public override void Exercicio3()
        {
            Console.WriteLine("Iniciando Calculadora");

            try
            {
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
            catch (Exception ex)
            {
                throw new Exception($"Erro ao executar o exercício 3: {ex.Message}");
            }
        }

        // Exercício 4 - Soma de Números: Some uma sequência de números informados pelo usuário até que ele digite 0.
        public override void Exercicio4()
        {
            Console.WriteLine("Vamos somar numeros, digite 0 para parar a inserção");

            try
            {
                var numero = 1;
                var soma = 0;

                while (numero != 0)
                {
                    numero = int.Parse(Console.ReadLine());
                    soma += numero;
                }
                Console.WriteLine($"A soma dos numeros é: {soma}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao executar o exercício 4: {ex.Message}");
            }
        }

        // Exercício 5 - Fatorial: Calcule e exiba o fatorial de um número informado pelo usuário.
        public override void Exercicio5()
        {
            Console.WriteLine("Vamos calcular o fatorial de um numero, digite o numero");

            try
            {
                int numero = int.Parse(Console.ReadLine());
                int i = 1;
                var fatorial = i;
                while (i <= numero)
                {
                    fatorial *= i;
                    i++;
                }
                Console.WriteLine($"O fatorial de {numero} é : {fatorial}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao executar o exercício 5: {ex.Message}");
            }
        }

        //Exercicios Do While
        // Exercício 6 - Tabela de Multiplicação: Exiba a tabuada de um número informado pelo usuário.
        public override void Exercicio6() 
        {
            Console.WriteLine($"Digite um numero para exibirmos a tabuada dele");

            try
            {
                int numero = int.Parse(Console.ReadLine());
                int i = 1;
                while (i <= numero)
                {
                    Console.WriteLine($"O {i} numero da tabuada de {numero} é {numero * i}");
                    i++;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao executar o exercício 6: {ex.Message}");
            }
        }

        // Exercício 7 - Média de Notas: Peça várias notas e calcule a média, parando quando o usuário digitar -1.
        public override void Exercicio7()
        {
            Console.WriteLine($"Vamos calcular a media de varias notas");

            try
            {
                Console.WriteLine("Digite a primeira nota");

                int nota = 0;
                int quantidadeNotas = 0;
                int somaNotas = 0;
                while (nota != -1)
                {
                    nota = int.Parse(Console.ReadLine());

                    if(nota < 0 || nota > 10)
                        throw new Exception("A nota deve ser entre 0 e 10");

                    quantidadeNotas++;
                    somaNotas += nota;

                    Console.WriteLine("Digite a proxima nota, ou -1 para finalizar a inserção");
                }
                Console.WriteLine($"A média é {somaNotas/quantidadeNotas}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao executar o exercício 7: {ex.Message}");
            }
        }

        // Exercício 8 - Contagem Regressiva: Imprima uma contagem regressiva a partir de um número informado.
        public override void Exercicio8()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao executar o exercício 8: {ex.Message}");
            }
        }

        // Exercício 9 - Soma dos Dígitos: Some os dígitos de um número informado pelo usuário.
        public override void Exercicio9() 
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao executar o exercício 9: {ex.Message}");
            }
        }

        // Exercício 10 - Adivinhe o Número (Do While): Versão do Exercício 2 usando um loop `do while`.
        public override void Exercicio10() 
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao executar o exercício 510: {ex.Message}");
            }
        }
    }
}