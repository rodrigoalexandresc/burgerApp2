namespace BurgerApp2.Domain.Promocoes
{
    public interface IPromocao
    {
        int Prioridade { get; }
        decimal CalcularDesconto(Lanche lanche);
    }
}
