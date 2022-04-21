using System.Windows;
using System.Windows.Controls;

namespace Budget.View.UserControls
{
    public partial class CalendarDay : UserControl
    {
        #region Dependency Properties
        #region DayNumber
        public static readonly DependencyProperty DayNumberProperty = DependencyProperty.Register("DayNumber", typeof(string), typeof(CalendarDay), new FrameworkPropertyMetadata(string.Empty, OnDayNumberChanged));
        public string DayNumber
        {
            get => (string)GetValue(DayNumberProperty);
            set => SetValue(DayNumberProperty, value);
        }
        private static void OnDayNumberChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) => ((CalendarDay)d).OnDayNumberChanged(e);
        protected virtual void OnDayNumberChanged(DependencyPropertyChangedEventArgs e)
        {
        }
        #endregion
        #region CalendarText
        public static readonly DependencyProperty CalendarTextProperty = DependencyProperty.Register("CalendarText", typeof(string), typeof(CalendarDay), new FrameworkPropertyMetadata(string.Empty, OnCalendarTextChanged));
        public string CalendarText
        {
            get => (string)GetValue(CalendarTextProperty);
            set => SetValue(CalendarTextProperty, value);
        }
        private static void OnCalendarTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) => ((CalendarDay)d).OnCalendarTextChanged(e);
        protected virtual void OnCalendarTextChanged(DependencyPropertyChangedEventArgs e)
        {
        }
        #endregion
        #endregion

        public CalendarDay()
        {
            InitializeComponent();
        }
    }
}