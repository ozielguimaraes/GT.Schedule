using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GT.Schedule.Entities;
using Syncfusion.SfSchedule.XForms;
using Xamarin.Forms;

namespace GT.Schedule.Pages.DNA
{
    public partial class WeeklyDna : ContentPage
    {
        public WeeklyDna()
        {
            InitializeComponent();
            var now = DateTime.Now;
            var from = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, 0);
            var meeting = new Meeting
            {
                EventName = "Meeting with Microsoft",
                From = from,
                Color = Color.Green,
                To = from.AddDays(1)
            };
            var items = new ScheduleAppointmentCollection
            {
                new ScheduleAppointment
                {
                    StartTime = now,
                    EndTime = now.AddDays(5),
                    Subject = meeting.EventName,
                    Color = meeting.Color
                }
            };
            var meetings = new ObservableCollection<Meeting> { meeting };
            schedule.DataSource = items;
        }
    }
}