using Core.Services;
using Core.Services.Interfaces;

namespace Core.Tests.Services.InterestServiceTests
{
    public abstract class InterestServiceTests
    {
        protected readonly IInterestService _sut;

        public InterestServiceTests()
        {
            _sut = new InterestService();
        }
    }
}
