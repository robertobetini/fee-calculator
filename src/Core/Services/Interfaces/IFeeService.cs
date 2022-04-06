namespace Core.Services.Interfaces
{
    public interface IFeeService
    {
        decimal Calculate(decimal valorInicial, double juros, int meses);
    }
}
