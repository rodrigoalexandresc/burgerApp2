using BurgerApp2.Domain;
using BurgerApp2.Domain.Enums;
using BurgerApp2.Domain.Promocoes;
using System;
using System.Linq;

namespace BurgerApp2.Models.Promocoes
{
    public class MuitaCarne : IPromocao
    {
        public int Prioridade => 2;

        public decimal CalcularDesconto(Lanche lanche)
        {
            var carne = lanche.Ingredientes.FirstOrDefault(a => a.Tipo == IngredienteTipoEnum.HamburgerDeCarne);
            if (carne != null && carne.Quantidade >= 3)
            {
                return carne.ValorUnitario * Math.Floor(carne.Quantidade / 3m);
            }
            return 0;
        }
    }
}
