namespace Lab12
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Label1 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.DaysNumeric = new System.Windows.Forms.NumericUpDown();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.ClearDays = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.CloudyDays = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.OvercastDays = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.OvercastDistr = new System.Windows.Forms.Label();
            this.CloudyDistr = new System.Windows.Forms.Label();
            this.ClearDistr = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.WeatherChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DaysNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(339, 20);
            this.Label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(300, 38);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Симулятор погоды";
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(521, 76);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(191, 51);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // DaysNumeric
            // 
            this.DaysNumeric.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DaysNumeric.Location = new System.Drawing.Point(202, 76);
            this.DaysNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DaysNumeric.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DaysNumeric.Name = "DaysNumeric";
            this.DaysNumeric.Size = new System.Drawing.Size(171, 30);
            this.DaysNumeric.TabIndex = 2;
            this.DaysNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label2.Location = new System.Drawing.Point(208, 109);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(158, 23);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Количество дней";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label4.Location = new System.Drawing.Point(57, 59);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(121, 23);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "Кол-во дней:";
            // 
            // ClearDays
            // 
            this.ClearDays.AutoSize = true;
            this.ClearDays.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearDays.Location = new System.Drawing.Point(110, 124);
            this.ClearDays.Name = "ClearDays";
            this.ClearDays.Size = new System.Drawing.Size(20, 23);
            this.ClearDays.TabIndex = 6;
            this.ClearDays.Text = "0";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label6.Location = new System.Drawing.Point(9, 124);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(52, 23);
            this.Label6.TabIndex = 7;
            this.Label6.Text = "Ясно";
            // 
            // CloudyDays
            // 
            this.CloudyDays.AutoSize = true;
            this.CloudyDays.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloudyDays.Location = new System.Drawing.Point(110, 188);
            this.CloudyDays.Name = "CloudyDays";
            this.CloudyDays.Size = new System.Drawing.Size(20, 23);
            this.CloudyDays.TabIndex = 8;
            this.CloudyDays.Text = "0";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label8.Location = new System.Drawing.Point(9, 188);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(86, 23);
            this.Label8.TabIndex = 9;
            this.Label8.Text = "Облачно";
            // 
            // OvercastDays
            // 
            this.OvercastDays.AutoSize = true;
            this.OvercastDays.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OvercastDays.Location = new System.Drawing.Point(110, 254);
            this.OvercastDays.Name = "OvercastDays";
            this.OvercastDays.Size = new System.Drawing.Size(20, 23);
            this.OvercastDays.TabIndex = 10;
            this.OvercastDays.Text = "0";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label10.Location = new System.Drawing.Point(9, 254);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(96, 23);
            this.Label10.TabIndex = 11;
            this.Label10.Text = "Пасмурно";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label11.Location = new System.Drawing.Point(198, 59);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(195, 23);
            this.Label11.TabIndex = 12;
            this.Label11.Text = "Стац. распределение:";
            // 
            // OvercastDistr
            // 
            this.OvercastDistr.AutoSize = true;
            this.OvercastDistr.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OvercastDistr.Location = new System.Drawing.Point(283, 254);
            this.OvercastDistr.Name = "OvercastDistr";
            this.OvercastDistr.Size = new System.Drawing.Size(20, 23);
            this.OvercastDistr.TabIndex = 15;
            this.OvercastDistr.Text = "0";
            // 
            // CloudyDistr
            // 
            this.CloudyDistr.AutoSize = true;
            this.CloudyDistr.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloudyDistr.Location = new System.Drawing.Point(283, 188);
            this.CloudyDistr.Name = "CloudyDistr";
            this.CloudyDistr.Size = new System.Drawing.Size(20, 23);
            this.CloudyDistr.TabIndex = 14;
            this.CloudyDistr.Text = "0";
            // 
            // ClearDistr
            // 
            this.ClearDistr.AutoSize = true;
            this.ClearDistr.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearDistr.Location = new System.Drawing.Point(283, 124);
            this.ClearDistr.Name = "ClearDistr";
            this.ClearDistr.Size = new System.Drawing.Size(20, 23);
            this.ClearDistr.TabIndex = 13;
            this.ClearDistr.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // WeatherChart
            // 
            chartArea4.Name = "ChartArea1";
            this.WeatherChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Clear days";
            legend4.TitleBackColor = System.Drawing.Color.Transparent;
            this.WeatherChart.Legends.Add(legend4);
            this.WeatherChart.Location = new System.Drawing.Point(402, 157);
            this.WeatherChart.Name = "WeatherChart";
            this.WeatherChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Clear days";
            series10.Name = "Ясные дни";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Clear days";
            series11.Name = "Облачные дни";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Clear days";
            series12.Name = "Пасмурные дни";
            this.WeatherChart.Series.Add(series10);
            this.WeatherChart.Series.Add(series11);
            this.WeatherChart.Series.Add(series12);
            this.WeatherChart.Size = new System.Drawing.Size(567, 385);
            this.WeatherChart.TabIndex = 16;
            this.WeatherChart.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.DaysNumeric);
            this.panel1.Controls.Add(this.StartButton);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 158);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.OvercastDistr);
            this.panel2.Controls.Add(this.CloudyDistr);
            this.panel2.Controls.Add(this.ClearDistr);
            this.panel2.Controls.Add(this.Label11);
            this.panel2.Controls.Add(this.Label10);
            this.panel2.Controls.Add(this.OvercastDays);
            this.panel2.Controls.Add(this.Label8);
            this.panel2.Controls.Add(this.CloudyDays);
            this.panel2.Controls.Add(this.Label6);
            this.panel2.Controls.Add(this.ClearDays);
            this.panel2.Controls.Add(this.Label4);
            this.panel2.Location = new System.Drawing.Point(0, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 384);
            this.panel2.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 43F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WeatherChart);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DaysNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.NumericUpDown DaysNumeric;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label ClearDays;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label CloudyDays;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label OvercastDays;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.Label OvercastDistr;
        private System.Windows.Forms.Label CloudyDistr;
        private System.Windows.Forms.Label ClearDistr;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart WeatherChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

