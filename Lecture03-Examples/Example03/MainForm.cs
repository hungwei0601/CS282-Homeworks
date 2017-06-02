using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherStationLibrary;

namespace Example03
{
    public partial class MainForm : Form
    {
        private WeatherData data;

        public MainForm()
        {
            InitializeComponent();
            data = new WeatherData()
            {
                Temperature = 30.32,
                Humidity = 90.8927,
                Pressure = 1
            };
        }

        private void temperalabel1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TemperatureLabel.Text = "溫度:" + data.Temperature.ToString();
            HumidityLabel.Text = "濕度:" + data.Humidity.ToString("#.#");
            PressureLabel.Text = "壓力:" + data.Pressure.ToString("#.#");
        }
    }
}