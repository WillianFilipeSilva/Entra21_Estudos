namespace ExerciciosCSharp.ExerciciosLogica
{
    public class Variaveis : Base
    {
        public override void Executar()
        {
            try
            {
                lista = new Dictionary<int, (string, Action)>
                {
                    { 1, ("Imprimir um número inteiro", Exercicio1) },
                    { 2, ("Exibir mensagem de boas-vindas ao curso", Exercicio2) },
                    { 3, ("Somar dois números double", Exercicio3) },
                    { 4, ("Calcular o quadrado de um número inteiro", Exercicio4) },
                    { 5, ("Verificar se um número é par ou ímpar", Exercicio5) },
                    { 6, ("Exibir o maior de dois números inteiros", Exercicio6) },
                    { 7, ("Verificar se a soma de dois números é maior que 100", Exercicio7) },
                    { 8, ("Converter double para int", Exercicio8) },
                    { 9, ("Calcular o cubo de um número", Exercicio9) },
                    { 10, ("Verificar se um número é múltiplo de 3 e 5", Exercicio10) },
                    { 11, ("Verificar se é maior de idade", Exercicio11) },
                    { 12, ("Converter Celsius para Fahrenheit", Exercicio12) },
                    { 13, ("Calcular a média aritmética de três números", Exercicio13) },
                    { 14, ("Calcular aumento de 10% no salário", Exercicio14) },
                    { 15, ("Concatenar strings para formar uma frase", Exercicio15) },
                    { 16, ("Converter número decimal para inteiro", Exercicio16) },
                    { 17, ("Verificar se um número está entre 1 e 100", Exercicio17) },
                    { 18, ("Contar os Caracteres de um texto", Exercicio18) },
                    { 19, ("Verificar se dois textos são iguais", Exercicio19) },
                };

                Menu(lista);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro na execução do menu: {ex.Message}");
            }
        }

        //1.  Declare uma variável do tipo int, atribua um valor e imprima na tela.
        public override void Exercicio1()
        {
            int _NumeroInteiro;
            _NumeroInteiro = 1;
            Console.WriteLine(_NumeroInteiro);
        }

        //2.  Crie uma variável string com o nome do seu curso e exiba a mensagem: “Bem-vindo ao curso[nome]”.
        public override void Exercicio2()
        {
            string nomeCurso = "Csharp";
            Console.WriteLine($"Bem-Vindo ao {nomeCurso}!");
        }

        //3.  Declare duas variáveis do tipo double, atribua valores e exiba a soma.
        public override void Exercicio3()
        {
            double valorDouble = 1.0;
            double valorDouble1 = 2.0;

            double somaValorDouble = valorDouble + valorDouble1;
            Console.WriteLine(somaValorDouble);
        }

        //4.  Leia um número inteiro do usuário e exiba o quadrado desse número.
        public override void Exercicio4()
        {
            int _NumeroInteiro;
            Console.WriteLine("Digite um número inteiro para calcular o quadrado dele:");
            _NumeroInteiro = int.Parse(Console.ReadLine());

            var quadradoNumero = _NumeroInteiro * _NumeroInteiro;
            Console.WriteLine(quadradoNumero);
        }

        //5.  Verifique se um número inteiro lido do teclado é par ou ímpar.
        public override void Exercicio5()
        {
            int _NumeroInteiro;
            Console.WriteLine("Digite um número inteiro para testar se é par ou ímpar:");
            _NumeroInteiro = int.Parse(Console.ReadLine());

            if (_NumeroInteiro == 0)
            {
                Console.WriteLine("Não pode ser 0");
            }
            else
            {
                var parOuImpar = "Ímpar";
                if (_NumeroInteiro % 2 == 0)
                    parOuImpar = "Par";

                Console.WriteLine(parOuImpar);
            }
        }

        //6.  Leia dois números inteiros e exiba o maior deles.
        public override void Exercicio6()
        {
            int _NumeroInteiro;
            int _NumeroInteiro1;
            Console.WriteLine("Digite dois números inteiros para verificar o maior:");
            _NumeroInteiro = int.Parse(Console.ReadLine());
            _NumeroInteiro1 = int.Parse(Console.ReadLine());

            if (_NumeroInteiro > _NumeroInteiro1)
            {
                Console.WriteLine($"O número: {_NumeroInteiro} é maior que {_NumeroInteiro1}!");
            }
            else
            {
                Console.WriteLine($"O número: {_NumeroInteiro1} é maior que {_NumeroInteiro}!");
            }
        }

        //7.  Crie uma variável booleana que indica se a soma de dois números é maior que 100.
        public override void Exercicio7()
        {
            bool maiorQue100 = false;

            int soma = 11 + 90;
            if (soma > 100)
                maiorQue100 = true;

            if (maiorQue100)
            {
                Console.WriteLine("É maior que 100");
            }
            else
            {
                Console.WriteLine("Não é maior que 100");
            }
        }

        //8.  Converta uma variável double para int e exiba o valor antes e depois da conversão.
        public override void Exercicio8()
        {
            double numeroDouble = 1.0;
            Console.WriteLine($"Número Double: {numeroDouble}");

            int _NumeroInteiro = (int)numeroDouble;
            Console.WriteLine($"Número Inteiro: {_NumeroInteiro}");
        }

        //9.  Declare uma variável e calcule a variável ao cubo.
        public override void Exercicio9()
        {
            int _NumeroInteiro = 3;
            int cuboNumeroCubo = _NumeroInteiro * _NumeroInteiro * _NumeroInteiro;
            Console.WriteLine($"O cubo de {_NumeroInteiro} é: {cuboNumeroCubo}");
        }

        //10. Crie uma expressão que verifica se um número é múltiplo de 5 e de 3 ao mesmo tempo.
        public override void Exercicio10()
        {
            int _NumeroInteiro = 15;
            if (_NumeroInteiro % 3 == 0 && _NumeroInteiro % 5 == 0)
            {
                Console.WriteLine($"O número: {_NumeroInteiro} é divisível por 3 e 5");
            }
            else
            {
                Console.WriteLine($"O número: {_NumeroInteiro} não é divisível por 3 e 5");
            }
        }

        //11. Leia uma idade e exiba uma mensagem informando se é maior de idade.
        public override void Exercicio11()
        {
            int _NumeroInteiro;
            Console.WriteLine("Digite sua idade:");
            _NumeroInteiro = int.Parse(Console.ReadLine());

            if (_NumeroInteiro >= 18)
            {
                Console.WriteLine("Você é maior de idade");
            }
            else
            {
                Console.WriteLine("Você não é maior de idade");
            }
        }

        //12. Leia um valor em graus Celsius e converta para Fahrenheit.
        public override void Exercicio12()
        {
            double numeroDouble;
            Console.WriteLine("Digite a temperatura em Celsius:");
            numeroDouble = double.Parse(Console.ReadLine());

            var temperaturaFahrenheit = numeroDouble * 1.8 + 32;
            Console.WriteLine($"A temperatura em Fahrenheit: {temperaturaFahrenheit}");
        }

        //13. Crie um programa que recebe três números e exibe a média aritmética.
        public override void Exercicio13()
        {
            int _NumeroInteiro;
            int _NumeroInteiro1;
            int _NumeroInteiro2;
            Console.WriteLine("Digite três números inteiros para o cálculo da média:");
            _NumeroInteiro = int.Parse(Console.ReadLine());
            _NumeroInteiro1 = int.Parse(Console.ReadLine());
            _NumeroInteiro2 = int.Parse(Console.ReadLine());

            int media = (_NumeroInteiro + _NumeroInteiro1 + _NumeroInteiro2) / 3;
            Console.WriteLine($"A média é: {media}");
        }

        //14. Declare uma variável que representa um salário e calcule um aumento de 10%.
        public override void Exercicio14()
        {
            double numeroDouble = 1518.00;

            double salarioComAumento = numeroDouble * 1.10;
            Console.WriteLine($"O salário com aumento de 10% é {salarioComAumento}");
        }

        //15. Crie uma variável do tipo string e concatene com outra variável para formar uma frase.
        public override void Exercicio15()
        {
            string nomeAluno = "Willian Filipe Silva";
            string nomeCurso = "Csharp";

            string nomeAlunoECurso = $"O aluno {nomeAluno} está cursando: {nomeCurso}";
            Console.WriteLine(nomeAlunoECurso);
        }

        //16. Crie um programa que leia um número decimal e converta para inteiro.
        public override void Exercicio16()
        {
            Console.WriteLine("Digite um número decimal:");
            float numeroFloat = float.Parse(Console.ReadLine());

            int _NumeroInteiro = (int)numeroFloat;
            Console.WriteLine($"Número: {numeroFloat} convertido para inteiro: {_NumeroInteiro}");
        }

        //17. Verifique se um número fornecido pelo usuário está entre 1 e 100.
        public override void Exercicio17()
        {
            int _NumeroInteiro;
            Console.WriteLine("Digite um número inteiro para verificar se está entre 1 e 100:");
            _NumeroInteiro = int.Parse(Console.ReadLine());

            if (_NumeroInteiro > 1 && _NumeroInteiro < 100)
            {
                Console.WriteLine($"O número {_NumeroInteiro} está entre 1 e 100");
            }
            else
            {
                Console.WriteLine($"O número {_NumeroInteiro} não está entre 1 e 100");
            }
        }
        //18. Leia um texto e exiba o número de caracteres usando Length.
        public override void Exercicio18()
        {
            Console.WriteLine("Digite um texto para contarmos os caracteres");
            string texto = Console.ReadLine();

            Console.WriteLine($"O texto {texto}, tem: {texto.Length} letras");
        }

        //19. Receba duas strings e compare se elas são iguais, ignorando maiúsculas e minúsculas.
        public override void Exercicio19()
        {
            Console.WriteLine("Digite dois textos para compararmos se são iguais");
            string texto = Console.ReadLine();

            Console.WriteLine("Digite o segundo texto");
            string texto1 = Console.ReadLine();

            if (texto.Equals(texto1, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Os textos são iguais!");
            }
            else
            {
                Console.WriteLine("Os textos não são iguais!");
            }
        }
    }
}