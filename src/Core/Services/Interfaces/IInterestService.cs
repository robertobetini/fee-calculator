namespace Core.Services.Interfaces
{
    public interface IInterestService
    {
        decimal Calculate(decimal valorInicial, double juros, int meses);
    }
}
