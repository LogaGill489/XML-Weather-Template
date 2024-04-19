namespace XMLWeather
{
    partial class WorldSearch
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.insertLabel = new System.Windows.Forms.Label();
            this.backgroundLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::XMLWeather.Properties.Resources.spaceGif;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::XMLWeather.Properties.Resources.spaceGif;
            this.pictureBox1.Location = new System.Drawing.Point(0, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 495);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cityInput
            // 
            this.cityInput.BackColor = System.Drawing.Color.CadetBlue;
            this.cityInput.Font = new System.Drawing.Font("Arial Nova Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityInput.ForeColor = System.Drawing.Color.Black;
            this.cityInput.Location = new System.Drawing.Point(27, 79);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(400, 32);
            this.cityInput.TabIndex = 1;
            this.cityInput.Text = "Please Insert The Desired City";
            this.cityInput.Enter += new System.EventHandler(this.cityInput_Enter);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Font = new System.Drawing.Font("Arial Nova Cond Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(125, 117);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(200, 50);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search!";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // insertLabel
            // 
            this.insertLabel.BackColor = System.Drawing.Color.Transparent;
            this.insertLabel.Font = new System.Drawing.Font("Arial Nova Cond", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertLabel.ForeColor = System.Drawing.Color.White;
            this.insertLabel.Location = new System.Drawing.Point(38, 16);
            this.insertLabel.Name = "insertLabel";
            this.insertLabel.Size = new System.Drawing.Size(375, 43);
            this.insertLabel.TabIndex = 4;
            this.insertLabel.Text = "City Search\r\n";
            this.insertLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundLabel
            // 
            this.backgroundLabel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.backgroundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.backgroundLabel.ForeColor = System.Drawing.Color.Black;
            this.backgroundLabel.Location = new System.Drawing.Point(15, 16);
            this.backgroundLabel.Name = "backgroundLabel";
            this.backgroundLabel.Size = new System.Drawing.Size(421, 160);
            this.backgroundLabel.TabIndex = 5;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Font = new System.Drawing.Font("Arial Nova Cond", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(322, 652);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(114, 33);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Return!";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // WorldSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.cityInput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.insertLabel);
            this.Controls.Add(this.backgroundLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WorldSearch";
            this.Size = new System.Drawing.Size(451, 700);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label insertLabel;
        private System.Windows.Forms.Label backgroundLabel;
        private System.Windows.Forms.Button backButton;
    }
}
