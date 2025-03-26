using ExerciciosCSharp.ExerciciosPOO.LoucadoraDeVeiculos.Interfaces;

namespace ExerciciosCSharp.ExerciciosPOO.LoucadoraDeVeiculos.Objetos.Veiculo.VeiculoBase
{
    public class VeiculoBase : IVeiculo
    {
        protected string Modelo { get; set; }

        protected string Marca { get; set; }

        protected int Ano { get; set; }

        protected double ValorDiaria { get; set; }

        public VeiculoBase(string modelo, string marca, int ano, double valorDiaria)
        {
            Modelo = modelo;
            Marca = marca;
            Ano = ano;
            ValorDiaria = valorDiaria;
        }

        public virtual double CalcularAluguel(int dias)
        {
            throw new NotImplementedException();
        }
    }
}