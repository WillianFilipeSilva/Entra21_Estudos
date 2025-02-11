namespace ExerciciosCSharp.ExerciciosLogica
{
    public class EstrurutasDeRepeticaoFor : Base
    {
        public void Executar()
        {
            var lista = new Dictionary<int, (string, Action)>
            {
                { 1, ("Imprimir números de 1 a 10", Exercicio1) },
                { 2, ("Calcular a soma dos primeiros 100 números inteiros", Exercicio2) },
                { 3, ("Imprimir os números pares de 1 a 20", Exercicio3) },
                { 4, ("Calcular o fatorial de um número dado", Exercicio4) },
                { 5, ("Imprimir a tabuada de multiplicação de um número dado", Exercicio5) },
                { 6, ("Contar a quantidade de números pares e ímpares em um intervalo", Exercicio6) },
                { 7, ("Calcular a média de um conjunto de notas", Exercicio7) },
                { 8, ("Imprimir os primeiros 20 termos da sequência de Fibonacci", Exercicio8) },
                { 9, ("Verificar se um número é primo", Exercicio9) },
                { 10, ("Criar um padrão de triângulo utilizando asteriscos", Exercicio10) },
                { 11, ("Soma de Números Pares", Exercicio11) },
                { 12, ("Sequência de Potências", Exercicio12) },
                { 13, ("Contagem Regressiva", Exercicio13) },
            };

            Menu(lista);
        }
        
        //Looping para todos os numeros multiplos de 5 até 20
        public void Exercicio()
        {
            for (int i = 0; i <= 20; i += 5)
            {
                Console.WriteLine(i);
            }
        }

        //Exercício 1: Imprimir números de 1 a 10:
        //Escreva um programa em C# que utilize um loop for para imprimir os números de 1 a 10;
        public override void Exercicio1()
        {
            Console.WriteLine("Numeros de 1 a 10:\n");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        //Exercício 2: Calcular a soma dos primeiros 100 números inteiros:
        //Desenvolva um programa em C# que calcule e exiba a soma dos primeiros 100 números inteiros usando um loop for.
        public override void Exercicio2()
        {
            Console.WriteLine("Somando os numeros de 1 a 100");

            var numero = 0;
            for (int i = 1; i <= 100; i++)
            {
                numero += i;
            }
            Console.WriteLine($"A soma de todos os numeros de 1 a 100 é: {numero}");
        }
        
        //Exercício 3: Imprimir os números pares de 1 a 20:
        //Crie um programa em C# que utilize um loop for para imprimir os números pares no intervalo de 1 a 20.
        public override void Exercicio3()
        {
            Console.WriteLine("Imprimindo os numeros de 1 a 20:\n");

            for (int i = 2; i <= 20; i++)
            {
                if(i % 2 == 0)
                Console.WriteLine(i);
            }
        }

        //Exercício 4: Calcular o fatorial de um número dado:
        //Elabore um programa em C# que calcule e apresente o fatorial de um número inteiro fornecido pelo usuário usando um loop for.
        public override void Exercicio4()
        {
            Console.WriteLine("Digite um numero para calcular seu fatorial\n");
            var numero = int.Parse(Console.ReadLine());

            if (numero == 0)
            {
                Console.WriteLine($"O  fatorial de {numero}, é 1");
                return; 
            }

            var fatorial = 0;
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                    fatorial += i;
            }
            Console.WriteLine($"O fatorial de {numero} é {fatorial}");
        }

        //Exercício 5: Imprimir a tabuada de multiplicação de um número dado:
        //Descreva um programa em C# que exiba a tabuada de multiplicação de um número inteiro fornecido pelo usuário, usando um loop for para calcular os resultados.
        public override void Exercicio5()
        {
            Console.WriteLine("Digite um numero para calcular sua tabuada de multiplicação\n");
            var numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Multiplos de {numero}");
            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine($"O {i} multiplo de {numero} é {i * numero}");
            }
        }

        //Exercício 6: Contar a quantidade de números pares e ímpares em um intervalo:
        //Crie um programa em C# que conte e mostre a quantidade de números pares e ímpares no intervalo de 1 a 100, usando um loop for.
        public override void Exercicio6()
        {
            Console.WriteLine("Digite um numero para contar a quantidade de pares e inpares no seu intervalo\n");
            var numero = int.Parse(Console.ReadLine());

            if(numero == 0)
            {
                Console.WriteLine($"O numero {numero}, não é valido");
                return;
            }

            var quantidadePares = 0;
            var quantidadeImpares = 0;
            for (int i = 1; i <= numero; i++)
            {
                if (i % 3 == 0)
                {
                    quantidadeImpares++;
                }
                quantidadePares++;
            }
            Console.WriteLine($"Temos {quantidadePares} numeros pares, e {quantidadeImpares} numeros impares entre 0 e {numero}");
        }

        //Exercício 7: Calcular a média de um conjunto de notas:
        //Desenvolva um programa em C# que calcule a média de um conjunto de notas e exiba o resultado.
        public override void Exercicio7()
        {
            Console.WriteLine("Vamos Calcular a média, quantas notas temos no total ?\n");
            var numero1 = int.Parse(Console.ReadLine());

            int[] numeros = new int[numero1];

            var media = 0;
            for (int i = 1; i <= numeros.Length; i ++)
            {
                Console.WriteLine($"Digite o {i}º Numero\n");
                media += int.Parse(Console.ReadLine());
            }
            media = media/numeros.Length;
            Console.WriteLine($"A média é {media}");
        }

        //Exercício 8: Imprimir os primeiros 20 termos da sequência de Fibonacci:
        //Escreva um programa em C# que utilize um loop for para calcular e imprimir os primeiros 20 termos da sequência de Fibonacci.
        public override void Exercicio8()
        {
            var numero = 0;
            var numero1 = 1;

            Console.WriteLine($"A sequencia fibonacci dos primeiros 20 termos é :");

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(numero);
                var proximo = numero + numero1;
                numero = numero1;
                numero1 = proximo;
            }
        }

        //Exercício 9: Verificar se um número é primo:
        //Crie um programa em C# que verifique se um número inteiro fornecido pelo usuário é primo ou não, utilizando um loop for para realizar a verificação.
        public override void Exercicio9()
        {
            Console.WriteLine("Digite um numero para verificar se é primo");
            int numero = int.Parse(Console.ReadLine());

            bool primo = true;

            for (int i = numero; i> 1; i--)
            {
                if(numero %  i == 0) primo = false;
            }

            Console.WriteLine($"O numero:{numero} é primo");
        }

        //Exercício 10: Criar um padrão de triângulo utilizando asteriscos:
        //Elabore um programa em C# que utilize loops for aninhados para criar e exibir um padrão de triângulo formado por asteriscos.
        public override void Exercicio10()
        {
            Console.WriteLine("Digite o tamanho do triangulo");
            int tamanhoTriangulo = int.Parse(Console.ReadLine());

            string[] linhas = new string[tamanhoTriangulo];
            for (int i = 0; i < tamanhoTriangulo; i++)
            {
                for (int k = tamanhoTriangulo; k > i; k--)
                {
                    linhas[i] += " ";
                }
                for (int j = 0; j <= i ; j++)
                {
                    linhas[i] += "*";
                }
            }
            Console.WriteLine("\nTriangulo:\n");

            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }
        }

        //Exercício 11: Soma de Números Pares
        //Escreva um programa que calcule e exiba a soma dos números pares de 1 a 100 utilizando um loop for.
        public override void Exercicio11()
        {
            int soma = 0;
            for(int i = 1; i <= 100; i++)
            {
                if(i % 2 == 0) soma += i;
            }
            Console.WriteLine($"A soma dos numeros pares de 1 a 100 é: {soma}");
        }

        //Exercício 12: Sequência de Potências
        //Crie um programa que peça ao usuário para inserir um número inteiro e, em seguida, exiba a sequência de potências de 2 até a potência correspondente ao número inserido.
        public override void Exercicio12()
        {
            Console.WriteLine("Digite um numero inteiro, vamos exibir a sequencia de potencias de 2 até o numero");
            int numero = int.Parse(Console.ReadLine());

            int potencia = 1;

            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine($"2^{i} = {potencia}");
                potencia *= 2;
            }
        }

        //Exercício 13: Contagem Regressiva
        //Peça ao usuário para inserir um número inteiro positivo e utilize um loop for para fazer uma contagem regressiva a partir desse número até 1, exibindo cada valor.
        public override void Exercicio13()
        {
            Console.WriteLine("Digite um numero inteiro, vamos fazer uma contagem regressiva\n");
            int numero = int.Parse(Console.ReadLine());

            for (int i = numero; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}