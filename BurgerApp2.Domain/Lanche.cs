using BurgerApp2.Domain.Promocoes;
using System.Collections.Generic;
using System.Linq;

namespace BurgerApp2.Domain
{
    public class Lanche
    {
        public Lanche(string descricao, IList<LancheIngrediente> lancheIngredientes)
        {
            this.Descricao = descricao;
            this.Ingredientes = lancheIngredientes;
            this.Promocoes = PromocoesVigentes.instance.Promocoes;
        }

        public string Descricao { get; private set; }

        public IList<LancheIngrediente> Ingredientes { get; private set; }

        public string ListaIngredientes
        {
            get
            {
                return string.Join(", ", Ingredientes.Select(i => i.Tipo.ToString()));
            }
        }

        readonly IList<IPromocao> Promocoes;

        public decimal ValorBruto
        {
            get
            {
                return Ingredientes.Sum(ing => ing.Quantidade * ing.ValorUnitario);
            }
        }

        public decimal ValorTotal 
        {
            get
            {
                var valor = AplicarPromocoes(ValorBruto);
                return valor;
            }
        }

        private decimal AplicarPromocoes(decimal valor)
        {
            foreach (var promocao in Promocoes)
            {
                var desconto = promocao.CalcularDesconto(this);
                if (desconto > 0)
                {
                    valor = valor - desconto;
                    break;
                }
            }

            return valor;
        }
    }


}
