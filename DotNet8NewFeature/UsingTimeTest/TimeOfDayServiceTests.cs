using UsingTime;

namespace UsingTimeTest
{
    public class TimeOfDayServiceTests
    {
        private TimeOfDayService _timeOfDayService;
        private TimeProvider _timeProvider;


        [Fact]
        public void TimeOfDay_ShouldReturnMorning_WhenItsMorning()
        {
            _timeProvider = new MorningTimeProvider();
            _timeOfDayService = new TimeOfDayService(_timeProvider);

            var v = _timeOfDayService.GetTimeOfDay();
            Assert.Equal("Morning", v);

        }

        [Fact]
        public void TimeOfDay_ShouldReturnAfternoon_WhenItsAfternoon()
        {
            _timeProvider = new AfternoonTimeProvider();
            _timeOfDayService = new TimeOfDayService(_timeProvider);

            var v = _timeOfDayService.GetTimeOfDay();
            Assert.Equal("Afternoon", v);

        }

        [Fact]
        public void TimeOfDay_ShouldReturnEvening_WhenItsEvening()
        {
            _timeProvider = new EveningTimeProvider();
            _timeOfDayService = new TimeOfDayService(_timeProvider);

            var v = _timeOfDayService.GetTimeOfDay();
            Assert.Equal("Evening", v);

        }

        [Fact]
        public void TimeOfDay_ShouldReturnNight_WhenItsNight()
        {
            _timeProvider = new NightTimeProvider();
            _timeOfDayService = new TimeOfDayService(_timeProvider);

            var v = _timeOfDayService.GetTimeOfDay();
            Assert.Equal("Night", v);

        }
    }
}
