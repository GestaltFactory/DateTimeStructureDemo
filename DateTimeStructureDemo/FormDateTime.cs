using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeStructureDemo
{
    public partial class FormDateTime : Form
    {
        public FormDateTime()
        {
            InitializeComponent();
        }

        private void FormDateTime_Load(object sender, EventArgs e)
        {
        }

        private void buttonNow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The property Now gets the current date and time.","Current Date and Time");
            DateTime currentDateTime = DateTime.Now;
            textBoxNow.Text = currentDateTime.ToString();
        }

        private void buttonToday_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The property Today gets the current date.", "Current Date");
            DateTime currentDate = DateTime.Today;
            textBoxToday.Text = currentDate.ToString();
        }

        private void buttonMonth_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The property Month gets the month component of the date.", "Month");
            DateTime currentDate = DateTime.Today;
            textBoxMonth.Text = currentDate.Month.ToString();
        }

        private void buttonDay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The property Day gets the day component of the date.", "Month");
            DateTime currentDate = DateTime.Today;
            textBoxDay.Text = currentDate.Day.ToString();
        }

        private void buttonYear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The property Year gets the year component of the date.", "Month");
            DateTime currentDate = DateTime.Today;
            textBoxYear.Text = currentDate.Year.ToString();
        }

        private void buttonLongDate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Converts the DateTime value to a string \n" +
                            " that includes the day of the week name,\n" +
                            " the month name, the day of the month, and the year.", "Long Date");
            DateTime currentDate = DateTime.Today;
            textBoxLongDate.Text = currentDate.ToLongDateString();
        }

        private void buttonShortDate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Converts the DateTime value to a string \n" + " that includes the numeric month, day, and year.", "Short Date");
            DateTime currentDate = DateTime.Today;
            textBoxShortDate.Text = currentDate.ToShortDateString();
        }

        private void buttonLongTime_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Converts the DateTime value to a string\n" + " that includes the hours, minutes, and seconds.", "Long Time");
            DateTime currentDateTime = DateTime.Now;
            textBoxLongTime.Text = currentDateTime.ToLongTimeString();
        }

        private void buttonShortTime_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Converts the DateTime value to a string\n" + " that includes the hours and minutes.", "Short Time");
            DateTime currentDateTime = DateTime.Now;
            textBoxShortTime.Text = currentDateTime.ToShortTimeString();
        }

        private void buttonOperation_Click(object sender, EventArgs e)
        {
            FormOperation aForm = new FormOperation();
            //To display a form as a modal dialog box
            aForm.ShowDialog();
        }

        private void buttonDayOfWeek_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gets the day of the week name represented by this DateTime value.", "Day name of Week");
            DateTime currentDateTime = DateTime.Now;
            textBoxDayOfWeek.Text = currentDateTime.DayOfWeek.ToString();
        }

        private void buttonDayOfYear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gets the number of days of the year represented by this DateTime value.", "Day of Year");
            DateTime currentDateTime = DateTime.Now;
            textBoxDayOfYear.Text = currentDateTime.DayOfYear.ToString();
        }

        private void buttonTimeOfDay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gets the time of the day represented by this DateTime value.", "Time of Day");
            DateTime currentDateTime = DateTime.Now;
            textBoxTimeOfDay.Text = currentDateTime.TimeOfDay.ToString();
        }
    }
}
