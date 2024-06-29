using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace A_N_2
{
    public partial class Form1 : Form
    {

        // Константа для имени файла
        private const string HolidayFileName = "holidays.txt";

        public Form1()
        {
            InitializeComponent();

            //устанавливаем первым днем недели - понедельник
            monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;

            //загружаем из файла и отмечаем праздничные дни
            LoadHolidaysFromFile(HolidayFileName);
            //сразу отмечаем выходные дни полужирным шрифтом
            SetWeekendsAsBoldedDates();
        }


        // Метод для загрузки праздничных дней из файла
        private void LoadHolidaysFromFile(string fileName)
        {
                // Очищаем все выделения в календаре
                monthCalendar1.RemoveAllBoldedDates();

                //отмечаем выходные дни
                SetWeekendsAsBoldedDates();

                // Читаем даты из файла и добавляем их в календарь
                using (StreamReader reader = new StreamReader(fileName, Encoding.GetEncoding(1251)))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (DateTime.TryParse(line, out DateTime holiday))
                        {
                            // Добавляем праздничный день к коллекции выделенных дат
                            monthCalendar1.AddBoldedDate(holiday);
                        }
                        else
                        {
                            MessageBox.Show($"Неверный формат даты: {line}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                // Обновляем календарь для отображения изменений
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

            // Обновляем календарь для отображения изменений
            monthCalendar1.UpdateBoldedDates();
        }


        private void button1_Click(object sender, EventArgs e)
        {
        }

        // Обработчик события DateChanged календаря
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //загружаем из файла и отмечаем праздничные дни
            LoadHolidaysFromFile(HolidayFileName);
            // При изменении даты в календаре вызываем метод для выделения выходных дней
            SetWeekendsAsBoldedDates();
        }

        private void monthCalendar1_VisibleChanged(object sender, EventArgs e)
        {
            
        }
    }
}
