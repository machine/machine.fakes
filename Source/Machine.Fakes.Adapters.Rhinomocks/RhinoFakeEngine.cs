using System;
using System.Linq.Expressions;
using Machine.Fakes.Sdk;
using Rhino.Mocks;
using Rhino.Mocks.Interfaces;

namespace Machine.Fakes.Adapters.Rhinomocks
{
    public class RhinoFakeEngine : RewritingFakeEngine
    {
        public RhinoFakeEngine() : base(new RhinoMocksExpressionRewriter()) {}

        public override object CreateFake(Type interfaceType, params object[] args)
        {
            var stub = MockRepository.GenerateMock(interfaceType, new Type[0], args);
            RhinoPropertyBehavior.RegisterPropertyBehavior((IMockedObject) stub);
            stub.Replay();
            return stub;
        }

        public override T PartialMock<T>(params object[] args)
        {
            var mock = MockRepository.GeneratePartialMock<T>(args);
            mock.Replay();
            return mock;
        }

        protected override IQueryOptions<TReturnValue> OnSetUpQueryBehaviorFor<TDependency, TReturnValue>(
            TDependency fake,
            Expression<Func<TDependency, TReturnValue>> func)
        {
            if (IsPropertyAccess(func))
            {
                RhinoPropertyBehavior.RemovePropertiesBehavior(fake);
            }
            var compiledFunction = func.Compile();

            return new RhinoQueryOptions<TReturnValue>(fake.Stub(f => compiledFunction(f)));
        }


        bool IsPropertyAccess<TDependency, TReturnValue>(Expression<Func<TDependency, TReturnValue>> func)
        {
            return !(func.Body is MethodCallExpression);
        }

        protected override ICommandOptions OnSetUpCommandBehaviorFor<TFake>(
            TFake fake,
            Expression<Action<TFake>> func)
        {
            var compiledFunction = func.Compile();

            return new RhinoCommandOptions(fake.Stub(compiledFunction));
        }

        protected override void OnVerifyBehaviorWasNotExecuted<TFake>(
            TFake fake,
            Expression<Action<TFake>> func)
        {
            var compiledFunction = func.Compile();

            fake.AssertWasNotCalled(compiledFunction);
        }

        protected override IMethodCallOccurance OnVerifyBehaviorWasExecuted<TFake>(
            TFake fake,
            Expression<Action<TFake>> func)
        {
            var compiledFunction = func.Compile();

            return new RhinoMethodCallOccurance<TFake>(fake, compiledFunction);
        }
    }
}