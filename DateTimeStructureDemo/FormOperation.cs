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
    public partial class FormOperation : Form
    {
        public FormOperation()
        {
            InitializeComponent();
        }

        private void buttonGetCurrentDateAndTime_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            textBoxCurrentDateTime.Text = currentDateTime.ToString();
        }

        private void buttonAddDays_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            currentDateTime = currentDateTime.AddDays(2);
            textBoxAddDays.Text = currentDateTime.ToString();
        }

        private void buttonAddMonths_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            currentDateTime = currentDateTime.AddMonths(1);
            textBoxAddMonths.Text = currentDateTime.ToString();
        }

        private void buttonAddYears_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            currentDateTime = currentDateTime.AddYears(3);
            textBoxAddYears.Text = currentDateTime.ToString();
        }

        private void buttonAddHours_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            currentDateTime = currentDateTime.AddHours(2);
            textBoxAddHours.Text = currentDateTime.ToString();
        }

        private void buttonAddMinutes_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            currentDateTime = currentDateTime.AddMinutes(60);
            textBoxAddMinutes.Text = currentDateTime.ToString();
        }

        private void buttonAddSeconds_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            currentDateTime = currentDateTime.AddSeconds(120);
            textBoxAddSeconds.Text = currentDateTime.ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
