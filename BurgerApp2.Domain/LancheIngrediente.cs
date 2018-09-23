using BurgerApp2.Domain.Enums;

namespace BurgerApp2.Domain
{
    public class LancheIngrediente
    {
        public LancheIngrediente(IngredienteTipoEnum tipo, decimal quantidade, decimal valorUnitario)
        {
            Tipo = tipo;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
        }

        public IngredienteTipoEnum Tipo { get; private set; }
        public decimal Quantidade { get; private set; }
        public decimal ValorUnitario { get; private set; }
    }
}
