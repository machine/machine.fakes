﻿






using Machine.Fakes.Adapters.Specs.SampleCode;
using Machine.Fakes.Internal;
using Machine.Specifications;


#if !NETSTANDARD


namespace Machine.Fakes.Adapters.Specs.Rhinomocks
{

	using Machine.Fakes.Adapters.Rhinomocks;


    [Subject(typeof(RhinoFakeEngine))]
    public class When_matching_any_parameter_value_and_passing_null : WithCurrentEngine<RhinoFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param.IsAny<string>(), Param.IsAny<string>()))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin(null, null);

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(RhinoFakeEngine))]
    public class When_matching_any_nullable_parameter_value_and_passing_null : WithCurrentEngine<RhinoFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.AreBothOdd(Param.IsAny<int?>(), Param.IsAny<int?>()))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.AreBothOdd(null, null);

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }


    [Subject(typeof(RhinoFakeEngine))]
    public class When_matching_any_nullable_parameter_value_and_passing_non_null : WithCurrentEngine<RhinoFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.AreBothOdd(Param.IsAny<int?>(), Param.IsAny<int?>()))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.AreBothOdd(2, 4);

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(RhinoFakeEngine))]
    public class When_matching_any_parameter_value_and_passing_a_non_null_value : WithCurrentEngine<RhinoFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param.IsAny<string>(), Param.IsAny<string>()))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("NON_NULL", "ALSO_NON_NULL");

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(RhinoFakeEngine))] 
    public class When_matching_only_non_null_parameter_values_and_passing_in_null : WithCurrentEngine<RhinoFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param<string>.IsNotNull, Param<string>.IsNotNull))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin(null, null);

        It should_not_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeFalse();
    }

    [Subject(typeof(RhinoFakeEngine))] 
    public class When_matching_only_non_null_parameter_values_and_passing_in_non_null_values : WithCurrentEngine<RhinoFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param<string>.IsNotNull, Param<string>.IsNotNull))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("NON_NULL", "ALSO_NON_NULL");

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(RhinoFakeEngine))]
    public class When_matching_only_non_null_parameter_values_and_passing_in_non_null_nullable_values : WithCurrentEngine<RhinoFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.AreBothOdd(Param<int?>.IsNotNull, Param<int?>.IsNotNull))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.AreBothOdd(3, 5);

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(RhinoFakeEngine))]
    public class When_matching_only_non_null_parameter_values_and_passing_in_null_nullable_values : WithCurrentEngine<RhinoFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.AreBothOdd(Param<int?>.IsNotNull, Param<int?>.IsNotNull))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.AreBothOdd(null, null);

        It should_not_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeFalse();
    }

    [Subject(typeof(RhinoFakeEngine))] 
    public class When_matching_only_null_parameter_values_and_passing_in_null : WithCurrentEngine<RhinoFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param<string>.IsNull, Param<string>.IsNull))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin(null, null);

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(RhinoFakeEngine))] 
    public class When_matching_only_null_parameter_values_and_passing_in_non_null_values : WithCurrentEngine<RhinoFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param<string>.IsNull, Param<string>.IsNull))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("NON_NULL", "ALSO_NON_NULL");

        It should_not_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeFalse();
    }

    [Subject(typeof(RhinoFakeEngine))] 
    public class When_matching_only_on_a_particular_value_and_passing_in_that_value : WithCurrentEngine<RhinoFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param.Is("John"), Param.Is("Doe")))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("John", "Doe");

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }
    
    [Subject(typeof(RhinoFakeEngine))] 
    public class When_matching_only_on_a_particular_value_and_passing_different_values : WithCurrentEngine<RhinoFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param.Is("John"), Param.Is("Doe")))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("NOT_John", "NOT_Doe");

        It should_not_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeFalse();
    }
    
    [Subject(typeof(RhinoFakeEngine))] 
    public class When_matching_on_a__NewExpression__ : WithCurrentEngine<RhinoFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param.Is(new string(new[] { 'a' })), Param.Is(new string(new[] { 'b' }))))
                 .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("a", "b");

        It should_match_based_on_equality = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }
    
    [Subject(typeof(RhinoFakeEngine))] 
    public class When_matching_on_a_field_expression : WithCurrentEngine<RhinoFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;
        static string a = "a";
        static string b = "b";

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param.Is(a), Param.Is(b)))
                 .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("a", "b");

        It should_match_against_the_member_value = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }
    
    [Subject(typeof(RhinoFakeEngine))] 
    public class When_matching_on_a_method_call_expression : WithCurrentEngine<RhinoFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        static string A() { return "a"; }
        static string B() { return "b"; }

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param.Is(A()), Param.Is(B())))
                 .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("a", "b");

        It should_match_against_the_method_result = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(RhinoFakeEngine))] 
    public class When_matching_using_expressions_and_passing_in_a_value_that_matches_the_expression : WithCurrentEngine<RhinoFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(
                    Param<string>.Matches(p1 => p1.StartsWith("J")), 
                    Param<string>.Matches(p2 => p2.StartsWith("D"))))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("John", "Doe");

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }
    
    [Subject(typeof(RhinoFakeEngine))] 
    public class When_matching_using_expressions_and_passing_in_a_value_that_does_not_match_the_expression : WithCurrentEngine<RhinoFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(
                    Param<string>.Matches(p1 => p1.StartsWith("J")),
                    Param<string>.Matches(p2 => p2.StartsWith("D"))))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("NOT_John", "NOT_Doe");

        It should_not_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeFalse();
    }

    [Subject(typeof(RhinoFakeEngine))] 
    public class When_matching_only_when_a_type_implements_an_interface_and_the_parameter_value_implements_that_interface
        : WithCurrentEngine<RhinoFakeEngine>
    {
        static IFlashVerifier _flashVerifier;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _flashVerifier = FakeEngineGateway.Fake<IFlashVerifier>();

            _flashVerifier
                .WhenToldTo(v => v.CanPlayFlash(Param<ITablet>.IsA<ICanPlayFlash>()))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _flashVerifier.CanPlayFlash(new Xoom());

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(RhinoFakeEngine))] 
    public class When_matching_only_when_a_type_implements_an_interface_and_the_parameter_value_does_not_implement_that_interface
        : WithCurrentEngine<RhinoFakeEngine>
    {
        static IFlashVerifier _flashVerifier;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _flashVerifier = FakeEngineGateway.Fake<IFlashVerifier>();

            _flashVerifier
                .WhenToldTo(v => v.CanPlayFlash(Param<ITablet>.IsA<ICanPlayFlash>()))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _flashVerifier.CanPlayFlash(new IPad());

        It should_not_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeFalse();
    }

    [Subject(typeof(RhinoFakeEngine))] 
    public class When_matching_for_equality_without_explicit__Param__constraint_and_the_passed_values_is_not_the_expected_ones
        : WithCurrentEngine<RhinoFakeEngine>
    {
        static IView _fake;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _fake = FakeEngineGateway.Fake<IView>();
            _fake.WhenToldTo(v => v.TryLogin("a", "c")).Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _fake.TryLogin("b", "c");

        It should_not_trigger_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeFalse();
    }

    [Subject(typeof(RhinoFakeEngine))] 
    public class When_matching_for_equality_without_explicit__Param__constraint_and_the_passed_values_are_the_expected_ones
        : WithCurrentEngine<RhinoFakeEngine>
    {
        static IView _fake;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _fake = FakeEngineGateway.Fake<IView>();
            _fake.WhenToldTo(v => v.TryLogin("a", null)).Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _fake.TryLogin("a", null);

        It should_trigger_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }
}

