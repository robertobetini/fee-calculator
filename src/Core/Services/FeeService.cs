using Core.Services.Interfaces;
using System;

namespace Core.Services
{
    public class FeeService : IFeeService
    {
        public decimal Calculate(decimal valorInicial, double juros, int meses)
        {
            if (valorInicial <= decimal.Zero)
                throw new ArgumentException($"'{nameof(valorInicial)}' must be greater than 0.");

            if (juros <= 0)
                throw new ArgumentException($"'{nameof(juros)}' must be greather than 0.");

            if (meses < 1)
                throw new ArgumentException($"'{nameof(meses)}' must be greather than 0.");

            var result = valorInicial * (decimal)Math.Pow(1 + juros, meses);
            return Math.Truncate(result * 100) / 100;
        }
    }
}
