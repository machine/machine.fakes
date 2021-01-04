using Machine.Fakes.Internal;
using Machine.Specifications;

namespace Machine.Fakes.Adapters.Specs
{
    public class WithCurrentEngine<TEngine> where TEngine : IFakeEngine, new()
    {
        Establish context = () => FakeEngineGateway.EngineIs(new TEngine());
    }
}