#endif






namespace Machine.Fakes.Adapters.Specs.NSubstitute
{

	using Machine.Fakes.Adapters.NSubstitute;


    [Subject(typeof(NSubstituteEngine))]
    public class When_matching_any_parameter_value_and_passing_null : WithCurrentEngine<NSubstituteEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param.IsAny<string>(), Param.IsAny<string>()))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin(null, null);

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(NSubstituteEngine))]
    public class When_matching_any_nullable_parameter_value_and_passing_null : WithCurrentEngine<NSubstituteEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.AreBothOdd(Param.IsAny<int?>(), Param.IsAny<int?>()))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.AreBothOdd(null, null);

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }


    [Subject(typeof(NSubstituteEngine))]
    public class When_matching_any_nullable_parameter_value_and_passing_non_null : WithCurrentEngine<NSubstituteEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.AreBothOdd(Param.IsAny<int?>(), Param.IsAny<int?>()))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.AreBothOdd(2, 4);

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(NSubstituteEngine))]
    public class When_matching_any_parameter_value_and_passing_a_non_null_value : WithCurrentEngine<NSubstituteEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param.IsAny<string>(), Param.IsAny<string>()))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("NON_NULL", "ALSO_NON_NULL");

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(NSubstituteEngine))] 
    public class When_matching_only_non_null_parameter_values_and_passing_in_null : WithCurrentEngine<NSubstituteEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param<string>.IsNotNull, Param<string>.IsNotNull))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin(null, null);

        It should_not_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeFalse();
    }

    [Subject(typeof(NSubstituteEngine))] 
    public class When_matching_only_non_null_parameter_values_and_passing_in_non_null_values : WithCurrentEngine<NSubstituteEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param<string>.IsNotNull, Param<string>.IsNotNull))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("NON_NULL", "ALSO_NON_NULL");

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(NSubstituteEngine))]
    public class When_matching_only_non_null_parameter_values_and_passing_in_non_null_nullable_values : WithCurrentEngine<NSubstituteEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.AreBothOdd(Param<int?>.IsNotNull, Param<int?>.IsNotNull))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.AreBothOdd(3, 5);

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(NSubstituteEngine))]
    public class When_matching_only_non_null_parameter_values_and_passing_in_null_nullable_values : WithCurrentEngine<NSubstituteEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.AreBothOdd(Param<int?>.IsNotNull, Param<int?>.IsNotNull))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.AreBothOdd(null, null);

        It should_not_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeFalse();
    }

    [Subject(typeof(NSubstituteEngine))] 
    public class When_matching_only_null_parameter_values_and_passing_in_null : WithCurrentEngine<NSubstituteEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param<string>.IsNull, Param<string>.IsNull))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin(null, null);

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(NSubstituteEngine))] 
    public class When_matching_only_null_parameter_values_and_passing_in_non_null_values : WithCurrentEngine<NSubstituteEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param<string>.IsNull, Param<string>.IsNull))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("NON_NULL", "ALSO_NON_NULL");

        It should_not_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeFalse();
    }

    [Subject(typeof(NSubstituteEngine))] 
    public class When_matching_only_on_a_particular_value_and_passing_in_that_value : WithCurrentEngine<NSubstituteEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param.Is("John"), Param.Is("Doe")))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("John", "Doe");

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }
    
    [Subject(typeof(NSubstituteEngine))] 
    public class When_matching_only_on_a_particular_value_and_passing_different_values : WithCurrentEngine<NSubstituteEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param.Is("John"), Param.Is("Doe")))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("NOT_John", "NOT_Doe");

        It should_not_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeFalse();
    }
    
    [Subject(typeof(NSubstituteEngine))] 
    public class When_matching_on_a__NewExpression__ : WithCurrentEngine<NSubstituteEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param.Is(new string(new[] { 'a' })), Param.Is(new string(new[] { 'b' }))))
                 .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("a", "b");

        It should_match_based_on_equality = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }
    
    [Subject(typeof(NSubstituteEngine))] 
    public class When_matching_on_a_field_expression : WithCurrentEngine<NSubstituteEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;
        static string a = "a";
        static string b = "b";

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param.Is(a), Param.Is(b)))
                 .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("a", "b");

        It should_match_against_the_member_value = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }
    
    [Subject(typeof(NSubstituteEngine))] 
    public class When_matching_on_a_method_call_expression : WithCurrentEngine<NSubstituteEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        static string A() { return "a"; }
        static string B() { return "b"; }

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param.Is(A()), Param.Is(B())))
                 .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("a", "b");

        It should_match_against_the_method_result = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(NSubstituteEngine))] 
    public class When_matching_using_expressions_and_passing_in_a_value_that_matches_the_expression : WithCurrentEngine<NSubstituteEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(
                    Param<string>.Matches(p1 => p1.StartsWith("J")), 
                    Param<string>.Matches(p2 => p2.StartsWith("D"))))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("John", "Doe");

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }
    
    [Subject(typeof(NSubstituteEngine))] 
    public class When_matching_using_expressions_and_passing_in_a_value_that_does_not_match_the_expression : WithCurrentEngine<NSubstituteEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(
                    Param<string>.Matches(p1 => p1.StartsWith("J")),
                    Param<string>.Matches(p2 => p2.StartsWith("D"))))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("NOT_John", "NOT_Doe");

        It should_not_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeFalse();
    }

    [Subject(typeof(NSubstituteEngine))] 
    public class When_matching_only_when_a_type_implements_an_interface_and_the_parameter_value_implements_that_interface
        : WithCurrentEngine<NSubstituteEngine>
    {
        static IFlashVerifier _flashVerifier;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _flashVerifier = FakeEngineGateway.Fake<IFlashVerifier>();

            _flashVerifier
                .WhenToldTo(v => v.CanPlayFlash(Param<ITablet>.IsA<ICanPlayFlash>()))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _flashVerifier.CanPlayFlash(new Xoom());

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(NSubstituteEngine))] 
    public class When_matching_only_when_a_type_implements_an_interface_and_the_parameter_value_does_not_implement_that_interface
        : WithCurrentEngine<NSubstituteEngine>
    {
        static IFlashVerifier _flashVerifier;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _flashVerifier = FakeEngineGateway.Fake<IFlashVerifier>();

            _flashVerifier
                .WhenToldTo(v => v.CanPlayFlash(Param<ITablet>.IsA<ICanPlayFlash>()))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _flashVerifier.CanPlayFlash(new IPad());

        It should_not_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeFalse();
    }

    [Subject(typeof(NSubstituteEngine))] 
    public class When_matching_for_equality_without_explicit__Param__constraint_and_the_passed_values_is_not_the_expected_ones
        : WithCurrentEngine<NSubstituteEngine>
    {
        static IView _fake;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _fake = FakeEngineGateway.Fake<IView>();
            _fake.WhenToldTo(v => v.TryLogin("a", "c")).Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _fake.TryLogin("b", "c");

        It should_not_trigger_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeFalse();
    }

    [Subject(typeof(NSubstituteEngine))] 
    public class When_matching_for_equality_without_explicit__Param__constraint_and_the_passed_values_are_the_expected_ones
        : WithCurrentEngine<NSubstituteEngine>
    {
        static IView _fake;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _fake = FakeEngineGateway.Fake<IView>();
            _fake.WhenToldTo(v => v.TryLogin("a", null)).Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _fake.TryLogin("a", null);

        It should_trigger_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }
}







