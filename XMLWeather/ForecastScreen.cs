using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using XMLWeather.Properties;
using static System.Net.Mime.MediaTypeNames;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();

            const int OPACITY = 90;

            //today's background setup
            tempBackLabel.BackColor = Color.FromArgb(OPACITY, 0, 0, 0);

            cityLabel.Parent = tempBackLabel;
            cityLabel.Location = new Point(0, 0);
            cityLabel.Width = tempBackLabel.Width;

            tempLabel.Parent = tempBackLabel;
            tempLabel.Location = new Point(7, 37);
            tempLabel.Width = tempBackLabel.Width;

            weatherLabel.Parent = tempBackLabel;
            weatherLabel.Location = new Point(0, 90);
            weatherLabel.Width = tempBackLabel.Width;

            highLowLabel.Parent = tempBackLabel;
            highLowLabel.Location = new Point(0, 110);
            highLowLabel.Width = tempLabel.Width; 

            humidityLabel.Parent = tempBackLabel;
            humidityLabel.Location = new Point(0, 40);
            humidityLabel.Width = tempLabel.Width;

            windspeedLabel.Parent = tempBackLabel;
            windspeedLabel.Location = new Point(0, 65);
            windspeedLabel.Width = tempLabel.Width;

            //forecast background setup
            weekBackLabel.BackColor = Color.FromArgb(OPACITY, 0, 0, 0);

            upcomingTextLabel.Parent = weekBackLabel;
            upcomingTextLabel.Location = new Point(0, 8);

            //dividing lines
            divider1Label.Parent = weekBackLabel;
            divider1Label.Location = new Point(0, 4);

            divider2Label.Parent = weekBackLabel;
            divider2Label.Location = new Point(0, 220);

            //one day away setup
            oneDayAwayLabel.Parent = weekBackLabel;
            oneDayAwayLabel.Location = new Point(3, 37);

            forecastPic1.Parent = weekBackLabel;
            forecastPic1.Location = new Point(65, 36);

            low1Label.Parent = weekBackLabel;
            low1Label.Location = new Point(120, 37);

            high1Label.Parent = weekBackLabel;
            high1Label.Location = new Point(264, 37);

            //two days away setup
            twoDaysAwayLabel.Parent = weekBackLabel;
            twoDaysAwayLabel.Location = new Point(3, 69);

            forecastPic2.Parent = weekBackLabel;
            forecastPic2.Location = new Point(65, 67);

            low2Label.Parent = weekBackLabel;
            low2Label.Location = new Point(120, 69);

            high2Label.Parent = weekBackLabel;
            high2Label.Location = new Point(264, 69);

            //three days away setup
            threeDaysAwayLabel.Parent = weekBackLabel;
            threeDaysAwayLabel.Location = new Point(3, 101);

            forecastPic3.Parent = weekBackLabel;
            forecastPic3.Location = new Point(65, 100);

            low3Label.Parent = weekBackLabel;
            low3Label.Location = new Point(120, 101);

            high3Label.Parent = weekBackLabel;
            high3Label.Location = new Point(264, 101);

            //four days away setup
            fourDaysAwayLabel.Parent = weekBackLabel;
            fourDaysAwayLabel.Location = new Point(3, 133);

            forecastPic4.Parent = weekBackLabel;
            forecastPic4.Location = new Point(65, 130);

            low4Label.Parent = weekBackLabel;
            low4Label.Location = new Point(120, 133);

            high4Label.Parent = weekBackLabel;
            high4Label.Location = new Point(264, 133);

            //five days away setup
            fiveDaysAwayLabel.Parent = weekBackLabel;
            fiveDaysAwayLabel.Location = new Point(3, 165);

            forecastPic5.Parent = weekBackLabel;
            forecastPic5.Location = new Point(65, 163);

            low5Label.Parent = weekBackLabel;
            low5Label.Location = new Point(120, 165);

            high5Label.Parent = weekBackLabel;
            high5Label.Location = new Point(264, 165);

            //six days away setup
            sixDaysAwayLabel.Parent = weekBackLabel;
            sixDaysAwayLabel.Location = new Point(3, 197);

            forecastPic6.Parent = weekBackLabel;
            forecastPic6.Location = new Point(65, 195);

            low6Label.Parent = weekBackLabel;
            low6Label.Location = new Point(120, 197);

            high6Label.Parent = weekBackLabel;
            high6Label.Location = new Point(264, 197);

            //options background setup
            optionsBackLabel.BackColor = Color.FromArgb(OPACITY, 0, 0, 0);

            globeImage.Parent = optionsBackLabel;
            globeImage.Location = new Point(287, 49);

            greetingLabel.Parent = optionsBackLabel;
            greetingLabel.Location = new Point(59, 45);

            currentTimeLabel.Parent = optionsBackLabel;
            currentTimeLabel.Location = new Point(84, 4);

            //gets and displays the timezone difference
            int displayTimeZone = Convert.ToInt16(Form1.timeZone); //timezone from XML file
            DateTime utcTime = DateTime.UtcNow; //gets current utc time
            DateTime displayedTime = utcTime.AddSeconds(displayTimeZone); //gets difference

            //displays Time
            if (displayedTime.Minute <= 9)
            {
                currentTimeLabel.Text = $"{displayedTime.Hour}:0{displayedTime.Minute}";
            }
            else
            {
                //currentTimeLabel.Text = $"{Form1.currentDay.Hours}:{Form1.currentDay.Minutes}";
                currentTimeLabel.Text = $"{displayedTime.Hour}:{displayedTime.Minute}";
            }

            //displays "Good ***" based on current time in that day
            if (displayedTime.Hour >= 5 && displayedTime.Hour <= 12)
            {
                greetingLabel.Text = "Good Morning";
            }
            else if (displayedTime.Hour > 12 && displayedTime.Hour <= 19)
            {
                greetingLabel.Text = "Good Afternoon";
            }
            else
            {
                greetingLabel.Text = "Good Evening";
            }

            displayForecast();
        }

        public void displayForecast()
        {
            //lists are used for converting temps to ints & getting day of the week
            List<double> lows = new List<double>();
            List<double> highs = new List<double>();
            List<string> days = new List<string>();
            //arrays are used to keep label code cleaner in the forecast section
            Label[] lowLabels = new Label[] { low1Label, low2Label, low3Label, low4Label, low5Label, low6Label };
            Label[] highLabels = new Label[] { high1Label, high2Label, high3Label, high4Label, high5Label, high6Label };
            Label[] dateLabels = new Label[] { oneDayAwayLabel, twoDaysAwayLabel, threeDaysAwayLabel, fourDaysAwayLabel, fiveDaysAwayLabel, sixDaysAwayLabel };
            //pictureBox array for the forecast images
            PictureBox[] forecastImages = new PictureBox[] { forecastPic1, forecastPic2, forecastPic3, forecastPic4, forecastPic5, forecastPic6 };
            string tempUnit = "C";

            this.BackgroundImage = Form1.setBackground(); //call function to display background image

            for (int i = 1; i < 7; i++) //image decoder for forecast icons
            {
                System.Drawing.Image currentImage = null;
                double condition = double.Parse(Form1.days[i].condition) / 100;
                switch ((int)condition)
                {
                    case 2: //Thunderstorm
                        currentImage = Resources.stormy;
                        break;
                    case 3: //Drizzle
                        currentImage = Resources.drizzle;
                        break;
                    case 5: //Rain
                        if (condition <= 500 && condition <= 504)
                        {
                            currentImage = Resources.cloudy_with_rain;
                        }
                        else if (condition == 511)
                        {
                            currentImage = Resources.snowflake;
                        }
                        else
                        {
                            currentImage = Resources.heavy_rain;
                        }
                        break;
                    case 6: //Snow
                        currentImage = Resources.cloudy_snowy;
                        break;
                    case 7: //Atmosphere
                        currentImage = Resources.tornado;
                        break;
                    case 8: //Clear & Clouds
                        if (condition == 8)
                        {
                            currentImage = Resources.day;
                        }
                        else if (condition == 8.04)
                        {
                            currentImage = Resources.cloudy_with_rain;
                        }
                        else
                        {
                            currentImage = Resources.cloudy;
                        }
                        break;
                }

                forecastImages[i - 1].BackgroundImage = currentImage; //adjusts images
            }

            foreach (Day day in Form1.days) //fills double lists
            {
                lows.Add(double.Parse(day.tempLow));
                highs.Add(double.Parse(day.tempHigh));
            }

            for (int i = 0; i < 7; i++)
            {
                days.Add(DateTime.Now.AddDays(i).DayOfWeek.ToString("")); //sets dates for forecast display
                days[i] = days[i].Substring(0, 3); //lowers string limit to 3 chars
                if (i == 0) //stops issues with over-filling lists & alligning
                {
                    //sets today's high and low
                    highLowLabel.Text = $"L:{Convert.ToInt16(lows[0])}°{tempUnit} H:{Convert.ToInt16(highs[0])}°{tempUnit}";
                }
                else
                {
                    //sets labels for the forecast
                    lowLabels[i - 1].Text = $"{Convert.ToInt16(lows[i])}°{tempUnit}";
                    highLabels[i - 1].Text = $"{Convert.ToInt16(highs[i])}°{tempUnit}";
                    dateLabels[i - 1].Text = days[i];
                }
            }

            //sets current temp in big letters
            double currentTemp = double.Parse(Form1.days[0].currentTemp);
            tempLabel.Text = $"{Convert.ToInt16(currentTemp)}°{tempUnit}";

            //displays location
            cityLabel.Text = Form1.days[0].location;

            //displays weather
            char[] dayCondition = Form1.days[0].condition.ToCharArray(); //sets char array to make certain values uppercase
            dayCondition[0] = Char.ToUpper(dayCondition[0]); //sets first letter uppercase
            for (int c = 0; c < dayCondition.Count(); c++) //for loop to uppercase any letters that have a space before them
            {
                if (dayCondition[c] == ' ')
                {
                    dayCondition[c + 1] = Char.ToUpper(dayCondition[c + 1]);
                }
            }
            Form1.days[0].condition = new string(dayCondition); //rewrites form in the days list
            weatherLabel.Text = Form1.days[0].condition;

            humidityLabel.Text = $"Humidity: {Form1.days[0].humidity}%";
            windspeedLabel.Text = $"WS: {Form1.days[0].windSpeed}m/s";
        }

        private void globeImage_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new WorldSearch()); //changes to search screen
            this.Dispose();
        }

        private void tempLabel_MouseEnter(object sender, EventArgs e)
        {
            tempLabel.Visible = false;
            humidityLabel.Visible = true;
            windspeedLabel.Visible = true;

            weatherLabel.Location = new Point(0, 88);
            if (Form1.days[0].windSpeed == "0")
            {
                weatherLabel.Text = "Wind Direction: N/A";
            }
            else
            {
                weatherLabel.Text = $"Wind Direction: {Form1.days[0].windDirection}";
            }
        }

        private void tempLabel_MouseLeave(object sender, EventArgs e)
        {
            tempLabel.Visible = true;
            humidityLabel.Visible = false;
            windspeedLabel.Visible = false;

            weatherLabel.Location = new Point(0, 90);
            weatherLabel.Text = Form1.days[0].condition;
        }
    }
}