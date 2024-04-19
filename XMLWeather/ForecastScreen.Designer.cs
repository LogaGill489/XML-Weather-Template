namespace XMLWeather
{
    partial class ForecastScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForecastScreen));
            this.tempLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.tempBackLabel = new System.Windows.Forms.Label();
            this.weatherLabel = new System.Windows.Forms.Label();
            this.highLowLabel = new System.Windows.Forms.Label();
            this.weekBackLabel = new System.Windows.Forms.Label();
            this.divider1Label = new System.Windows.Forms.Label();
            this.divider2Label = new System.Windows.Forms.Label();
            this.upcomingTextLabel = new System.Windows.Forms.Label();
            this.oneDayAwayLabel = new System.Windows.Forms.Label();
            this.twoDaysAwayLabel = new System.Windows.Forms.Label();
            this.threeDaysAwayLabel = new System.Windows.Forms.Label();
            this.fourDaysAwayLabel = new System.Windows.Forms.Label();
            this.fiveDaysAwayLabel = new System.Windows.Forms.Label();
            this.sixDaysAwayLabel = new System.Windows.Forms.Label();
            this.forecastPic1 = new System.Windows.Forms.PictureBox();
            this.forecastPic2 = new System.Windows.Forms.PictureBox();
            this.forecastPic3 = new System.Windows.Forms.PictureBox();
            this.forecastPic4 = new System.Windows.Forms.PictureBox();
            this.forecastPic5 = new System.Windows.Forms.PictureBox();
            this.forecastPic6 = new System.Windows.Forms.PictureBox();
            this.low1Label = new System.Windows.Forms.Label();
            this.high1Label = new System.Windows.Forms.Label();
            this.low2Label = new System.Windows.Forms.Label();
            this.low3Label = new System.Windows.Forms.Label();
            this.low4Label = new System.Windows.Forms.Label();
            this.low5Label = new System.Windows.Forms.Label();
            this.low6Label = new System.Windows.Forms.Label();
            this.high2Label = new System.Windows.Forms.Label();
            this.high3Label = new System.Windows.Forms.Label();
            this.high4Label = new System.Windows.Forms.Label();
            this.high5Label = new System.Windows.Forms.Label();
            this.high6Label = new System.Windows.Forms.Label();
            this.optionsBackLabel = new System.Windows.Forms.Label();
            this.globeImage = new System.Windows.Forms.PictureBox();
            this.greetingLabel = new System.Windows.Forms.Label();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.windspeedLabel = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.forecastPic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastPic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastPic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastPic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastPic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastPic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tempLabel
            // 
            this.tempLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tempLabel.Font = new System.Drawing.Font("Arial Nova Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.White;
            this.tempLabel.Location = new System.Drawing.Point(165, 117);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(125, 69);
            this.tempLabel.TabIndex = 64;
            this.tempLabel.Text = "30°";
            this.tempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tempLabel.MouseEnter += new System.EventHandler(this.tempLabel_MouseEnter);
            this.tempLabel.MouseLeave += new System.EventHandler(this.tempLabel_MouseLeave);
            // 
            // cityLabel
            // 
            this.cityLabel.BackColor = System.Drawing.Color.Transparent;
            this.cityLabel.Font = new System.Drawing.Font("Arial Nova Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.ForeColor = System.Drawing.Color.White;
            this.cityLabel.Location = new System.Drawing.Point(-1, 63);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(447, 54);
            this.cityLabel.TabIndex = 65;
            this.cityLabel.Text = "Barcelona";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tempBackLabel
            // 
            this.tempBackLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempBackLabel.Location = new System.Drawing.Point(13, 63);
            this.tempBackLabel.Name = "tempBackLabel";
            this.tempBackLabel.Size = new System.Drawing.Size(424, 178);
            this.tempBackLabel.TabIndex = 66;
            // 
            // weatherLabel
            // 
            this.weatherLabel.BackColor = System.Drawing.Color.Transparent;
            this.weatherLabel.ForeColor = System.Drawing.Color.White;
            this.weatherLabel.Location = new System.Drawing.Point(13, 186);
            this.weatherLabel.Name = "weatherLabel";
            this.weatherLabel.Size = new System.Drawing.Size(425, 33);
            this.weatherLabel.TabIndex = 67;
            this.weatherLabel.Text = "Slightly Cloudy";
            this.weatherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highLowLabel
            // 
            this.highLowLabel.BackColor = System.Drawing.Color.Transparent;
            this.highLowLabel.ForeColor = System.Drawing.Color.White;
            this.highLowLabel.Location = new System.Drawing.Point(12, 208);
            this.highLowLabel.Name = "highLowLabel";
            this.highLowLabel.Size = new System.Drawing.Size(425, 33);
            this.highLowLabel.TabIndex = 69;
            this.highLowLabel.Text = "L:24° H:33°";
            this.highLowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weekBackLabel
            // 
            this.weekBackLabel.BackColor = System.Drawing.Color.Transparent;
            this.weekBackLabel.Location = new System.Drawing.Point(13, 258);
            this.weekBackLabel.Name = "weekBackLabel";
            this.weekBackLabel.Size = new System.Drawing.Size(424, 315);
            this.weekBackLabel.TabIndex = 70;
            // 
            // divider1Label
            // 
            this.divider1Label.BackColor = System.Drawing.Color.Transparent;
            this.divider1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divider1Label.ForeColor = System.Drawing.Color.Gray;
            this.divider1Label.Location = new System.Drawing.Point(1, 316);
            this.divider1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.divider1Label.Name = "divider1Label";
            this.divider1Label.Size = new System.Drawing.Size(451, 31);
            this.divider1Label.TabIndex = 71;
            this.divider1Label.Text = "____________________________";
            this.divider1Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // divider2Label
            // 
            this.divider2Label.BackColor = System.Drawing.Color.Transparent;
            this.divider2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divider2Label.ForeColor = System.Drawing.Color.Gray;
            this.divider2Label.Location = new System.Drawing.Point(1, 587);
            this.divider2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.divider2Label.Name = "divider2Label";
            this.divider2Label.Size = new System.Drawing.Size(451, 46);
            this.divider2Label.TabIndex = 72;
            this.divider2Label.Text = "____________________________";
            this.divider2Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // upcomingTextLabel
            // 
            this.upcomingTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.upcomingTextLabel.Font = new System.Drawing.Font("Arial Nova Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upcomingTextLabel.ForeColor = System.Drawing.Color.White;
            this.upcomingTextLabel.Location = new System.Drawing.Point(4, 258);
            this.upcomingTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.upcomingTextLabel.Name = "upcomingTextLabel";
            this.upcomingTextLabel.Size = new System.Drawing.Size(221, 23);
            this.upcomingTextLabel.TabIndex = 73;
            this.upcomingTextLabel.Text = "🕒 Upcoming Forecast";
            // 
            // oneDayAwayLabel
            // 
            this.oneDayAwayLabel.BackColor = System.Drawing.Color.Transparent;
            this.oneDayAwayLabel.Font = new System.Drawing.Font("Arial Nova Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneDayAwayLabel.ForeColor = System.Drawing.Color.White;
            this.oneDayAwayLabel.Location = new System.Drawing.Point(11, 362);
            this.oneDayAwayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.oneDayAwayLabel.Name = "oneDayAwayLabel";
            this.oneDayAwayLabel.Size = new System.Drawing.Size(80, 32);
            this.oneDayAwayLabel.TabIndex = 74;
            this.oneDayAwayLabel.Text = "Wed";
            // 
            // twoDaysAwayLabel
            // 
            this.twoDaysAwayLabel.BackColor = System.Drawing.Color.Transparent;
            this.twoDaysAwayLabel.Font = new System.Drawing.Font("Arial Nova Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoDaysAwayLabel.ForeColor = System.Drawing.Color.White;
            this.twoDaysAwayLabel.Location = new System.Drawing.Point(11, 394);
            this.twoDaysAwayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.twoDaysAwayLabel.Name = "twoDaysAwayLabel";
            this.twoDaysAwayLabel.Size = new System.Drawing.Size(80, 32);
            this.twoDaysAwayLabel.TabIndex = 75;
            this.twoDaysAwayLabel.Text = "Wed";
            // 
            // threeDaysAwayLabel
            // 
            this.threeDaysAwayLabel.BackColor = System.Drawing.Color.Transparent;
            this.threeDaysAwayLabel.Font = new System.Drawing.Font("Arial Nova Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeDaysAwayLabel.ForeColor = System.Drawing.Color.White;
            this.threeDaysAwayLabel.Location = new System.Drawing.Point(12, 426);
            this.threeDaysAwayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.threeDaysAwayLabel.Name = "threeDaysAwayLabel";
            this.threeDaysAwayLabel.Size = new System.Drawing.Size(79, 32);
            this.threeDaysAwayLabel.TabIndex = 76;
            this.threeDaysAwayLabel.Text = "Wed";
            // 
            // fourDaysAwayLabel
            // 
            this.fourDaysAwayLabel.BackColor = System.Drawing.Color.Transparent;
            this.fourDaysAwayLabel.Font = new System.Drawing.Font("Arial Nova Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourDaysAwayLabel.ForeColor = System.Drawing.Color.White;
            this.fourDaysAwayLabel.Location = new System.Drawing.Point(12, 458);
            this.fourDaysAwayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fourDaysAwayLabel.Name = "fourDaysAwayLabel";
            this.fourDaysAwayLabel.Size = new System.Drawing.Size(79, 32);
            this.fourDaysAwayLabel.TabIndex = 77;
            this.fourDaysAwayLabel.Text = "Wed";
            // 
            // fiveDaysAwayLabel
            // 
            this.fiveDaysAwayLabel.BackColor = System.Drawing.Color.Transparent;
            this.fiveDaysAwayLabel.Font = new System.Drawing.Font("Arial Nova Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveDaysAwayLabel.ForeColor = System.Drawing.Color.White;
            this.fiveDaysAwayLabel.Location = new System.Drawing.Point(12, 490);
            this.fiveDaysAwayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fiveDaysAwayLabel.Name = "fiveDaysAwayLabel";
            this.fiveDaysAwayLabel.Size = new System.Drawing.Size(79, 32);
            this.fiveDaysAwayLabel.TabIndex = 78;
            this.fiveDaysAwayLabel.Text = "Wed";
            // 
            // sixDaysAwayLabel
            // 
            this.sixDaysAwayLabel.BackColor = System.Drawing.Color.Transparent;
            this.sixDaysAwayLabel.Font = new System.Drawing.Font("Arial Nova Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixDaysAwayLabel.ForeColor = System.Drawing.Color.White;
            this.sixDaysAwayLabel.Location = new System.Drawing.Point(12, 522);
            this.sixDaysAwayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sixDaysAwayLabel.Name = "sixDaysAwayLabel";
            this.sixDaysAwayLabel.Size = new System.Drawing.Size(79, 32);
            this.sixDaysAwayLabel.TabIndex = 79;
            this.sixDaysAwayLabel.Text = "Wed";
            // 
            // forecastPic1
            // 
            this.forecastPic1.BackColor = System.Drawing.Color.Transparent;
            this.forecastPic1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("forecastPic1.BackgroundImage")));
            this.forecastPic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forecastPic1.Location = new System.Drawing.Point(243, 362);
            this.forecastPic1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.forecastPic1.Name = "forecastPic1";
            this.forecastPic1.Size = new System.Drawing.Size(25, 25);
            this.forecastPic1.TabIndex = 80;
            this.forecastPic1.TabStop = false;
            // 
            // forecastPic2
            // 
            this.forecastPic2.BackColor = System.Drawing.Color.Transparent;
            this.forecastPic2.BackgroundImage = global::XMLWeather.Properties.Resources.cloudy;
            this.forecastPic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forecastPic2.Location = new System.Drawing.Point(243, 398);
            this.forecastPic2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.forecastPic2.Name = "forecastPic2";
            this.forecastPic2.Size = new System.Drawing.Size(25, 25);
            this.forecastPic2.TabIndex = 81;
            this.forecastPic2.TabStop = false;
            // 
            // forecastPic3
            // 
            this.forecastPic3.BackColor = System.Drawing.Color.Transparent;
            this.forecastPic3.BackgroundImage = global::XMLWeather.Properties.Resources.cloudy;
            this.forecastPic3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forecastPic3.Location = new System.Drawing.Point(243, 434);
            this.forecastPic3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.forecastPic3.Name = "forecastPic3";
            this.forecastPic3.Size = new System.Drawing.Size(25, 25);
            this.forecastPic3.TabIndex = 82;
            this.forecastPic3.TabStop = false;
            // 
            // forecastPic4
            // 
            this.forecastPic4.BackColor = System.Drawing.Color.Transparent;
            this.forecastPic4.BackgroundImage = global::XMLWeather.Properties.Resources.cloudy;
            this.forecastPic4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forecastPic4.Location = new System.Drawing.Point(243, 470);
            this.forecastPic4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.forecastPic4.Name = "forecastPic4";
            this.forecastPic4.Size = new System.Drawing.Size(25, 25);
            this.forecastPic4.TabIndex = 83;
            this.forecastPic4.TabStop = false;
            // 
            // forecastPic5
            // 
            this.forecastPic5.BackColor = System.Drawing.Color.Transparent;
            this.forecastPic5.BackgroundImage = global::XMLWeather.Properties.Resources.cloudy;
            this.forecastPic5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forecastPic5.Location = new System.Drawing.Point(243, 506);
            this.forecastPic5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.forecastPic5.Name = "forecastPic5";
            this.forecastPic5.Size = new System.Drawing.Size(25, 25);
            this.forecastPic5.TabIndex = 84;
            this.forecastPic5.TabStop = false;
            // 
            // forecastPic6
            // 
            this.forecastPic6.BackColor = System.Drawing.Color.Transparent;
            this.forecastPic6.BackgroundImage = global::XMLWeather.Properties.Resources.cloudy;
            this.forecastPic6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forecastPic6.Location = new System.Drawing.Point(243, 543);
            this.forecastPic6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.forecastPic6.Name = "forecastPic6";
            this.forecastPic6.Size = new System.Drawing.Size(25, 25);
            this.forecastPic6.TabIndex = 85;
            this.forecastPic6.TabStop = false;
            // 
            // low1Label
            // 
            this.low1Label.BackColor = System.Drawing.Color.Transparent;
            this.low1Label.Font = new System.Drawing.Font("Arial Nova Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.low1Label.ForeColor = System.Drawing.Color.White;
            this.low1Label.Location = new System.Drawing.Point(288, 366);
            this.low1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.low1Label.Name = "low1Label";
            this.low1Label.Size = new System.Drawing.Size(80, 32);
            this.low1Label.TabIndex = 86;
            this.low1Label.Text = "L:12°";
            // 
            // high1Label
            // 
            this.high1Label.BackColor = System.Drawing.Color.Transparent;
            this.high1Label.Font = new System.Drawing.Font("Arial Nova Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.high1Label.ForeColor = System.Drawing.Color.White;
            this.high1Label.Location = new System.Drawing.Point(365, 366);
            this.high1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.high1Label.Name = "high1Label";
            this.high1Label.Size = new System.Drawing.Size(80, 32);
            this.high1Label.TabIndex = 87;
            this.high1Label.Text = "H:30°";
            // 
            // low2Label
            // 
            this.low2Label.BackColor = System.Drawing.Color.Transparent;
            this.low2Label.Font = new System.Drawing.Font("Arial Nova Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.low2Label.ForeColor = System.Drawing.Color.White;
            this.low2Label.Location = new System.Drawing.Point(288, 398);
            this.low2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.low2Label.Name = "low2Label";
            this.low2Label.Size = new System.Drawing.Size(80, 32);
            this.low2Label.TabIndex = 88;
            this.low2Label.Text = "L:12°";
            // 
            // low3Label
            // 
            this.low3Label.BackColor = System.Drawing.Color.Transparent;
            this.low3Label.Font = new System.Drawing.Font("Arial Nova Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.low3Label.ForeColor = System.Drawing.Color.White;
            this.low3Label.Location = new System.Drawing.Point(288, 434);
            this.low3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.low3Label.Name = "low3Label";
            this.low3Label.Size = new System.Drawing.Size(80, 32);
            this.low3Label.TabIndex = 89;
            this.low3Label.Text = "L:12°";
            // 
            // low4Label
            // 
            this.low4Label.BackColor = System.Drawing.Color.Transparent;
            this.low4Label.Font = new System.Drawing.Font("Arial Nova Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.low4Label.ForeColor = System.Drawing.Color.White;
            this.low4Label.Location = new System.Drawing.Point(288, 463);
            this.low4Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.low4Label.Name = "low4Label";
            this.low4Label.Size = new System.Drawing.Size(80, 32);
            this.low4Label.TabIndex = 90;
            this.low4Label.Text = "L:12°";
            // 
            // low5Label
            // 
            this.low5Label.BackColor = System.Drawing.Color.Transparent;
            this.low5Label.Font = new System.Drawing.Font("Arial Nova Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.low5Label.ForeColor = System.Drawing.Color.White;
            this.low5Label.Location = new System.Drawing.Point(288, 498);
            this.low5Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.low5Label.Name = "low5Label";
            this.low5Label.Size = new System.Drawing.Size(80, 32);
            this.low5Label.TabIndex = 91;
            this.low5Label.Text = "L:12°";
            // 
            // low6Label
            // 
            this.low6Label.BackColor = System.Drawing.Color.Transparent;
            this.low6Label.Font = new System.Drawing.Font("Arial Nova Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.low6Label.ForeColor = System.Drawing.Color.White;
            this.low6Label.Location = new System.Drawing.Point(288, 530);
            this.low6Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.low6Label.Name = "low6Label";
            this.low6Label.Size = new System.Drawing.Size(80, 32);
            this.low6Label.TabIndex = 92;
            this.low6Label.Text = "L:12°";
            // 
            // high2Label
            // 
            this.high2Label.BackColor = System.Drawing.Color.Transparent;
            this.high2Label.Font = new System.Drawing.Font("Arial Nova Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.high2Label.ForeColor = System.Drawing.Color.White;
            this.high2Label.Location = new System.Drawing.Point(367, 398);
            this.high2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.high2Label.Name = "high2Label";
            this.high2Label.Size = new System.Drawing.Size(80, 32);
            this.high2Label.TabIndex = 93;
            this.high2Label.Text = "H:30°";
            // 
            // high3Label
            // 
            this.high3Label.BackColor = System.Drawing.Color.Transparent;
            this.high3Label.Font = new System.Drawing.Font("Arial Nova Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.high3Label.ForeColor = System.Drawing.Color.White;
            this.high3Label.Location = new System.Drawing.Point(367, 427);
            this.high3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.high3Label.Name = "high3Label";
            this.high3Label.Size = new System.Drawing.Size(80, 32);
            this.high3Label.TabIndex = 94;
            this.high3Label.Text = "H:30°";
            // 
            // high4Label
            // 
            this.high4Label.BackColor = System.Drawing.Color.Transparent;
            this.high4Label.Font = new System.Drawing.Font("Arial Nova Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.high4Label.ForeColor = System.Drawing.Color.White;
            this.high4Label.Location = new System.Drawing.Point(365, 458);
            this.high4Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.high4Label.Name = "high4Label";
            this.high4Label.Size = new System.Drawing.Size(80, 32);
            this.high4Label.TabIndex = 95;
            this.high4Label.Text = "H:30°";
            // 
            // high5Label
            // 
            this.high5Label.BackColor = System.Drawing.Color.Transparent;
            this.high5Label.Font = new System.Drawing.Font("Arial Nova Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.high5Label.ForeColor = System.Drawing.Color.White;
            this.high5Label.Location = new System.Drawing.Point(365, 490);
            this.high5Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.high5Label.Name = "high5Label";
            this.high5Label.Size = new System.Drawing.Size(80, 32);
            this.high5Label.TabIndex = 96;
            this.high5Label.Text = "H:30°";
            // 
            // high6Label
            // 
            this.high6Label.BackColor = System.Drawing.Color.Transparent;
            this.high6Label.Font = new System.Drawing.Font("Arial Nova Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.high6Label.ForeColor = System.Drawing.Color.White;
            this.high6Label.Location = new System.Drawing.Point(367, 522);
            this.high6Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.high6Label.Name = "high6Label";
            this.high6Label.Size = new System.Drawing.Size(80, 32);
            this.high6Label.TabIndex = 97;
            this.high6Label.Text = "H:30°";
            // 
            // optionsBackLabel
            // 
            this.optionsBackLabel.BackColor = System.Drawing.Color.Transparent;
            this.optionsBackLabel.Location = new System.Drawing.Point(13, 591);
            this.optionsBackLabel.Name = "optionsBackLabel";
            this.optionsBackLabel.Size = new System.Drawing.Size(424, 98);
            this.optionsBackLabel.TabIndex = 98;
            // 
            // globeImage
            // 
            this.globeImage.BackColor = System.Drawing.Color.Transparent;
            this.globeImage.BackgroundImage = global::XMLWeather.Properties.Resources.globeImage;
            this.globeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.globeImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.globeImage.Location = new System.Drawing.Point(383, 615);
            this.globeImage.Margin = new System.Windows.Forms.Padding(4);
            this.globeImage.Name = "globeImage";
            this.globeImage.Size = new System.Drawing.Size(27, 25);
            this.globeImage.TabIndex = 99;
            this.globeImage.TabStop = false;
            this.globeImage.Click += new System.EventHandler(this.globeImage_Click);
            // 
            // greetingLabel
            // 
            this.greetingLabel.BackColor = System.Drawing.Color.Transparent;
            this.greetingLabel.Font = new System.Drawing.Font("Arial Nova Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetingLabel.ForeColor = System.Drawing.Color.White;
            this.greetingLabel.Location = new System.Drawing.Point(87, 655);
            this.greetingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(267, 34);
            this.greetingLabel.TabIndex = 100;
            this.greetingLabel.Text = "Good Evening";
            this.greetingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentTimeLabel.Font = new System.Drawing.Font("Arial Nova Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTimeLabel.ForeColor = System.Drawing.Color.White;
            this.currentTimeLabel.Location = new System.Drawing.Point(113, 604);
            this.currentTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(200, 50);
            this.currentTimeLabel.TabIndex = 101;
            this.currentTimeLabel.Text = "00:00";
            this.currentTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // windspeedLabel
            // 
            this.windspeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.windspeedLabel.ForeColor = System.Drawing.Color.White;
            this.windspeedLabel.Location = new System.Drawing.Point(12, 153);
            this.windspeedLabel.Name = "windspeedLabel";
            this.windspeedLabel.Size = new System.Drawing.Size(425, 33);
            this.windspeedLabel.TabIndex = 102;
            this.windspeedLabel.Text = "WS: 8.52m/s";
            this.windspeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.windspeedLabel.Visible = false;
            // 
            // humidityLabel
            // 
            this.humidityLabel.BackColor = System.Drawing.Color.Transparent;
            this.humidityLabel.ForeColor = System.Drawing.Color.White;
            this.humidityLabel.Location = new System.Drawing.Point(12, 138);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(425, 33);
            this.humidityLabel.TabIndex = 103;
            this.humidityLabel.Text = "Humidity: 87%  ";
            this.humidityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.humidityLabel.Visible = false;
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.tornadoBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.humidityLabel);
            this.Controls.Add(this.windspeedLabel);
            this.Controls.Add(this.currentTimeLabel);
            this.Controls.Add(this.greetingLabel);
            this.Controls.Add(this.globeImage);
            this.Controls.Add(this.optionsBackLabel);
            this.Controls.Add(this.high6Label);
            this.Controls.Add(this.high5Label);
            this.Controls.Add(this.high4Label);
            this.Controls.Add(this.high3Label);
            this.Controls.Add(this.high2Label);
            this.Controls.Add(this.low6Label);
            this.Controls.Add(this.low5Label);
            this.Controls.Add(this.low4Label);
            this.Controls.Add(this.low3Label);
            this.Controls.Add(this.low2Label);
            this.Controls.Add(this.high1Label);
            this.Controls.Add(this.low1Label);
            this.Controls.Add(this.forecastPic6);
            this.Controls.Add(this.forecastPic5);
            this.Controls.Add(this.forecastPic4);
            this.Controls.Add(this.forecastPic3);
            this.Controls.Add(this.forecastPic2);
            this.Controls.Add(this.forecastPic1);
            this.Controls.Add(this.sixDaysAwayLabel);
            this.Controls.Add(this.fiveDaysAwayLabel);
            this.Controls.Add(this.fourDaysAwayLabel);
            this.Controls.Add(this.threeDaysAwayLabel);
            this.Controls.Add(this.twoDaysAwayLabel);
            this.Controls.Add(this.oneDayAwayLabel);
            this.Controls.Add(this.upcomingTextLabel);
            this.Controls.Add(this.divider2Label);
            this.Controls.Add(this.divider1Label);
            this.Controls.Add(this.weekBackLabel);
            this.Controls.Add(this.highLowLabel);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.weatherLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.tempBackLabel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(451, 700);
            ((System.ComponentModel.ISupportInitialize)(this.forecastPic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastPic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastPic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastPic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastPic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastPic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globeImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label tempBackLabel;
        private System.Windows.Forms.Label weatherLabel;
        private System.Windows.Forms.Label highLowLabel;
        private System.Windows.Forms.Label weekBackLabel;
        private System.Windows.Forms.Label divider1Label;
        private System.Windows.Forms.Label divider2Label;
        private System.Windows.Forms.Label upcomingTextLabel;
        private System.Windows.Forms.Label oneDayAwayLabel;
        private System.Windows.Forms.Label twoDaysAwayLabel;
        private System.Windows.Forms.Label threeDaysAwayLabel;
        private System.Windows.Forms.Label fourDaysAwayLabel;
        private System.Windows.Forms.Label fiveDaysAwayLabel;
        private System.Windows.Forms.Label sixDaysAwayLabel;
        private System.Windows.Forms.PictureBox forecastPic1;
        private System.Windows.Forms.PictureBox forecastPic2;
        private System.Windows.Forms.PictureBox forecastPic3;
        private System.Windows.Forms.PictureBox forecastPic4;
        private System.Windows.Forms.PictureBox forecastPic5;
        private System.Windows.Forms.PictureBox forecastPic6;
        private System.Windows.Forms.Label low1Label;
        private System.Windows.Forms.Label high1Label;
        private System.Windows.Forms.Label low2Label;
        private System.Windows.Forms.Label low3Label;
        private System.Windows.Forms.Label low4Label;
        private System.Windows.Forms.Label low5Label;
        private System.Windows.Forms.Label low6Label;
        private System.Windows.Forms.Label high2Label;
        private System.Windows.Forms.Label high3Label;
        private System.Windows.Forms.Label high4Label;
        private System.Windows.Forms.Label high5Label;
        private System.Windows.Forms.Label high6Label;
        private System.Windows.Forms.Label optionsBackLabel;
        private System.Windows.Forms.PictureBox globeImage;
        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Label windspeedLabel;
        private System.Windows.Forms.Label humidityLabel;
    }
}