namespace Machine.Fakes.Adapters.Specs.Moq
{

	using Machine.Fakes.Adapters.Moq;


    [Subject(typeof(MoqFakeEngine))]
    public class When_matching_any_parameter_value_and_passing_null : WithCurrentEngine<MoqFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param.IsAny<string>(), Param.IsAny<string>()))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin(null, null);

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(MoqFakeEngine))]
    public class When_matching_any_nullable_parameter_value_and_passing_null : WithCurrentEngine<MoqFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.AreBothOdd(Param.IsAny<int?>(), Param.IsAny<int?>()))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.AreBothOdd(null, null);

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }


    [Subject(typeof(MoqFakeEngine))]
    public class When_matching_any_nullable_parameter_value_and_passing_non_null : WithCurrentEngine<MoqFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.AreBothOdd(Param.IsAny<int?>(), Param.IsAny<int?>()))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.AreBothOdd(2, 4);

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(MoqFakeEngine))]
    public class When_matching_any_parameter_value_and_passing_a_non_null_value : WithCurrentEngine<MoqFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param.IsAny<string>(), Param.IsAny<string>()))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("NON_NULL", "ALSO_NON_NULL");

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(MoqFakeEngine))] 
    public class When_matching_only_non_null_parameter_values_and_passing_in_null : WithCurrentEngine<MoqFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param<string>.IsNotNull, Param<string>.IsNotNull))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin(null, null);

        It should_not_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeFalse();
    }

    [Subject(typeof(MoqFakeEngine))] 
    public class When_matching_only_non_null_parameter_values_and_passing_in_non_null_values : WithCurrentEngine<MoqFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param<string>.IsNotNull, Param<string>.IsNotNull))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("NON_NULL", "ALSO_NON_NULL");

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(MoqFakeEngine))]
    public class When_matching_only_non_null_parameter_values_and_passing_in_non_null_nullable_values : WithCurrentEngine<MoqFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.AreBothOdd(Param<int?>.IsNotNull, Param<int?>.IsNotNull))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.AreBothOdd(3, 5);

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(MoqFakeEngine))]
    public class When_matching_only_non_null_parameter_values_and_passing_in_null_nullable_values : WithCurrentEngine<MoqFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.AreBothOdd(Param<int?>.IsNotNull, Param<int?>.IsNotNull))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.AreBothOdd(null, null);

        It should_not_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeFalse();
    }

    [Subject(typeof(MoqFakeEngine))] 
    public class When_matching_only_null_parameter_values_and_passing_in_null : WithCurrentEngine<MoqFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param<string>.IsNull, Param<string>.IsNull))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin(null, null);

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(MoqFakeEngine))] 
    public class When_matching_only_null_parameter_values_and_passing_in_non_null_values : WithCurrentEngine<MoqFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param<string>.IsNull, Param<string>.IsNull))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("NON_NULL", "ALSO_NON_NULL");

        It should_not_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeFalse();
    }

    [Subject(typeof(MoqFakeEngine))] 
    public class When_matching_only_on_a_particular_value_and_passing_in_that_value : WithCurrentEngine<MoqFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param.Is("John"), Param.Is("Doe")))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("John", "Doe");

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }
    
    [Subject(typeof(MoqFakeEngine))] 
    public class When_matching_only_on_a_particular_value_and_passing_different_values : WithCurrentEngine<MoqFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param.Is("John"), Param.Is("Doe")))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("NOT_John", "NOT_Doe");

        It should_not_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeFalse();
    }
    
    [Subject(typeof(MoqFakeEngine))] 
    public class When_matching_on_a__NewExpression__ : WithCurrentEngine<MoqFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param.Is(new string(new[] { 'a' })), Param.Is(new string(new[] { 'b' }))))
                 .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("a", "b");

        It should_match_based_on_equality = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }
    
    [Subject(typeof(MoqFakeEngine))] 
    public class When_matching_on_a_field_expression : WithCurrentEngine<MoqFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;
        static string a = "a";
        static string b = "b";

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param.Is(a), Param.Is(b)))
                 .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("a", "b");

        It should_match_against_the_member_value = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }
    
    [Subject(typeof(MoqFakeEngine))] 
    public class When_matching_on_a_method_call_expression : WithCurrentEngine<MoqFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        static string A() { return "a"; }
        static string B() { return "b"; }

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param.Is(A()), Param.Is(B())))
                 .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("a", "b");

        It should_match_against_the_method_result = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(MoqFakeEngine))] 
    public class When_matching_using_expressions_and_passing_in_a_value_that_matches_the_expression : WithCurrentEngine<MoqFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(
                    Param<string>.Matches(p1 => p1.StartsWith("J")), 
                    Param<string>.Matches(p2 => p2.StartsWith("D"))))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("John", "Doe");

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }
    
    [Subject(typeof(MoqFakeEngine))] 
    public class When_matching_using_expressions_and_passing_in_a_value_that_does_not_match_the_expression : WithCurrentEngine<MoqFakeEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(
                    Param<string>.Matches(p1 => p1.StartsWith("J")),
                    Param<string>.Matches(p2 => p2.StartsWith("D"))))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("NOT_John", "NOT_Doe");

        It should_not_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeFalse();
    }

    [Subject(typeof(MoqFakeEngine))] 
    public class When_matching_only_when_a_type_implements_an_interface_and_the_parameter_value_implements_that_interface
        : WithCurrentEngine<MoqFakeEngine>
    {
        static IFlashVerifier _flashVerifier;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _flashVerifier = FakeEngineGateway.Fake<IFlashVerifier>();

            _flashVerifier
                .WhenToldTo(v => v.CanPlayFlash(Param<ITablet>.IsA<ICanPlayFlash>()))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _flashVerifier.CanPlayFlash(new Xoom());

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(MoqFakeEngine))] 
    public class When_matching_only_when_a_type_implements_an_interface_and_the_parameter_value_does_not_implement_that_interface
        : WithCurrentEngine<MoqFakeEngine>
    {
        static IFlashVerifier _flashVerifier;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _flashVerifier = FakeEngineGateway.Fake<IFlashVerifier>();

            _flashVerifier
                .WhenToldTo(v => v.CanPlayFlash(Param<ITablet>.IsA<ICanPlayFlash>()))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _flashVerifier.CanPlayFlash(new IPad());

        It should_not_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeFalse();
    }

    [Subject(typeof(MoqFakeEngine))] 
    public class When_matching_for_equality_without_explicit__Param__constraint_and_the_passed_values_is_not_the_expected_ones
        : WithCurrentEngine<MoqFakeEngine>
    {
        static IView _fake;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _fake = FakeEngineGateway.Fake<IView>();
            _fake.WhenToldTo(v => v.TryLogin("a", "c")).Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _fake.TryLogin("b", "c");

        It should_not_trigger_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeFalse();
    }

    [Subject(typeof(MoqFakeEngine))] 
    public class When_matching_for_equality_without_explicit__Param__constraint_and_the_passed_values_are_the_expected_ones
        : WithCurrentEngine<MoqFakeEngine>
    {
        static IView _fake;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _fake = FakeEngineGateway.Fake<IView>();
            _fake.WhenToldTo(v => v.TryLogin("a", null)).Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _fake.TryLogin("a", null);

        It should_trigger_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }
}







