namespace CustomControls
{
    public partial class CustomUserControl : UserControl
    {
        public CustomUserControl()
        {
            InitializeComponent();
            monthCalendarStart.DateSelected += MonthCalendar_DateSelected;
            monthCalendarEnd.DateSelected += MonthCalendar_DateSelected;
        }

        public event EventHandler TimeRangeChanged;

        public DateTime StartDate
        {
            get => monthCalendarStart?.SelectionStart ?? DateTime.MinValue;
            set => monthCalendarStart.SelectionStart = value;
        }
        public DateTime EndDate
        {
            get => monthCalendarEnd?.SelectionStart ?? DateTime.MinValue;
            set => monthCalendarEnd.SelectionStart = value;
        }

        private void MonthCalendar_DateSelected(object? sender, DateRangeEventArgs e)
        {
            MonthCalendar calendar = (MonthCalendar)sender;
            if (calendar == monthCalendarStart)
            {
                StartDate = e.Start;
            }
            else if (calendar == monthCalendarEnd)
            {
                EndDate = e.Start;
            }

            if (EndDate < StartDate)
            {
                MessageBox.Show("Кінцева дата не може бути раніше початкової.");
                return;
            }

            if (monthCalendarStart != null && monthCalendarEnd != null)
            {
                TimeSpan interval = EndDate - StartDate;
                int days = interval.Days;

                if (labelInterval != null)
                    labelInterval.Text = $"Інтервал: {days} днів";
            }

            TimeRangeChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}