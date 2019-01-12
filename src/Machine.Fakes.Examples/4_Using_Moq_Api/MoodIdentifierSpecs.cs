using System;
using Machine.Fakes.Examples.SampleCode;
using Machine.Specifications;

using Moq;
using It = Machine.Specifications.It;

namespace Machine.Fakes.Examples.UsingMoqApi
{
    [Subject(typeof(MoodIdentifier)), Tags("Examples")]
    public class Given_the_current_day_is_monday_when_identifying_my_mood
    {
        static MoodIdentifier _moodIdentifier;
        static string _mood;

        Establish context = () =>
        {
            var monday = new DateTime(2011, 2, 14);
            var mock = new Mock<ISystemClock>();

            mock.Setup(x => x.CurrentTime).Returns(() => monday);

            _moodIdentifier = new MoodIdentifier(mock.Object);
        };

        Because of = () =>
        {
            _mood = _moodIdentifier.IdentifyMood();
        };

        It should_be_pretty_bad = () => _mood.ShouldEqual("Pretty bad");
    }

    [Subject(typeof(MoodIdentifier)), Tags("Examples")]
    public class Given_the_current_day_is_tuesday_when_identifying_my_mood
    {
        static MoodIdentifier _moodIdentifier;
        static DateTime _tuesday;
        static string _mood;

        Establish context = () =>
        {
            _tuesday = new DateTime(2011, 2, 15);

            var mock = new Mock<ISystemClock>();

            mock.Setup(x => x.CurrentTime).Returns(() => _tuesday);

            _moodIdentifier = new MoodIdentifier(mock.Object);
        };

        Because of = () =>
        {
            _mood = _moodIdentifier.IdentifyMood();
        };

        It should_be_ok = () => _mood.ShouldEqual("Ok");
    }
}