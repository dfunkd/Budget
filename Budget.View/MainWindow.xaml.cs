using Budget.View.UserControls;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Budget.View
{
    public partial class MainWindow : Window
    {
        public DateTime CurrentDate { get; set; }

        #region MonthString
        public static readonly DependencyProperty MonthStringProperty = DependencyProperty.Register("MonthString", typeof(string), typeof(MainWindow), new FrameworkPropertyMetadata(string.Empty, OnMonthStringChanged));
        public string MonthString
        {
            get => (string)GetValue(MonthStringProperty);
            set => SetValue(MonthStringProperty, value);
        }
        private static void OnMonthStringChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) => ((MainWindow)d).OnMonthStringChanged(e);
        protected virtual void OnMonthStringChanged(DependencyPropertyChangedEventArgs e)
        {
        }
        #endregion

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            CurrentDate = DateTime.Now;
            int year = CurrentDate.Year;
            int month = CurrentDate.Month;

            MonthString = $"{CurrentDate:MMMM} {CurrentDate.Year}";

            int day = 0;
            int totalDays = new DateTime(year, month, 1).AddMonths(1).AddDays(-1).Day;
            ugCalendar.Children.Clear();
            for (int row = 0; row < 6; row++)
            {
                for (int column = 0; column < 7; column++)
                {
                    if (row == 0)
                    {
                        string dayText = GetDayText(column);

                        Border dayBorder = new Border
                        {
                            Background = DrawingColorToSolidColorBrush("#44000000"),
                            BorderBrush = DrawingColorToSolidColorBrush("#FF000000"),
                            BorderThickness = new Thickness(1),
                            Child = new TextBlock
                            {
                                HorizontalAlignment = HorizontalAlignment.Center,
                                Text = dayText,
                                VerticalAlignment = VerticalAlignment.Center
                            }
                        };
                        Grid.SetColumn(dayBorder, column);
                        Grid.SetRow(dayBorder, row);
                        ugCalendar.Children.Add(dayBorder);
                    }
                    else if ((row == 1 && column < new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).Day - 1) || day >= totalDays)
                    {
                        CalendarDay calendarDay = new CalendarDay { Background = new SolidColorBrush(Colors.Black) };

                        Border blankBorder = new Border
                        {
                            BorderBrush = DrawingColorToSolidColorBrush("#FF000000"),
                            BorderThickness = new Thickness(1),
                            Child = calendarDay
                        };
                        Grid.SetColumn(blankBorder, column);
                        Grid.SetRow(blankBorder, row);
                        ugCalendar.Children.Add(blankBorder);
                    }
                    else
                    {
                        day += 1;
                        //    /*
                        //    <Border Grid.Column="1" Grid.Row="1" BorderBrush="#FF000000" BorderThickness="1">
                        //        <uc:CalendarDay Background="#44FFFF00" DayNumber="1" CalendarText="Car Payment" />
                        //    </Border>
                        //    <Border Grid.Column="2" Grid.Row="1" BorderBrush="#FF000000" BorderThickness="1">
                        //        <uc:CalendarDay Background="#4400FF00" DayNumber="2" CalendarText="House Payment" />
                        //    </Border>
                        //    <Border Grid.Column="3" Grid.Row="1" BorderBrush="#FF000000" BorderThickness="1">
                        //        <uc:CalendarDay Background="#44FF0000" DayNumber="3" CalendarText="Hulu Payment" />
                        //    </Border>
                        //     */
                        //    //Add Regular Day
                        //    date = date++;
                        DateTime calDate = new DateTime(year, month, day);
                        Border blankBorder = new Border
                        {
                            BorderBrush = DrawingColorToSolidColorBrush("#FF000000"),
                            BorderThickness = new Thickness(1),
                            Child = new CalendarDay
                            {
                                Background = DrawingColorToSolidColorBrush("#44FFFF00"),
                                DayNumber = day.ToString()
                            }
                        };
                        Grid.SetColumn(blankBorder, column);
                        Grid.SetRow(blankBorder, row);
                        ugCalendar.Children.Add(blankBorder);
                    }
                }
            }
        }

        public SolidColorBrush DrawingColorToSolidColorBrush(string color)
            => (SolidColorBrush)(new BrushConverter().ConvertFrom(color));

        public string GetDayText(int day)
        {
            switch (day)
            {
                case 0:
                    return "Sunday";
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                default:
                    return string.Empty;
            }
        }
    }
}