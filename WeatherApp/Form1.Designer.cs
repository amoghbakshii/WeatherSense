namespace WeatherApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnGetWeather = new Button();
            lblCity = new Label();
            txtCity = new TextBox();
            lblHumidity = new Label();
            lblWindSpeed = new Label();
            lblUV = new Label();
            lblLocalTime = new Label();
            lblVisibility = new Label();
            lblCloud = new Label();
            fontDialog1 = new FontDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridViewHistory = new DataGridView();
            btnViewHistory = new Button();
            labelTemp = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).BeginInit();
            SuspendLayout();
            // 
            // btnGetWeather
            // 
            btnGetWeather.Font = new Font("Splinter", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGetWeather.Image = (Image)resources.GetObject("btnGetWeather.Image");
            btnGetWeather.Location = new Point(52, 369);
            btnGetWeather.Name = "btnGetWeather";
            btnGetWeather.Size = new Size(307, 99);
            btnGetWeather.TabIndex = 0;
            btnGetWeather.Text = "Get Weather";
            btnGetWeather.UseVisualStyleBackColor = true;
            btnGetWeather.Click += btnGetWeather_Click;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.BackColor = Color.White;
            lblCity.Font = new Font("Serpentine", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCity.ForeColor = Color.Black;
            lblCity.Location = new Point(52, 276);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(327, 28);
            lblCity.TabIndex = 1;
            lblCity.Text = "Enter the city Name";
            lblCity.Click += lblCity_Click;
            // 
            // txtCity
            // 
            txtCity.BackColor = Color.White;
            txtCity.BorderStyle = BorderStyle.FixedSingle;
            txtCity.ForeColor = Color.Black;
            txtCity.Location = new Point(52, 328);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(307, 27);
            txtCity.TabIndex = 5;
            txtCity.TextChanged += txtCity_TextChanged;
            // 
            // lblHumidity
            // 
            lblHumidity.AutoSize = true;
            lblHumidity.Font = new Font("The Bold Font", 16.1999989F, FontStyle.Bold);
            lblHumidity.Location = new Point(434, 222);
            lblHumidity.Name = "lblHumidity";
            lblHumidity.Size = new Size(0, 31);
            lblHumidity.TabIndex = 7;
            lblHumidity.Click += label1_Click;
            // 
            // lblWindSpeed
            // 
            lblWindSpeed.AutoSize = true;
            lblWindSpeed.Font = new Font("The Bold Font", 16.1999989F, FontStyle.Bold);
            lblWindSpeed.Location = new Point(436, 180);
            lblWindSpeed.Name = "lblWindSpeed";
            lblWindSpeed.Size = new Size(0, 31);
            lblWindSpeed.TabIndex = 8;
            // 
            // lblUV
            // 
            lblUV.AutoSize = true;
            lblUV.Font = new Font("The Bold Font", 16.1999989F, FontStyle.Bold);
            lblUV.Location = new Point(436, 324);
            lblUV.Name = "lblUV";
            lblUV.Size = new Size(0, 31);
            lblUV.TabIndex = 9;
            lblUV.Click += lblUV_Click;
            // 
            // lblLocalTime
            // 
            lblLocalTime.AutoSize = true;
            lblLocalTime.Font = new Font("The Bold Font", 16.1999989F, FontStyle.Bold);
            lblLocalTime.Location = new Point(434, 358);
            lblLocalTime.Name = "lblLocalTime";
            lblLocalTime.Size = new Size(0, 31);
            lblLocalTime.TabIndex = 10;
            // 
            // lblVisibility
            // 
            lblVisibility.AutoSize = true;
            lblVisibility.Font = new Font("The Bold Font", 16.1999989F, FontStyle.Bold);
            lblVisibility.Location = new Point(436, 399);
            lblVisibility.Name = "lblVisibility";
            lblVisibility.Size = new Size(0, 31);
            lblVisibility.TabIndex = 11;
            // 
            // lblCloud
            // 
            lblCloud.AutoSize = true;
            lblCloud.Font = new Font("The Bold Font", 16.1999989F, FontStyle.Bold);
            lblCloud.Location = new Point(436, 437);
            lblCloud.Name = "lblCloud";
            lblCloud.Size = new Size(0, 31);
            lblCloud.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Serpentine", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(295, 46);
            label1.Name = "label1";
            label1.Size = new Size(808, 39);
            label1.TabIndex = 13;
            label1.Text = "WeatherSense-Check weather instantly";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(142, 139);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // dataGridViewHistory
            // 
            dataGridViewHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistory.Location = new Point(778, 139);
            dataGridViewHistory.Name = "dataGridViewHistory";
            dataGridViewHistory.RowHeadersWidth = 51;
            dataGridViewHistory.Size = new Size(590, 165);
            dataGridViewHistory.TabIndex = 15;
            dataGridViewHistory.Visible = false;
            // 
            // btnViewHistory
            // 
            btnViewHistory.Font = new Font("Serpentine", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnViewHistory.Image = (Image)resources.GetObject("btnViewHistory.Image");
            btnViewHistory.Location = new Point(930, 367);
            btnViewHistory.Name = "btnViewHistory";
            btnViewHistory.Size = new Size(346, 99);
            btnViewHistory.TabIndex = 16;
            btnViewHistory.Text = "View Weather History";
            btnViewHistory.UseVisualStyleBackColor = true;
            btnViewHistory.Click += btnViewHistory_Click;
            // 
            // labelTemp
            // 
            labelTemp.AutoSize = true;
            labelTemp.Font = new Font("The Bold Font", 16.1999989F, FontStyle.Bold);
            labelTemp.Location = new Point(436, 139);
            labelTemp.Name = "labelTemp";
            labelTemp.Size = new Size(0, 31);
            labelTemp.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1410, 544);
            Controls.Add(labelTemp);
            Controls.Add(btnViewHistory);
            Controls.Add(dataGridViewHistory);
            Controls.Add(label1);
            Controls.Add(lblCloud);
            Controls.Add(lblVisibility);
            Controls.Add(lblLocalTime);
            Controls.Add(lblUV);
            Controls.Add(lblWindSpeed);
            Controls.Add(lblHumidity);
            Controls.Add(btnGetWeather);
            Controls.Add(txtCity);
            Controls.Add(lblCity);
            Controls.Add(pictureBox1);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Weather App";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetWeather;
        private Label lblCity;
        private TextBox txtCity;
        private Label lblHumidity;
        private Label lblWindSpeed;
        private Label lblUV;
        private Label lblLocalTime;
        private Label lblVisibility;
        private Label lblCloud;
        private FontDialog fontDialog1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewHistory;
        private Button btnViewHistory;
        private Label labelTemp;
    }
}
