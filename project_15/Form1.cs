using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace A_N_2
{
    public partial class Calendar : Form
    {

        private const string HolidayFileName = "holidays.txt";

        public Calendar()
        {
            InitializeComponent();

            //первый день недели - понедельник
            monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;

            LoadHolidaysFromFile(HolidayFileName);
            //отмечаем выходные дни полужирным шрифтом
            SetWeekendsAsBoldedDates();
        }


        private void LoadHolidaysFromFile(string fileName)
        {
            monthCalendar1.RemoveAllBoldedDates();
            DateTime holiday;
            //отмечаем выходные дни
            SetWeekendsAsBoldedDates();

            using (StreamReader reader = new StreamReader(fileName, Encoding.GetEncoding(1251)))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (DateTime.TryParse(line, out holiday))
                    {
                        // Добавляем праздничный день к выделенным дат
                        monthCalendar1.AddBoldedDate(holiday);
                    }
                    else
                    {
                        MessageBox.Show($"Неверный формат даты: {line}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            monthCalendar1.UpdateBoldedDates();
        }

        // Метод для выделения выходных дней (субботы и воскресенья)
        private void SetWeekendsAsBoldedDates()
        {
            DateTime startDate = new DateTime(monthCalendar1.SelectionStart.Year, monthCalendar1.SelectionStart.Month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1); // Конец текущего месяца

            while (startDate <= endDate)
            {
                if (startDate.DayOfWeek == DayOfWeek.Saturday || startDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    monthCalendar1.AddBoldedDate(startDate);
                }
                startDate = startDate.AddDays(1);
            }

            monthCalendar1.UpdateBoldedDates();
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //загружаем из файла и отмечаем праздничные дни
            LoadHolidaysFromFile(HolidayFileName);
            //метод для выделения выходных дней
            SetWeekendsAsBoldedDates();
        }

    }
}
