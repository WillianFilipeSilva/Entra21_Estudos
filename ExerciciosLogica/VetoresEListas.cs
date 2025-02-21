namespace ExerciciosCSharp.ExerciciosLogica
{
    public class VetoresEListas : Base
    {
        public override void Executar()
        {
            try
            {
                lista = new Dictionary<int, (string, Action)>
                {
                        { 1, ("Calcule a soma e a média dos elementos de um vetor de 5 números inteiros.", Exercicio1) },
                        { 2, ("Encontre e exiba o maior e o menor valor de um vetor de números reais.", Exercicio2) },
                        { 3, ("Separe os números pares e ímpares de um vetor de inteiros em dois novos vetores.", Exercicio3) },
                        { 4, ("Informe um valor e descubra se ele está presente no vetor.", Exercicio4) },
                        { 5, ("Inverta a ordem dos elementos de um vetor sem utilizar funções prontas.", Exercicio5) },
                        { 6, ("Conte quantas vezes um determinado valor aparece em um vetor.", Exercicio6) },
                        { 7, ("Mescle dois vetores ordenados de inteiros em um terceiro vetor, mantendo a ordem crescente.", Exercicio7) },
                        { 8, ("Crie uma lista com os números de 1 a 5 e exiba os valores.", Exercicio8) },
                        { 9, ("Digite 5 números para adicionar a uma lista e veja a soma total.", Exercicio9) },
                        { 10, ("Encontre e exiba o maior número de uma lista de inteiros pré-definidos.", Exercicio10) },
                        { 11, ("Digite o nome de uma fruta para removê-la de uma lista e veja a lista atualizada.", Exercicio11) },
                        { 12, ("Adicione 10 números a uma lista e veja quantos são maiores que 50.", Exercicio12) },
                        { 13, ("Digite um nome e veja se ele está presente em uma lista de nomes.", Exercicio13) },
                        { 14, ("Remova o primeiro e o último elemento de uma lista de números inteiros e exiba os valores restantes.", Exercicio14) },
                };

                Menu(lista);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro na execução do menu: {ex.Message}");
            }
        }

        //1. Soma e Média: Escreva um programa que lê um vetor de 5 números inteiros e calcula a soma e a média dos elementos.
        public override void Exercicio1() 
        {
            try
            {
                Console.WriteLine("Vamos somar e calcular a média de 5 numeros?\n");

                int[] numeros = new int[5];
                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.WriteLine($"Digite o {i + 1}º Numero\n");
                    numeros[i] = int.Parse(Console.ReadLine());
                }

                var soma = 0;
                foreach (var numero in numeros) soma += numero;

                var media = soma / numeros.Length;
                Console.WriteLine($"A média é {media}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao somar e calcular a média: {e.Message}");
            }
        }

        //2. Maior e Menor Valor: Crie um programa que encontra e exibe o maior e o menor valor em um vetor de números reais.
        public override void Exercicio2()
        {
            try
            {
                Console.WriteLine("Vamos encontrar o maior e o menor valor\n");
                Console.WriteLine("Digite a quantidade de números:");
                int tamanhoVetor = int.Parse(Console.ReadLine());

                if (tamanhoVetor <= 0)
                    throw new Exception("A quantidade de números deve ser maior que zero.");

                Console.WriteLine($"Digite o 1º número:");
                int  maior = int.Parse(Console.ReadLine());
                int menor = maior;

                int[] numeros = new int[tamanhoVetor];
                for (int i = 1; i < tamanhoVetor; i++)
                {
                    Console.WriteLine($"Digite o {i + 1}º número:");
                    numeros[i] = int.Parse(Console.ReadLine());

                    if (numeros[i] > maior)
                        maior = numeros[i];

                    if (numeros[i] < menor)
                        menor = numeros[i];
                }

                Console.WriteLine($"O maior valor é {maior} e o menor valor é {menor}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao encontrar o maior e o menor valor: {e.Message}");
            }
        }


        //3. Pares e Ímpares: Implemente um programa que divide um vetor de inteiros em dois vetores: um contendo os números pares e outro os números ímpares.
        public override void Exercicio3() 
        {
            try
            {
                int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                int[] pares = new int[ints.Length];
                int[] impares = new int[ints.Length];

                int paresIndex = 0;
                int imparesIndex = 0;

                foreach (var i in ints)
                {
                    if (i % 2 == 0)
                    {
                        pares[paresIndex] = i;
                        paresIndex++;
                    }
                    else
                    {
                        impares[imparesIndex] = i;
                        imparesIndex++;
                    }
                }

                Console.WriteLine("Pares:");
                foreach (var i in pares)
                {
                    if (i != 0)
                        Console.WriteLine(i);
                }
                Console.WriteLine("Impares:");
                foreach (var i in impares)
                {
                    if (i != 0)
                        Console.WriteLine(i);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao dividir o vetor em pares e impares: {e.Message}");
            }
        }
        
        //4. Busca por Valor: Crie uma função que recebe um vetor e um valor para procurar. A função deve retornar verdadeiro se o valor estiver presente no vetor e falso caso contrário.
        public override void Exercicio4()
        {
            try
            {
                int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                Console.WriteLine("Digite um número para procurar no vetor: ");
                int numero = int.Parse(Console.ReadLine());

                Console.WriteLine($"O numero {numero} {(ProcurarNumeroExerc4(ints, numero)? "" : "não")} foi encontrado no vetor.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao procurar o numero no vetor: {e.Message}");
            }
        }

        public static bool ProcurarNumeroExerc4(int[] ints, int numero)
        {
            foreach (var i in ints)
            {
                if (i == numero)
                    return true;
            }
            return false;
        }

        //5. Inversão de Vetor: Escreva um programa que inverte a ordem dos elementos em um vetor (não utilizar função pronta).
        public override void Exercicio5()
        {
            try
            {
               int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

               for (int i = 0; i < ints.Length / 2; i++)
                {
                    var temp = ints[i];
                    ints[i] = ints[ints.Length - i - 1];
                    ints[ints.Length - i - 1] = temp;
                }

                foreach (var i in ints)
                {
                    Console.WriteLine(i);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao inverter o vetor: {e.Message}");
            }
        }
        
        //6. Contagem de Elementos: Implemente uma função que conta quantas vezes um determinado valor aparece em um vetor.
        public override void Exercicio6()
        {
            try
            {
            int[] ints = { 1, 2, 3, 4, 5, 5, 7, 8, 9, 10 };
            Dictionary<int, int>quantidadeNumero = new();

            foreach (var inteiro in ints)
            {
                if (quantidadeNumero.ContainsKey(inteiro))
                    quantidadeNumero[inteiro]++;
                else
                    quantidadeNumero.Add(inteiro, 1);
            }

            foreach (var i in quantidadeNumero)
            {
                Console.WriteLine($"O número {i.Key} aparece {i.Value} vezes no vetor.");
            }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao contar quantas vezes o numero aparece no vetor: {e.Message}");
            }
        }
        
        //7. Mescla de Vetores: Desenvolva um programa que recebe dois vetores de inteiros ordenados e cria um terceiro vetor mesclando os elementos dos dois em ordem crescente.
        public override void Exercicio7() 
        {
            try
            {
                int[] vetor1 = { 1, 3, 5, 7, 9 };
                int[] vetor2 = { 2, 4, 6, 8, 11 };

                int[] vetor3 = new int[vetor1.Length + vetor2.Length];

                int indexVetor1 = 0;
                int indexVetor2 = 0;
                int indexVetor3 = 0;

                while (indexVetor1 < vetor1.Length && indexVetor2 < vetor2.Length)
                {
                    if (vetor1[indexVetor1] < vetor2[indexVetor2])
                    {
                        vetor3[indexVetor3] = vetor1[indexVetor1];
                        indexVetor1++;
                    }
                    else
                    {
                        vetor3[indexVetor3] = vetor2[indexVetor2];
                        indexVetor2++;
                    }
                    indexVetor3++;
                }
            
                while (indexVetor1 < vetor1.Length)
                {
                    vetor3[indexVetor3] = vetor1[indexVetor1];
                    indexVetor1++;
                    indexVetor3++;
                }

                while (indexVetor2 < vetor2.Length)
                {
                    vetor3[indexVetor3] = vetor2[indexVetor2];
                    indexVetor2++;
                    indexVetor3++;
                }
            
                foreach (var i in vetor3)
                {
                    Console.WriteLine(i);
                }   
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao criar o terceiro vetor mesclado: {e.Message}");
            }
        }

        //List
        //1. Crie uma List de inteiros e adicione os números de 1 a 5. Exiba os números no console.
        public override void Exercicio8() 
        {
            try
            {
                List<int> ints = new();

                for (int i = 1; i <= 5; i++)
                {
                    ints.Add(i);
                    Console.WriteLine(i);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao Criar a List e adicionar os numeros: {e.Message}");
            }
}
        
        //2. Crie uma List de números inteiros. Solicite ao usuário para digitar 5 números e adicione-os à lista.Em seguida, calcule e exiba a soma de todos os números.
        public override void Exercicio9()
        {
            try
            {
                List<int> ints = new();
                var soma = 0;

                for (int i = 0; i < 5; i++)
                {
                    ints.Add(int.Parse(Console.ReadLine()));
                    soma += ints[i];
                }

                Console.WriteLine($"A soma dos 5 numeros é: {soma}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao somar os 5 numeros: {e.Message}");
            }
        }
        
        //3. Crie uma List de inteiros com 6 valores pré-definidos.Percorra a lista e encontre o maior número. Exiba o maior valor no console.
        public override void Exercicio10()
        {
            try
            {
                List<int> ints = new() { 1, 2, 3, 4, 5, 6 };

                var maior = 0;
                foreach (var i in ints)
                {
                    if (i > maior)
                        maior = i;
                }

                Console.WriteLine($"O maior número é: {maior}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao verificar o maior numero: {e.Message}");
            }
        }
        
        //4. Crie uma List de strings com nomes de frutas ("banana", "maçã", "uva", "laranja"). Solicite ao usuário uma fruta para remover e remova-a da lista.Exiba a lista atualizada.
        public override void Exercicio11()
        {
            try
            {
                List<string> frutas = new() { "banana", "maçã", "uva", "laranja" };

                Console.WriteLine("Digite uma das seguintes frutas para remover da lista:");
                foreach (var f in frutas) Console.Write($" {f}");

                var frutaRemover = Console.ReadLine();
                frutas.Remove(frutaRemover);

                Console.WriteLine($"Removido {frutaRemover}, restam:");
                foreach (var f in frutas) Console.Write($" {f}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao remover uma fruta da lista: {e.Message}");
            }
        }
        
        //5. Crie uma List de números inteiros. Adicione 10 números quaisquer à lista e conte quantos números são maiores que 50. Exiba o resultado.
        public override void Exercicio12()
        {
            try
            {
                List<int> ints = new() { 1, 2, 3, 4, 5, 6, 7, 8, 50, 51 };

                var quantidade = 0;
                foreach (var i in ints) if (i > 50) quantidade++;


                Console.WriteLine($"Quantidade de numeros maiores que 50: {quantidade}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao contar os numeros maiores que 50: {e.Message}");
            }
        }
        
        //6. Crie uma List de nomes ("Ana", "Bruno", "Carlos", "Diana", "Eduardo"). Pergunte ao usuário por um nome e informe se ele está presente na lista.
        public override void Exercicio13()
        {
            try
            {
                List<string> nomes = new() { "Ana", "Bruno", "Carlos", "Diana", "Eduardo" };

                Console.WriteLine("Digite um nome para verificarmos na lista:");
                var nome = Console.ReadLine();

                Console.WriteLine($"O nome {nome} {(nomes.Contains(nome) ? "" : "não")} está na lista.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao verificar se o nome está na lista: {e.Message}");
            }
        }
        
        //7. Crie uma List de números inteiros contendo pelo menos 5 elementos.Remova o primeiro e o último elemento da lista e exiba os valores restantes.
        public override void Exercicio14()
        {
            try
            {
                List<int> ints = new() { 1, 2, 3, 4, 5 };

                ints.RemoveAt(0);
                ints.RemoveAt(ints.Count - 1);

                foreach (var i in ints) Console.WriteLine(i);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao remover o primeiro e ultimo numero da lista: {e.Message}");
            }
        }
    }
}