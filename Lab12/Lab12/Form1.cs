using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[,] Q = {
            { -0.4, 0.3, 0.1 },
            { 0.4, -0.8, 0.4 },
            { 0.1, 0.4, -0.5 }
        };
        double[] ProbabilitiesArr = new double[3];
        int days, weather = 0, countClear = 0, countCloudy = 0, countOvercast = 0, k = 0;

        double dt, RandProbability, t = 0;
        public double[] frequency = new double[3];

        private void StartButton_Click(object sender, EventArgs e)
        {
            Clear();
            days = (int)DaysNumeric.Value;
            timer1.Start();
        }

        public void Clear()
        {
            for (int i = 0; i < 3; i++)
            {
                frequency[i] = 0;
                WeatherChart.Series[i].Points.Clear();
            }
            weather = 0;
            countClear = 0; countCloudy = 0; countOvercast = 0; k = 0;
            dt = 0; RandProbability = 0; t = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (k < days)
            {
                if (t < 10)
                {
                    dt = Math.Log(rnd.NextDouble()) / Q[weather, weather];
                    t += dt;
                    k++;
                    for (int i = 0; i < 3; i++)
                        if (i != weather)
                            ProbabilitiesArr[i] = -Q[weather, i] / Q[weather, weather];
                        else
                            ProbabilitiesArr[i] = 0;

                    RandProbability = rnd.NextDouble();
                    for (int i = 0; i < 3; i++)
                    {
                        RandProbability -= ProbabilitiesArr[i];
                        if (RandProbability <= 0)
                        {
                            weather = i;
                            break;
                        }
                    }
                    switch (weather + 1)
                    {
                        case 1:
                            countClear++;
                            WeatherChart.Series[0].Points.AddXY(1, countClear);
                            break;
                        case 2:
                            countCloudy++;
                            WeatherChart.Series[1].Points.AddXY(1, countCloudy);
                            break;
                        case 3:
                            countOvercast++;
                            WeatherChart.Series[2].Points.AddXY(1, countOvercast);
                            break;
                    }  //рисование графика
                    frequency[weather]++;
                }
                else // для солнечной
                {
                    weather = 0;
                    frequency[weather]++;
                    t = 0;
                    k++;
                    countClear++;
                    WeatherChart.Series[0].Points.AddXY(1, countClear);
                }
            }
            else
            {
                CalcDistribution();
                timer1.Stop();
            }

        }

        public void CalcDistribution()
        {
            for (int i = 0; i < 3; i++)
            {
                frequency[i] = frequency[i] / days;
                switch (i)
                {
                    case 0:
                        ClearDistr.Text = frequency[i].ToString();
                        ClearDays.Text = countClear.ToString();
                        break;
                    case 1:
                        CloudyDistr.Text = frequency[i].ToString();
                        CloudyDays.Text = countCloudy.ToString();
                        break;
                    case 2:
                        OvercastDistr.Text = frequency[i].ToString();
                        OvercastDays.Text = countOvercast.ToString();
                        break;
                }

            }
        }
    }
}
