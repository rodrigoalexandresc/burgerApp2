using BurgerApp2.Domain;
using BurgerApp2.Domain.Enums;
using BurgerApp2.Domain.Promocoes;
using System.Linq;

namespace BurgerApp2.Models.Promocoes
{
    public class Light : IPromocao
    {
        public int Prioridade => 1;

        public decimal CalcularDesconto(Lanche lanche)
        {
            if (lanche.Ingredientes.Any(a => a.Tipo == IngredienteTipoEnum.Alface) && (!lanche.Ingredientes.Any(a => a.Tipo == IngredienteTipoEnum.Bacon)))
            {
                return lanche.ValorBruto * 0.1m;
            }
            return 0;
        }
    }
}
