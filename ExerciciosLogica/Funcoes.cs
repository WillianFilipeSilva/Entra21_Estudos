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
        public override void Exercicio1()
        {
            try
            {
                Console.Write("Digite o primeiro número: ");
                int numero1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                int numero2 = int.Parse(Console.ReadLine());

                int soma = numero1 + numero2;
                Console.WriteLine($"A soma é: {soma}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        //2. Escreva uma função que calcule o fatorial de um número inteiro passado como argumento.
        public override void Exercicio2()
        {
            try
            {
                Console.Write("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());

                long fatorial = 1;
                for (int i = 1; i <= numero; i++)
                {
                    fatorial *= i;
                }
                Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        //3. Desenvolva uma função que verifique se um número é primo ou não.
        public override void Exercicio3()
        {
            try
            {
                Console.Write("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());

                bool ehPrimo = true;
                if (numero <= 1)
                    ehPrimo = false;
                else
                {
                    for (int i = 2; i * i <= numero; i++)
                    {
                        if (numero % i == 0)
                        {
                            ehPrimo = false;
                            break;
                        }
                    }
                }
                Console.WriteLine(ehPrimo ? $"{numero} é primo." : $"{numero} não é primo.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        //4. Implemente uma função que receba uma lista de inteiros e retorne o maior valor presente na lista.
        public override void Exercicio4()
        {
            try
            {
                Console.Write("Digite os números separados por espaço: ");
                string numerosString = Console.ReadLine();

                string[] partes = numerosString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (partes.Length == 0)
                {
                    throw new Exception("Nenhum número foi fornecido.");
                }
                int[] numeros = new int[partes.Length];
                for (int i = 0; i < partes.Length; i++)
                {
                    numeros[i] = int.Parse(partes[i]);
                }
                int maior = numeros[0];
                for (int i = 1; i < numeros.Length; i++)
                {
                    if (numeros[i] > maior)
                        maior = numeros[i];
                }
                Console.WriteLine($"O maior valor da lista é: {maior}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        //5. Crie uma função que inverta uma string passada como parâmetro (sem usar funções de inversão embutidas).
        public override void Exercicio5()
        {
            try
            {
                Console.Write("Digite um texto: ");
                string texto = Console.ReadLine();

                if (string.IsNullOrEmpty(texto))
                    throw new Exception("Nenhum texto foi fornecido.");

                string textoInvertido = "";
                for (int i = texto.Length - 1; i >= 0; i--)
                {
                    textoInvertido += texto[i];
                }
                Console.WriteLine($"Texto invertida: {textoInvertido}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        //6. Escreva uma função que calcule a média de uma lista de números reais.
        public override void Exercicio6()
        {
            try
            {
                Console.Write("Digite os números reais separados por espaço: ");
                string numero = Console.ReadLine();

                string[] numerosSeparados = numero.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (numerosSeparados.Length == 0)
                    throw new Exception("Nenhum número foi fornecido.");

                double soma = 0;
                double[] numeros = new double[numerosSeparados.Length];
                for (int i = 0; i < numerosSeparados.Length; i++)
                {
                    numeros[i] = double.Parse(numerosSeparados[i]);
                    soma += numeros[i];
                }

                double media = soma / numerosSeparados.Length;
                Console.WriteLine($"A média dos números é: {media}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        //7. Desenvolva uma função que verifique se uma string é um palíndromo(ela lê o mesmo de trás para frente) ou não.
        public override void Exercicio7()
        {
            try
            {
                Console.Write("Digite uma texto: ");
                string texto = Console.ReadLine();

                if (string.IsNullOrEmpty(texto))
                    throw new Exception("Nenhum texto foi fornecido.");

                string reverso = "";
                for (int i = texto.Length - 1; i >= 0; i--)
                {
                    reverso += texto[i];
                }

                bool isPalindromo = texto.Equals(reverso, StringComparison.OrdinalIgnoreCase);
                Console.WriteLine(isPalindromo ? $"O {texto} é um palíndromo." : $"O {texto} não é um palíndromo.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        //8. Implemente uma função que receba um valor em graus Celsius e retorne o equivalente em Fahrenheit.
        public override void Exercicio8()
        {
            try
            {
                Console.Write("Digite a temperatura em Celsius: ");
                double celsius = double.Parse(Console.ReadLine());

                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"{celsius}°C equivalem a {fahrenheit}°F.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        //9. Crie uma função que receba um array de strings e retorne a quantidade de strings que possuem mais de 5 caracteres.
        public override void Exercicio9()
        {
            try
            {
                Console.Write("Digite os textos separados por vírgula: ");
                string[] strings = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);

                if (strings.Length == 0)
                    throw new Exception("Nenhum texto foi fornecido.");

                int count = 0;

                foreach (var s in strings)
                {
                    if (s.Trim().Length > 5)
                        count++;
                }
                Console.WriteLine($"Quantidade de textos com mais de 5 caracteres: {count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        //10. Escreva uma função que calcule o máximo divisor comum (MDC) entre dois números inteiros.
        public override void Exercicio10()
        {
            try
            {
                Console.Write("Digite o primeiro número: ");
                int numero1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                int numero2 = int.Parse(Console.ReadLine());

                if (numero1 == 0 && numero2 == 0)
                {
                    Console.WriteLine("O MDC não é definido quando ambos os números são zero.");
                    return;
                }

                int originalNumero1 = numero1;
                int originalNumero2 = numero2;

                int mdc = CalcularMDC(numero1, numero2);
                Console.WriteLine($"O MDC de {originalNumero1} e {originalNumero2} é: {mdc}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        private int CalcularMDC(int numero1, int numero2)
        {
            numero1 = numero1 < 0 ? -numero1 : numero1;
            numero2 = numero2 < 0 ? -numero2 : numero2;

            while (numero2 != 0)
            {
                int resto = numero1 % numero2;
                numero1 = numero2;
                numero2 = resto;
            }

            return numero1;
        }

        //11. Desenvolva uma função que receba uma lista de inteiros e retorne uma nova lista com os números pares.
        public override void Exercicio11()
        {
            try
            {
                Console.Write("Digite os números inteiros separados por espaço: ");
                string numerosString = Console.ReadLine();

                string[] partes = numerosString.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                List<int> numeros = new List<int>();
                for (int i = 0; i < partes.Length; i++)
                {
                    numeros.Add(int.Parse(partes[i]));
                }

                List<int> pares = new List<int>();
                foreach (int numero in numeros)
                {
                    if (numero % 2 == 0)
                        pares.Add(numero);
                }
                Console.WriteLine("Números pares: " + string.Join(", ", pares));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        //12. Implemente uma função que conte quantas vezes um determinado elemento aparece em uma lista.
        public override void Exercicio12()
        {
            try
            {
                Console.Write("Digite os elementos separados por espaço: ");
                string[] elementos = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Console.Write("Digite o elemento para contar: ");
                string elementoProcurado = Console.ReadLine();

                int count = 0;
                foreach (string elemento in elementos)
                {
                    if (elemento == elementoProcurado)
                        count++;
                }
                Console.WriteLine($"O elemento '{elementoProcurado}' aparece {count} vezes.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        //13. Crie uma função que receba uma string e retorne outra string com todas as letras maiúsculas convertidas para minúsculas e vice-versa.
        public override void Exercicio13()
        {
            try
            {
                Console.Write("Digite um texto: ");
                string texto = Console.ReadLine();

                string resultado = "";
                foreach (char c in texto)
                {
                    if (char.IsUpper(c))
                        resultado += char.ToLower(c);
                    else if (char.IsLower(c))
                        resultado += char.ToUpper(c);
                    else
                        resultado += c;
                }
                Console.WriteLine("Texto com alternância de maiúsculas e minúsculas: " + resultado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        //14. Escreva uma função que calcule o valor da série de Fibonacci para um dado número de termos.
        public override void Exercicio14()
        {
            try
            {
                Console.Write("Digite o número de termos da série de Fibonacci: ");
                int numero = int.Parse(Console.ReadLine());
                if (numero <= 0)
                {
                    Console.WriteLine("O número de termos deve ser maior que 0.");
                    return;
                }

                List<long> fibonacci = new List<long>();
                for (int i = 0; i < numero; i++)
                {
                    if (i == 0)
                        fibonacci.Add(0);
                    else if (i == 1)
                        fibonacci.Add(1);
                    else
                        fibonacci.Add(fibonacci[i - 1] + fibonacci[i - 2]);
                }
                Console.WriteLine("Série de Fibonacci: " + string.Join(", ", fibonacci));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        //15. Desenvolva uma função que determine se um número é positivo, negativo ou zero.
        public override void Exercicio15()
        {
            try
            {
                Console.Write("Digite um número: ");
                double num = double.Parse(Console.ReadLine());
                if (num > 0)
                    Console.WriteLine("O número é positivo.");
                else if (num < 0)
                    Console.WriteLine("O número é negativo.");
                else
                    Console.WriteLine("O número é zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        //16: Calculadora Simples - Crie uma função chamada Calculadora que recebe dois números e um operador (+, -, *, /) como parâmetros e retorna o resultado da operação.
        public override void Exercicio16()
        {
            try
            {
                Console.Write("Digite o primeiro número: ");
                double numero1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o operador (+, -, *, /): ");
                string operador = Console.ReadLine();

                Console.Write("Digite o segundo número: ");
                double numero2 = double.Parse(Console.ReadLine());

                double resultado = 0;
                switch (operador)
                {
                    case "+":
                        resultado = numero1 + numero2;
                        break;
                    case "-":
                        resultado = numero1 - numero2;
                        break;
                    case "*":
                        resultado = numero1 * numero2;
                        break;
                    case "/":
                        if (numero2 == 0)
                        {
                            Console.WriteLine("Divisão por zero não é permitida.");
                            return;
                        }
                        resultado = numero1 / numero2;
                        break;
                    default:
                        Console.WriteLine("Operador inválido.");
                        return;
                }
                Console.WriteLine($"Resultado: {resultado}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        //17: Verificação de Número Primo - Escreva uma função chamada Primo que recebe um número inteiro como parâmetro e retorna true se o número for primo e false caso contrário.
        public override void Exercicio17()
        {
            try
            {
                Console.Write("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());

                bool ehPrimo = true;
                if (numero <= 1)
                    ehPrimo = false;
                else
                {
                    for (int i = 2; i * i <= numero; i++)
                    {
                        if (numero % i == 0)
                        {
                            ehPrimo = false;
                            break;
                        }
                    }
                }
                Console.WriteLine(ehPrimo ? "true" : "false");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        //18: Sequência de Fibonacci - Implemente uma função chamada Fibonacci que recebe um número inteiro n como parâmetro e retorna uma lista contendo os primeiros n números da sequência de Fibonacci.
        public override void Exercicio18()
        {
            try
            {
                Console.Write("Digite o número de termos da sequência de Fibonacci: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero <= 0)
                {
                    Console.WriteLine("O número de termos deve ser maior que 0.");
                    return;
                }

                List<long> fibonacci = new List<long>();
                for (int i = 0; i < numero; i++)
                {
                    if (i == 0)
                        fibonacci.Add(0);
                    else if (i == 1)
                        fibonacci.Add(1);
                    else
                        fibonacci.Add(fibonacci[i - 1] + fibonacci[i - 2]);
                }
                Console.WriteLine("Sequência de Fibonacci: " + string.Join(", ", fibonacci));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        //19: Contagem de Dígitos - Crie uma função chamada ContarDigitos que recebe um número inteiro como parâmetro e retorna o número de dígitos no número.
        public override void Exercicio19()
        {
            try
            {
                Console.Write("Digite um número inteiro: ");
                int numero = int.Parse(Console.ReadLine());

                int quantidade = 0;
                int temp = (numero < 0) ? -numero : numero;

                if (temp == 0)
                    quantidade = 1;
                else
                {
                    while (temp > 0)
                    {
                        quantidade++;
                        temp /= 10;
                    }
                }

                Console.WriteLine($"O número {numero} tem {quantidade} dígito(s).");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        //20: Média de Números - Desenvolva uma função chamada CalcularMedia que recebe 3 números e retorna a média dos itens.
        public override void Exercicio20()
        {
            try
            {
                Console.Write("Digite o primeiro número: ");
                double numero1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double numero2 = double.Parse(Console.ReadLine());

                Console.Write("Digite o terceiro número: ");
                double numero3 = double.Parse(Console.ReadLine());

                double media = (numero1 + numero2 + numero3) / 3;
                Console.WriteLine($"A média dos números é: {media}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }
}