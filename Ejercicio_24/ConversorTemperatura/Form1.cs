using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temperatura;

namespace ConversorTemperatura
{
    public partial class ConversorGrados : Form
    {
        public ConversorGrados()
        {
            InitializeComponent();
        }

        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            Fahrenheit entrada = new Fahrenheit(Convert.ToDouble(txtFahrenheit.Text));
            txtFarAFar.Text = txtFahrenheit.Text;
            txtFarACelsius.Text = ((Celsius)entrada).GetGrados().ToString("0.##");
            txtFarAKelvin.Text = ((Kelvin)entrada).GetGrados().ToString("0.##");
        }

        private void btnCelsius_Click(object sender, EventArgs e)
        {
            Celsius entrada = new Celsius(Convert.ToDouble(txtCelsius.Text));
            txtCelsiusAFar.Text = ((Fahrenheit)entrada).GetGrados().ToString("0.##");
            txtCelsiusACelsius.Text = txtCelsius.Text;
            txtCelsiusAKelvin.Text = ((Kelvin)entrada).GetGrados().ToString("0.##");
        }

        private void btnKelvin_Click(object sender, EventArgs e)
        {
            Kelvin entrada = new Kelvin(Convert.ToDouble(txtKelvin.Text));
            txtKelvinAFar.Text = ((Fahrenheit)entrada).GetGrados().ToString("0.##");
            txtKelvinACelsius.Text = ((Celsius)entrada).GetGrados().ToString("0.##");
            txtKelvinAKelvin.Text = txtKelvin.Text;
        }
    }
}
