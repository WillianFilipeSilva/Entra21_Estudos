namespace ExerciciosCSharp.ExerciciosLogica
{
    public class EstruturasDeSelecao : Base
    {
        public override void Executar()
        {
            try
            {
                lista = new Dictionary<int, (string, Action)>
                {
                    { 1, ("Verificar se um número é positivo ou negativo", Exercicio1) },
                    { 2, ("Determinar se um usuário é maior de idade", Exercicio2) },
                    { 3, ("Verificar se um número é par ou ímpar", Exercicio3) },
                    { 4, ("Determinar se um aluno passou no exame", Exercicio4) },
                    { 5, ("Verificar se um número é múltiplo de 5", Exercicio5) },
                    { 6, ("Determinar categoria de peso pelo IMC", Exercicio6) },
                    { 7, ("Verificar se um ano é bissexto", Exercicio7) },
                    { 8, ("Determinar o maior de três números", Exercicio8) },
                    { 9, ("Calcular o desconto de um produto", Exercicio9) },
                    { 10, ("Exibir mensagem de boas-vindas baseada na idade", Exercicio10) },
                    { 11, ("Verificar se um número é positivo, negativo ou zero", Exercicio11) },
                    { 12, ("Simular pedido de café e perguntar sobre açúcar", Exercicio12) },
                    { 13, ("Verificar se pelo menos dois números são iguais", Exercicio13) },
                    { 14, ("Simular um caixa eletrônico", Exercicio14) },
                    { 15, ("Simular controle de acesso a um edifício", Exercicio15) },
                    { 16, ("Calculadora simples", Exercicio16) },
                    { 17, ("Conversor de unidades", Exercicio17) },
                    { 18, ("Exibir saudação em diferentes idiomas", Exercicio18) },
                    { 19, ("Exibir o nome do mês correspondente a um número", Exercicio19) },
                    { 20, ("Verificar se um número é par ou ímpar usando operador ternário", Exercicio20) },
                    { 21, ("Calcular desconto baseado em status VIP", Exercicio21) },
                    { 22, ("Determinar aprovação de aluno com operador ternário", Exercicio22) },
                    { 23, ("Classificar idade como criança, adolescente ou adulto", Exercicio23) },
                };

                Menu(lista);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro na execução do menu: {ex.Message}");
            }
        }

        //Exercícios condição simples(if).
        //1.Escreva um programa que verifique se um número é positivo ou negativo e exiba uma mensagem correspondente.
        public override void Exercicio1()
        {
            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());

            if (numero > 0)
                Console.WriteLine("O número é positivo.");
            else if (numero < 0)
                Console.WriteLine("O número é negativo.");
            else
                Console.WriteLine("O número é zero.");
        }

        //2.Crie um programa que determine se um usuário é maior de idade(idade igual ou acima de 18 anos) e exiba uma mensagem apropriada.
        public override void Exercicio2()
        {
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
                Console.WriteLine("Você é maior de idade.");
            else
                Console.WriteLine("Você é menor de idade.");
        }

        //3.Desenvolva um programa que verifique se um número é par ou ímpar e exiba o resultado.
        public override void Exercicio3()
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("O número é par.");
            else
                Console.WriteLine("O número é ímpar.");
        }

        //4.Faça um programa que determine se um aluno passou em um exame, considerando que a nota mínima para aprovação é 60.
        public override void Exercicio4()
        {
            Console.Write("Digite a nota do aluno: ");
            double nota = double.Parse(Console.ReadLine());

            if (nota >= 60)
                Console.WriteLine("Aluno aprovado.");
            else
                Console.WriteLine("Aluno reprovado.");
        }

        //5.Escreva um programa que verifique se um número digitado pelo usuário é múltiplo de 5.
        public override void Exercicio5()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 5 == 0)
                Console.WriteLine("O número é múltiplo de 5.");
            else
                Console.WriteLine("O número não é múltiplo de 5.");
        }

        //Exercícios condição composta(if-else).
        //1.Crie um programa que, dado o peso e a altura de uma pessoa, determine se ela está abaixo do peso, com peso normal, com sobrepeso ou obesa, de acordo com o índice de massa corporal(IMC).
        public override void Exercicio6()
        {
            Console.Write("Digite seu peso (kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite sua altura (m): ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);
            if (imc < 18.5)
                Console.WriteLine("Abaixo do peso.");
            else if (imc < 25)
                Console.WriteLine("Peso normal.");
            else if (imc < 30)
                Console.WriteLine("Sobrepeso.");
            else
                Console.WriteLine("Obeso.");
        }

        //2.Desenvolva um programa que determine se um ano é bissexto ou não.Um ano é bissexto se for divisível por 4, mas não por 100, a menos que seja divisível por 400.
        public override void Exercicio7()
        {
            Console.Write("Digite um ano: ");
            int ano = int.Parse(Console.ReadLine());

            if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
                Console.WriteLine("Ano bissexto.");
            else
                Console.WriteLine("Ano não bissexto.");
        }

        //3.Faça um programa que determine o maior de três números digitados pelo usuário.
        public override void Exercicio8()
        {
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            int num3 = int.Parse(Console.ReadLine());
            int maior = num1;
            if (num2 > maior)
                maior = num2;
            if (num3 > maior)
                maior = num3;
            Console.WriteLine("O maior número é: " + maior);
        }

        //4.Escreva um programa que calcule o preço de um produto com desconto de 10 % se o valor total da compra for maior ou igual a R$100.
        public override void Exercicio9()
        {
            Console.Write("Digite o valor total da compra: ");
            double valor = double.Parse(Console.ReadLine());

            if (valor >= 100)
            {
                double desconto = valor * 0.10;
                double precoFinal = valor - desconto;
                Console.WriteLine("Preço com desconto: R$" + precoFinal);
            }
            else
            {
                Console.WriteLine("Preço sem desconto: R$" + valor);
            }
        }

        //5.Crie um programa que solicite o nome e a idade de um usuário e, com base na idade, apresente mensagens de boas - vindas apropriadas: "Bem-vindo, [Nome]!" para idades até 12 anos, "Olá, [Nome]!" para idades entre 13 e 19 anos, e "Olá, Sr./Sra. [Nome]!" para idades acima de 19 anos.
        public override void Exercicio10()
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade <= 12)
                Console.WriteLine("Bem-vindo, " + nome + "!");
            else if (idade >= 13 && idade <= 19)
                Console.WriteLine("Olá, " + nome + "!");
            else
                Console.WriteLine("Olá, Sr./Sra. " + nome + "!");
        }

        //Exercícios operadores lógicos
        //1.Crie um programa que verifique se um número digitado pelo usuário é positivo, negativo ou zero.Imprima a mensagem correspondente.
        public override void Exercicio11()
        {
            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());

            string resultado = numero > 0 ? "positivo" : numero < 0 ? "negativo" : "zero";
            Console.WriteLine("O número é " + resultado + ".");
        }

        //2.Desenvolva um programa que pergunte ao usuário se deseja um café. Se o usuário digitar "sim", pergunte se ele quer açúcar.Com base nas respostas, exiba uma mensagem adequada, como "Aqui está o seu café preto." ou "Aqui está o seu café com açúcar."
        public override void Exercicio12()
        {
            Console.Write("Deseja um café? (sim/não): ");
            string resposta = Console.ReadLine().ToLower();

            if (resposta == "sim")
            {
                Console.Write("Quer açúcar? (sim/não): ");
                string acucar = Console.ReadLine().ToLower();

                if (acucar == "sim")
                    Console.WriteLine("Aqui está o seu café com açúcar.");
                else
                    Console.WriteLine("Aqui está o seu café preto.");
            }
            else
            {
                Console.WriteLine("Café não solicitado.");
            }
        }

        //3.Crie um programa que peça ao usuário para digitar três números inteiros.Verifique se pelo menos dois dos números são iguais entre si.Se sim, imprima "Pelo menos dois números são iguais", caso contrário, imprima "Nenhum dos números é igual aos outros."
        public override void Exercicio13()
        {
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 == num2 || num1 == num3 || num2 == num3)
                Console.WriteLine("Pelo menos dois números são iguais.");
            else
                Console.WriteLine("Nenhum dos números é igual aos outros.");
        }

        //4.Escreva um programa que simule um caixa eletrônico.Peça ao usuário para digitar o saldo da conta e o valor que deseja sacar.Verifique se há saldo suficiente na conta.Se houver, imprima "Saque autorizado." Se não houver saldo suficiente, imprima "Saldo insuficiente."
        public override void Exercicio14()
        {
            Console.Write("Digite o saldo da conta: ");
            double saldo = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do saque: ");
            double saque = double.Parse(Console.ReadLine());

            if (saque <= saldo)
                Console.WriteLine("Saque autorizado.");
            else
                Console.WriteLine("Saldo insuficiente.");
        }

        //5.Crie um programa que simule um sistema de controle de acesso a um edifício.Peça ao usuário para digitar sua identificação e a hora de entrada.O acesso é permitido apenas se a identificação for válida(por exemplo, "12345") e se a hora de entrada estiver entre 9h e 18h.Imprima uma mensagem informando se o acesso foi autorizado ou negado.
        public override void Exercicio15()
        {
            Console.Write("Digite sua identificação: ");
            string identificacao = Console.ReadLine();

            Console.Write("Digite a hora de entrada (0-23): ");
            int hora = int.Parse(Console.ReadLine());

            if (identificacao == "12345" && hora >= 9 && hora <= 18)
                Console.WriteLine("Acesso autorizado.");
            else
                Console.WriteLine("Acesso negado.");
        }

        //Exercícios Switch Case
        //1.Calculadora Simples: Crie uma calculadora simples que solicite ao usuário dois números e um operador(+, -, *, /).Use switch case para realizar a operação escolhida e mostrar o resultado.
        public override void Exercicio16()
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
        }

        //2.Conversão de Unidades: Crie um conversor de unidades que permita ao usuário escolher entre converter uma quantidade em metros para centímetros ou centímetros para metros usando switch case.
        public override void Exercicio17()
        {
            Console.WriteLine("Escolha a conversão:");
            Console.WriteLine("1 - Metros para centímetros");
            Console.WriteLine("2 - Centímetros para metros");
            Console.Write("Opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o valor em metros: ");
                    double metros = double.Parse(Console.ReadLine());
                    Console.WriteLine(metros + " metros = " + (metros * 100) + " centímetros.");
                    break;
                case 2:
                    Console.Write("Digite o valor em centímetros: ");
                    double centimetros = double.Parse(Console.ReadLine());
                    Console.WriteLine(centimetros + " centímetros = " + (centimetros / 100) + " metros.");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        //3.Seleção de Língua: Desenvolva um programa multilíngue que solicite ao usuário que escolha um idioma(1 para inglês, 2 para espanhol, 3 para francês) e exiba uma saudação de boas-vindas nesse idioma usando switch case.Se o idioma escolhido não estiver disponível, exiba uma mensagem informando que o idioma é inválido.
        public override void Exercicio18()
        {
            Console.WriteLine("Escolha um idioma:");
            Console.WriteLine("1 - Inglês");
            Console.WriteLine("2 - Espanhol");
            Console.WriteLine("3 - Francês");
            Console.Write("Opção: ");
            int idioma = int.Parse(Console.ReadLine());

            switch (idioma)
            {
                case 1:
                    Console.WriteLine("Welcome!");
                    break;
                case 2:
                    Console.WriteLine("¡Bienvenido!");
                    break;
                case 3:
                    Console.WriteLine("Bienvenue!");
                    break;
                default:
                    Console.WriteLine("Idioma inválido.");
                    break;
            }
        }

        //4.Conversão de Meses: Desenvolva um conversor de meses que solicite ao usuário um número de 1 a 12, representando um mês do ano.Use switch case para exibir o nome do mês correspondente. Se o número estiver fora do intervalo, mostre uma mensagem de erro
        public override void Exercicio19() 
        {
            Console.Write("Digite um número de 1 a 12: ");
            int mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;
                case 2:
                    Console.WriteLine("Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("Março");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Maio");
                    break;
                case 6:
                    Console.WriteLine("Junho");
                    break;
                case 7:
                    Console.WriteLine("Julho");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Setembro");
                    break;
                case 10:
                    Console.WriteLine("Outubro");
                    break;
                case 11:
                    Console.WriteLine("Novembro");
                    break;
                case 12:
                    Console.WriteLine("Dezembro");
                    break;
                default:
                    Console.WriteLine("Mês inválido.");
                    break;
            }
        }

        //Exercícios Operador Ternário
        //1.Verificação de Paridade: Escreva uma função chamada VerificarParidade que recebe um número inteiro como argumento e retorna uma string "Par" se o número for par e "Ímpar" se for ímpar.
        public override void Exercicio20()
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            string paridade = (numero % 2 == 0) ? "Par" : "Ímpar";
            Console.WriteLine("O número é " + paridade + ".");
        }

        //2.Calculadora de Desconto: Crie uma função chamada CalcularDesconto que recebe o preço de um produto e um booleano indicando se o cliente é um membro VIP.Se o cliente for VIP, o desconto é de 20 %; caso contrário, o desconto é de 10 %.A função deve retornar o preço com o desconto aplicado.
        public override void Exercicio21() 
        {
            Console.Write("Digite o preço do produto: ");
            double preco = double.Parse(Console.ReadLine());

            Console.Write("É cliente VIP? (sim/não): ");
            string vipInput = Console.ReadLine().ToLower();

            bool isVIP = vipInput == "sim";
            double precoComDesconto = isVIP ? preco * 0.8 : preco * 0.9;
            Console.WriteLine("Preço com desconto: R$" + precoComDesconto);
        }

        //3.Classificação de Aluno: Crie um programa que solicita ao usuário a nota de um aluno e determine se ele foi aprovado ou reprovado.Use o operador ternário para definir a aprovação com base na nota(por exemplo, notas maiores ou iguais a 6 são aprovadas).
        public override void Exercicio22() 
        {
            Console.Write("Digite a nota do aluno: ");
            double nota = double.Parse(Console.ReadLine());

            string resultado = (nota >= 6) ? "Aprovado" : "Reprovado";
            Console.WriteLine("O aluno está: " + resultado);
        }

        //4.Avaliação de Idade: Crie uma função chamada ClassificarIdade que recebe a idade de uma pessoa como argumento e retorna uma string indicando se a pessoa é uma "Criança"(até 12 anos), "Adolescente"(de 13 a 19 anos) ou "Adulto"(20 anos ou mais).
        public override void Exercicio23() 
        {
            Console.Write("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());

            string classificacao = (idade <= 12) ? "Criança" : (idade <= 19) ? "Adolescente" : "Adulto";
            Console.WriteLine("Classificação: " + classificacao);
        }
    }
}