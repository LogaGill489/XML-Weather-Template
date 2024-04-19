using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace XMLWeather
{
    public partial class WorldSearch : UserControl
    {
        public WorldSearch()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 8, 24, 41);
            backgroundLabel.BackColor = Color.FromArgb(90, 0, 0, 0);
            insertLabel.Parent = backgroundLabel;
            insertLabel.Location = new Point(23, 15);
        }

        private void cityInput_Enter(object sender, EventArgs e)
        {
                cityInput.Text = null;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.city = cityInput.Text;
                Form1.days.Clear();
                Form1.ExtractForecast();
                Form1.ExtractCurrent();

                Form1.ChangeScreen(this, new ForecastScreen());
                this.Dispose();
            }
            catch
            {
                cityInput.Text = "Unknown City.";
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new ForecastScreen());
            this.Dispose();
        }
    }
}