namespace Machine.Fakes.Adapters.Specs.FakeItEasy
{

	using Machine.Fakes.Adapters.FakeItEasy;


    [Subject(typeof(FakeItEasyEngine))]
    public class When_matching_any_parameter_value_and_passing_null : WithCurrentEngine<FakeItEasyEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param.IsAny<string>(), Param.IsAny<string>()))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin(null, null);

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(FakeItEasyEngine))]
    public class When_matching_any_nullable_parameter_value_and_passing_null : WithCurrentEngine<FakeItEasyEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.AreBothOdd(Param.IsAny<int?>(), Param.IsAny<int?>()))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.AreBothOdd(null, null);

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }


    [Subject(typeof(FakeItEasyEngine))]
    public class When_matching_any_nullable_parameter_value_and_passing_non_null : WithCurrentEngine<FakeItEasyEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.AreBothOdd(Param.IsAny<int?>(), Param.IsAny<int?>()))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.AreBothOdd(2, 4);

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(FakeItEasyEngine))]
    public class When_matching_any_parameter_value_and_passing_a_non_null_value : WithCurrentEngine<FakeItEasyEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param.IsAny<string>(), Param.IsAny<string>()))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("NON_NULL", "ALSO_NON_NULL");

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(FakeItEasyEngine))] 
    public class When_matching_only_non_null_parameter_values_and_passing_in_null : WithCurrentEngine<FakeItEasyEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param<string>.IsNotNull, Param<string>.IsNotNull))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin(null, null);

        It should_not_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeFalse();
    }

    [Subject(typeof(FakeItEasyEngine))] 
    public class When_matching_only_non_null_parameter_values_and_passing_in_non_null_values : WithCurrentEngine<FakeItEasyEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param<string>.IsNotNull, Param<string>.IsNotNull))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("NON_NULL", "ALSO_NON_NULL");

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(FakeItEasyEngine))]
    public class When_matching_only_non_null_parameter_values_and_passing_in_non_null_nullable_values : WithCurrentEngine<FakeItEasyEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.AreBothOdd(Param<int?>.IsNotNull, Param<int?>.IsNotNull))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.AreBothOdd(3, 5);

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(FakeItEasyEngine))]
    public class When_matching_only_non_null_parameter_values_and_passing_in_null_nullable_values : WithCurrentEngine<FakeItEasyEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.AreBothOdd(Param<int?>.IsNotNull, Param<int?>.IsNotNull))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.AreBothOdd(null, null);

        It should_not_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeFalse();
    }

    [Subject(typeof(FakeItEasyEngine))] 
    public class When_matching_only_null_parameter_values_and_passing_in_null : WithCurrentEngine<FakeItEasyEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param<string>.IsNull, Param<string>.IsNull))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin(null, null);

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(FakeItEasyEngine))] 
    public class When_matching_only_null_parameter_values_and_passing_in_non_null_values : WithCurrentEngine<FakeItEasyEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param<string>.IsNull, Param<string>.IsNull))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("NON_NULL", "ALSO_NON_NULL");

        It should_not_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeFalse();
    }

    [Subject(typeof(FakeItEasyEngine))] 
    public class When_matching_only_on_a_particular_value_and_passing_in_that_value : WithCurrentEngine<FakeItEasyEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param.Is("John"), Param.Is("Doe")))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("John", "Doe");

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }
    
    [Subject(typeof(FakeItEasyEngine))] 
    public class When_matching_only_on_a_particular_value_and_passing_different_values : WithCurrentEngine<FakeItEasyEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param.Is("John"), Param.Is("Doe")))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("NOT_John", "NOT_Doe");

        It should_not_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeFalse();
    }
    
    [Subject(typeof(FakeItEasyEngine))] 
    public class When_matching_on_a__NewExpression__ : WithCurrentEngine<FakeItEasyEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param.Is(new string(new[] { 'a' })), Param.Is(new string(new[] { 'b' }))))
                 .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("a", "b");

        It should_match_based_on_equality = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }
    
    [Subject(typeof(FakeItEasyEngine))] 
    public class When_matching_on_a_field_expression : WithCurrentEngine<FakeItEasyEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;
        static string a = "a";
        static string b = "b";

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param.Is(a), Param.Is(b)))
                 .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("a", "b");

        It should_match_against_the_member_value = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }
    
    [Subject(typeof(FakeItEasyEngine))] 
    public class When_matching_on_a_method_call_expression : WithCurrentEngine<FakeItEasyEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        static string A() { return "a"; }
        static string B() { return "b"; }

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(Param.Is(A()), Param.Is(B())))
                 .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("a", "b");

        It should_match_against_the_method_result = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(FakeItEasyEngine))] 
    public class When_matching_using_expressions_and_passing_in_a_value_that_matches_the_expression : WithCurrentEngine<FakeItEasyEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(
                    Param<string>.Matches(p1 => p1.StartsWith("J")), 
                    Param<string>.Matches(p2 => p2.StartsWith("D"))))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("John", "Doe");

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }
    
    [Subject(typeof(FakeItEasyEngine))] 
    public class When_matching_using_expressions_and_passing_in_a_value_that_does_not_match_the_expression : WithCurrentEngine<FakeItEasyEngine>
    {
        static IView _view;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _view = FakeEngineGateway.Fake<IView>();

            _view.WhenToldTo(v => v.TryLogin(
                    Param<string>.Matches(p1 => p1.StartsWith("J")),
                    Param<string>.Matches(p2 => p2.StartsWith("D"))))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _view.TryLogin("NOT_John", "NOT_Doe");

        It should_not_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeFalse();
    }

    [Subject(typeof(FakeItEasyEngine))] 
    public class When_matching_only_when_a_type_implements_an_interface_and_the_parameter_value_implements_that_interface
        : WithCurrentEngine<FakeItEasyEngine>
    {
        static IFlashVerifier _flashVerifier;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _flashVerifier = FakeEngineGateway.Fake<IFlashVerifier>();

            _flashVerifier
                .WhenToldTo(v => v.CanPlayFlash(Param<ITablet>.IsA<ICanPlayFlash>()))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _flashVerifier.CanPlayFlash(new Xoom());

        It should_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }

    [Subject(typeof(FakeItEasyEngine))] 
    public class When_matching_only_when_a_type_implements_an_interface_and_the_parameter_value_does_not_implement_that_interface
        : WithCurrentEngine<FakeItEasyEngine>
    {
        static IFlashVerifier _flashVerifier;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _flashVerifier = FakeEngineGateway.Fake<IFlashVerifier>();

            _flashVerifier
                .WhenToldTo(v => v.CanPlayFlash(Param<ITablet>.IsA<ICanPlayFlash>()))
                .Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _flashVerifier.CanPlayFlash(new IPad());

        It should_not_have_triggered_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeFalse();
    }

    [Subject(typeof(FakeItEasyEngine))] 
    public class When_matching_for_equality_without_explicit__Param__constraint_and_the_passed_values_is_not_the_expected_ones
        : WithCurrentEngine<FakeItEasyEngine>
    {
        static IView _fake;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _fake = FakeEngineGateway.Fake<IView>();
            _fake.WhenToldTo(v => v.TryLogin("a", "c")).Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _fake.TryLogin("b", "c");

        It should_not_trigger_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeFalse();
    }

    [Subject(typeof(FakeItEasyEngine))] 
    public class When_matching_for_equality_without_explicit__Param__constraint_and_the_passed_values_are_the_expected_ones
        : WithCurrentEngine<FakeItEasyEngine>
    {
        static IView _fake;
        static bool _configuredBehaviorWasTriggered;

        Establish context = () =>
        {
            _fake = FakeEngineGateway.Fake<IView>();
            _fake.WhenToldTo(v => v.TryLogin("a", null)).Return(true);
        };

        Because of = () => _configuredBehaviorWasTriggered = _fake.TryLogin("a", null);

        It should_trigger_the_configured_behavior = () => _configuredBehaviorWasTriggered.ShouldBeTrue();
    }
}



