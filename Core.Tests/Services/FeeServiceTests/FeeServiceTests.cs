using Core.Services;
using Core.Services.Interfaces;

namespace Core.Tests.Services.FeeServiceTests
{
    public abstract class FeeServiceTests
    {
        protected readonly IFeeService _sut;

        public FeeServiceTests()
        {
            _sut = new FeeService();
        }
    }
}
