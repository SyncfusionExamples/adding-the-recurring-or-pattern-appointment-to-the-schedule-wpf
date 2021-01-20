using Syncfusion.UI.Xaml.Scheduler;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Media;

namespace WpfScheduler
{
    public class SchedulerViewModel
    {
        public ScheduleAppointmentCollection scheduleAppointmentCollection { get; set; } = new ScheduleAppointmentCollection();
        public SchedulerViewModel()
        {
            var scheduleAppointment = new ScheduleAppointment
            {
                Id = 1,
                Subject = "Daily scrum meeting",
                StartTime = new DateTime(2020, 12, 13, 11, 0, 0),
                EndTime = new DateTime(2020, 12, 13, 12, 0, 0),
                AppointmentBackground = new SolidColorBrush(Colors.LimeGreen),
                Foreground = new SolidColorBrush(Colors.White),
                RecurrenceRule = "FREQ=DAILY;INTERVAL=1;COUNT=10"
            };
            scheduleAppointmentCollection.Add(scheduleAppointment);

            DateTime exceptionDate = scheduleAppointment.StartTime.AddDays(3).Date;
            scheduleAppointment.RecurrenceExceptionDates = new ObservableCollection<DateTime>()
            {
              exceptionDate,
            };
        }
    }
}
