using BurgerApp2.Domain;
using BurgerApp2.Domain.Enums;
using BurgerApp2.Domain.Promocoes;
using System;
using System.Linq;

namespace BurgerApp2.Models.Promocoes
{
    public class MuitoQueijo : IPromocao
    {
        public int Prioridade => 3;

        public decimal CalcularDesconto(Lanche lanche)
        {
            var queijo = lanche.Ingredientes.FirstOrDefault(a => a.Tipo == IngredienteTipoEnum.Queijo);
            if (queijo != null && queijo.Quantidade >= 3)
            {
                var desconto = queijo.ValorUnitario * Math.Floor(queijo.Quantidade / 3m);
                return desconto;
            }

            return 0;
        }
    }
}
