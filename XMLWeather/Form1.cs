using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;
using XMLWeather.Properties;

/*
 * Weather App
 * Logan Gillett
 * Mr. T
 * 19.4.24
 * ICS4U
 */

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // TODO: create list to hold day objects
        public static List<Day> days = new List<Day>();
        public static TimeSpan currentDay;
        public static double dayWeather;

        public static Label testLabel;
        public static string city = "Stratford, CA";
        public static string timeZone;

        public Form1()
        {
            InitializeComponent();
            testLabel = blendLabel;

            ExtractForecast();
            ExtractCurrent();

            // open weather screen for todays weather
            ForecastScreen cs = new ForecastScreen();
            cs.Location = new Point((this.Width - cs.Width) / 2, (this.Height - cs.Height) / 2);
            this.Controls.Add(cs);

            blendLabel.BackColor = Color.FromArgb(150, 0, 0, 0);
            cs.Parent = blendLabel;

            this.BackgroundImage = setBackground();
        }

        public static void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=" + city + "&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                //TODO: create a day object
                Day d = new Day();

                //TODO: fill day object with required data
                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("day");

                reader.ReadToFollowing("symbol");
                d.condition = reader.GetAttribute("number");

                reader.ReadToFollowing("temperature");
                d.tempLow = reader.GetAttribute("min");
                d.tempHigh = reader.GetAttribute("max");

                //TODO: if day object not null add to the days list
                days.Add(d);
            }
            days.Remove(days[7]);
        }

        public static void ExtractCurrent()
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=" + city + "&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");
            //TODO: find the city and current temperature and add to appropriate item in days list
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("timezone");
            timeZone = reader.ReadString();

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");

            reader.ReadToFollowing("weather");
            dayWeather = Convert.ToDouble(reader.GetAttribute("number")) / 100;
            days[0].condition = reader.GetAttribute("value");

            reader.ReadToFollowing("lastupdate");
            DateTime d = Convert.ToDateTime(reader.GetAttribute("value"));
            currentDay = d.TimeOfDay;
        }

        public static void ChangeScreen(object sender, UserControl next)
        {
            Form f; // will either be the sender or parent of sender

            if (sender is Form)
            {
                f = (Form)sender;                          //f is sender
            }
            else
            {
                UserControl current = (UserControl)sender;  //create UserControl from sender
                f = current.FindForm();                     //find Form UserControl is on
                f.Controls.Remove(current);                 //remove current UserControl
            }

            // add the new UserControl to the middle of the screen and focus on it
            next.Location = new Point((f.ClientSize.Width - next.Width) / 2,
                (f.ClientSize.Height - next.Height) / 2);
            f.Controls.Add(next);
            next.Parent = testLabel;
            next.Focus();
        }

        //sets background images
        public static System.Drawing.Image setBackground()
        {
            System.Drawing.Image backgroundImage = null;
            //gets and displays the timezone difference
            int displayTimeZone = Convert.ToInt16(Form1.timeZone); //timezone from XML file
            DateTime utcTime = DateTime.UtcNow; //gets current utc time
            DateTime displayedTime = utcTime.AddSeconds(displayTimeZone); //gets difference

            if (displayedTime.TimeOfDay >= new TimeSpan(20, 00, 00) || displayedTime.TimeOfDay <= new TimeSpan(06, 00, 00)) //night images
            {
                switch ((int)dayWeather)
                {
                    case 2:
                        backgroundImage = Resources.stormyBackground;
                        break;
                    case 3:
                        backgroundImage = Resources.drizzleBackground;
                        break;
                    case 5:
                        if (dayWeather <= 5 && dayWeather <= 5.04)
                        {
                            backgroundImage = Resources.cloudyRainBackground;
                        }
                        else if (dayWeather * 100 == 511)
                        {
                            backgroundImage = Resources.snowNightBackground;
                        }
                        else
                        {
                            backgroundImage = Resources.heavyRainBackground;
                        }
                        break;
                    case 6:
                        backgroundImage = Resources.snowNightBackground;
                        break;
                    case 7:
                        if (dayWeather == 7.01 || dayWeather == 7.21 || dayWeather == 7.41 || dayWeather == 7.71)
                        {
                            backgroundImage = Resources.fogBackground;
                        }
                        else if (dayWeather == 7.11 || dayWeather == 7.31 || dayWeather == 7.51 || dayWeather == 7.61)
                        {
                            backgroundImage = Resources.dustBackground;
                        }
                        else
                        {
                            backgroundImage = Resources.tornadoBackground;
                        }
                        break;
                    case 8:
                        if (dayWeather == 8.04)
                        {
                            backgroundImage = Resources.cloudyRainBackground;
                        }
                        else
                        {
                            backgroundImage = Resources.nightBackground;
                        }
                        break;
                }
            }
            else //day images
            {
                switch ((int)dayWeather)
                {
                    case 2:
                        backgroundImage = Resources.stormyBackground;
                        break;
                    case 3:
                        backgroundImage = Resources.drizzleBackground;
                        break;
                    case 5:
                        if (dayWeather <= 5 && dayWeather <= 5.04)
                        {
                            backgroundImage = Resources.cloudyRainBackground;
                        }
                        else if (dayWeather * 100 == 511)
                        {
                            backgroundImage = Resources.freezingRainBackground;
                        }
                        else
                        {
                            backgroundImage = Resources.heavyRainBackground;
                        }
                        break;
                    case 6:
                        backgroundImage = Resources.cloudySnowBackground;
                        break;
                    case 7:
                        if (dayWeather == 7.01 || dayWeather == 7.21 || dayWeather == 7.41 || dayWeather == 7.71)
                        {
                            backgroundImage = Resources.fogBackground;
                        }
                        else if (dayWeather == 7.11 || dayWeather == 7.31 || dayWeather == 7.51 || dayWeather == 7.61)
                        {
                            backgroundImage = Resources.dustBackground;
                        }
                        else
                        {
                            backgroundImage = Resources.tornadoBackground;
                        }
                        break;
                    case 8:
                        if (dayWeather == 8)
                        {
                            backgroundImage = Resources.sunnyBackground;
                        }
                        else if (dayWeather == 8.04)
                        {
                            backgroundImage = Resources.cloudyRainBackground;
                        }
                        else
                        {
                            backgroundImage = Resources.slightlyCloudyBackground;
                        }
                        break;
                }
            }
            
            return backgroundImage;
        }
    }
}
