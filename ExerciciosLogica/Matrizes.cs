namespace ExerciciosCSharp.ExerciciosLogica
{
    public class Matrizes : Base
    {
        public int[,] matriz = new int[3, 3]
               {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
               };

        public override void Executar()
        {
            try
            {
                lista = new Dictionary<int, (string, Action)>
                {
                    { 1, ("Criando uma Matriz", Exercicio1) },
                    { 2, ("Soma dos Elementos", Exercicio2) },
                    { 3, ("Maior e Menor Valor", Exercicio3) },
                    { 4, ("Diagonal Principal", Exercicio4) },
                    { 5, ("Transposta de uma Matriz", Exercicio5) },
                    { 6, ("Matriz Identidade", Exercicio6) },
                    { 7, ("Multiplicação de Matrizes", Exercicio7) },
                    { 8, ("Média dos Elementos", Exercicio8) },
                    { 9, ("Matriz Esparsa", Exercicio9) },
                    { 10, ("Matriz Dinâmica", Exercicio10) }
                };

                ExibirMenu(lista);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro na execução do menu: {ex.Message}");
            }
        }

        //1. Criando uma Matriz
        //Declare e inicialize uma matriz 3x3 com valores inteiros e imprima seus elementos.
        public override void Exercicio1() 
        {
            try
            {
                Console.WriteLine("Matriz 3x3: ");

                int[,] matriz = new int[3, 3] 
                { 
                    { 1, 2, 3 }, 
                    { 4, 5, 6 }, 
                    { 7, 8, 9 }
                };

                ImprimirMatriz(matriz);
            }
            catch(Exception ex)
            {
                throw new Exception($"Erro ao executar o exercício 1: {ex.Message}");
            }
        }

        public void ImprimirMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        //2. Soma dos Elementos
        //Crie um programa que percorre uma matriz e calcula a soma de todos os seus elementos.
        public override void Exercicio2() 
        {
            try
            {
                int soma = 0;

                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        soma += matriz[i, j];
                    }
                }

                Console.WriteLine($"A soma dos elementos da matriz é: {soma}");
            }   
            catch(Exception ex)
            {
                throw new Exception($"Erro ao executar o exercício 2: {ex.Message}");
            }
        }

        //3. Maior e Menor Valor
        //Desenvolva um algoritmo que encontre o maior e o menor valor dentro de uma matriz.
        public override void Exercicio3()
        {
            try
            {
                Console.WriteLine("Vamos encontrar o maior e o menor valor de uma matriz\n");

                int maior = matriz[0, 0];
                int menor = matriz[0, 0];

                for (int i = 0; i < matriz.GetLength(0); i++) // Percorre as linhas
                {
                    for (int j = 0; j < matriz.GetLength(1); j++) // Percorre as colunas
                    {
                        if (matriz[i, j] > maior)
                        {
                            maior = matriz[i, j];
                        }
                        if (matriz[i, j] < menor)
                        {
                            menor = matriz[i, j];
                        }
                    }
                }

                Console.WriteLine($"Maior valor: {maior}");
                Console.WriteLine($"Menor valor: {menor}");
}
            catch(Exception ex)
            {
                throw new Exception($"Erro ao executar o exercício 3: {ex.Message}");
            }
        }

        //4. Diagonal Principal
        //Escreva um programa que exiba apenas os elementos da diagonal principal de uma matriz quadrada.
        public override void Exercicio4() 
        {
            try
            {
                Console.WriteLine("Exibindo os numeros da diagonal de uma matriz");

                for(int i = 0; i < matriz.GetLength(0); i++)
                {
                    Console.WriteLine($"a {i+1} diagonal é = {matriz[i, i]}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao executar o exercício 4: {ex.Message}");
            }
        }

        //5. Transposta de uma Matriz
        //Implemente um programa que gere a transposta de uma matriz 3x3.
        public override void Exercicio5() 
        {
            try
            {
                Console.WriteLine("Vamos transpor uma matriz 3x3\n");

                var matrizTransposta = matriz;

                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        matrizTransposta[j, i] = matriz[i, j];
                    }
                }
                ImprimirMatriz(matrizTransposta);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao executar o exercício 5: {ex.Message}");
            }
        }

        //6. Matriz Identidade
        //Construa um programa que verifica se uma matriz quadrada é uma matriz identidade.
        public override void Exercicio6() 
        { 
            try
            {
                Console.WriteLine("Vamos verificar se uma matriz quadrada é uma matriz identidade\n");

                //matriz = new int[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };

                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        if (i == j && matriz[i, j] != 1)
                        {
                            Console.WriteLine("Nao eh uma matriz identidade");
                            return;
                        }
                        else if (i != j && matriz[i, j] != 0)
                        {
                            Console.WriteLine("Nao eh uma matriz identidade");
                            return;
                        }
                    }
                }

                Console.WriteLine("Eh uma matriz identidade");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao executar o exercício 6: {ex.Message}");
            }
        }

        //7. Multiplicação de Matrizes
        //Escreva um código que multiplica duas matrizes 2x2 e exibe o resultado.
        public override void Exercicio7() 
        {
            try
            {
                Console.WriteLine("Vamos multiplicar duas matrizes 2x2\n");

                var matriz1 = new int[2, 2] 
                {
                    { 1, 2 }, 
                    { 3, 4 } 
                };

                var matriz2 = new int[2, 2] 
                {
                    { 5, 6 }, 
                    { 7, 8 } 
                };

                var produtoMatrizes = new int[2, 2];
                for (int i = 0; i < matriz1.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz2.GetLength(1); j++)
                    {
                        produtoMatrizes[i, j] = 0;
                        for (int k = 0; k < matriz1.GetLength(1); k++)
                        {
                            produtoMatrizes[i, j] += matriz1[i, k] * matriz2[k, j];
                        }
                    }
                }
                ImprimirMatriz(produtoMatrizes);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao executar o exercício 7: {ex.Message}");
            }
        }

        //8. Média dos Elementos
        //Calcule a média dos valores armazenados em uma matriz 4x4.
        public override void Exercicio8() 
        {
            try
            {
                Console.WriteLine("Vamos calcular a media dos valores de uma matriz 4x4\n");

                var matriz = new int[4, 4]
                {
                    { 1, 2 , 3, 4},
                    { 5, 6, 7, 8 },
                    { 9, 10, 11, 12 },
                    { 13, 14, 15, 16 },
                };

                var soma = 0;
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        soma += matriz[i, j];
                    }
                }
                Console.WriteLine($"A media dos valores eh: {soma / 16}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao executar o exercício 8: {ex.Message}");
            }

        }

        //9. Matriz Esparsa
        //Desenvolva um programa que verifica se uma matriz possui mais elementos nulos (0) do que não nulos.
        public override void Exercicio9() 
        {
            try
            {
                Console.WriteLine("Vamos verificar se uma matriz possui mais elementos nulos (0) do que não nulos\n");

                var quantidadeNulos = 0;
                var quantidadeNaoNulos = 0;
                foreach (int n in matriz)
                {
                    if (n == 0)
                    {
                        quantidadeNulos++;
                    }
                    else
                    {
                        quantidadeNaoNulos++;
                    }
                }

                Console.WriteLine($"a quantidade de {(quantidadeNaoNulos < quantidadeNulos? $"nulos ({quantidadeNulos})" : $"não nulos ({quantidadeNaoNulos})")} é maior");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao executar o exercício 9: {ex.Message}");
            }

        }

        //10. Matriz Dinâmica
        //Crie uma matriz de tamanho variável, solicite ao usuário os valores e exiba a matriz na tela.
        public override void Exercicio10() 
        {
            try
            {
                Console.WriteLine("Vamos criar uma matriz dinâmica\n");

                Console.WriteLine("Digite a quantidade de linhas:");
                var quantidadeLinhas = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a quantidade de colunas:");
                var quantidadeColunas = int.Parse(Console.ReadLine());

                var matriz = new int[quantidadeLinhas, quantidadeColunas];
                for (int i = 0; i < quantidadeLinhas; i++)
                {
                    for (int j = 0; j < quantidadeColunas; j++)
                    {
                        Console.WriteLine($"Digite o valor da linha {i + 1} e da coluna {j + 1}:");
                        matriz[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("Matriz criada:");
                ImprimirMatriz(matriz);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao executar o exercício 10: {ex.Message}");
            }
        }
    }
}