namespace UsingTime
{
    public class TimeOfDayService
    {
        private readonly TimeProvider _timeProvider;

        public TimeOfDayService(TimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public string GetTimeOfDay()
        {
            //var currentTime = DateTime.Now;

            var currentTime = _timeProvider.GetLocalNow();

            return currentTime.Hour switch
            {
                <= 6 => "Night",
                > 6 and <= 12 => "Morning",
                > 12 and <= 18 => "Afternoon",
                > 18 and <= 24 => "Evening",
                _ => "Invalid hour"
            };
        }

    }
}
