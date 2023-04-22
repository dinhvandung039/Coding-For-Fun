using MakeCodeMoreOOP.Interfaces;

namespace MakeCodeMoreOOP.Implementations
{
    public class ScheduleBase
    {
        private readonly ITriggerTime _triggerTime;
        private readonly DateTimeOffset created;
        public ScheduleBase(ITriggerTime triggerTime)
        {
            _triggerTime = triggerTime;
            created = DateTimeOffset.UtcNow;
        }

        public bool IsDue() => _triggerTime.IsDue(created);
    }

    public class DialySchedule : ITriggerTime
    {
        public bool IsDue(DateTimeOffset date)
        {
            throw new NotImplementedException();
        }
    }

    public class EndOfWeekSchedule : WeeklyTrigger
    {
        public EndOfWeekSchedule() : base(DayOfWeek.Sunday) { }

        public bool IsDue(DateTimeOffset date)
        {
            throw new NotImplementedException();
        }
    }

    public class WeeklyTrigger : ITriggerTime
    {
        private readonly DayOfWeek _dayOfWeek;
        public WeeklyTrigger(DayOfWeek dayOfWeek)
        {
            _dayOfWeek = dayOfWeek;
        }

        public bool IsDue(DateTimeOffset date)
        {
            throw new NotImplementedException();
        }
    }
}
