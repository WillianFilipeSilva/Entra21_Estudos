using ExerciciosCSharp.ExerciciosPOO.LoucadoraDeVeiculos.Interfaces;

namespace ExerciciosCSharp.ExerciciosPOO.LoucadoraDeVeiculos.Objetos.Veiculo.Carro
{
    public class Carro : VeiculoBase.VeiculoBase
    {
        public Carro(string modelo, string marca, int ano, double valorDiaria) : base(modelo, marca, ano, valorDiaria) { }

        public override double CalcularAluguel(int dias) 
        {
            if (dias < 0)
            {
                Console.WriteLine($"Quantidade {dias} não é válida.");
                return 0;
            }
            return dias * ValorDiaria;
        }
    }
}