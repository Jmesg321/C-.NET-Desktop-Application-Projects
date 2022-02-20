using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Celsius_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_fahrenheit_Click(object sender, EventArgs e)
        {
            convertFromFahrenheit();
        }
        private void convertFromFahrenheit()
        {
            float f = 0;

            try
            {
                f = float.Parse(txt_fahrenheit.Text);
            }
            catch
            {
                MessageBox.Show("Please Input a Number");
            }
            f = float.Parse(txt_fahrenheit.Text);

            float c = 5f / 9f * (f - 32);
            float k = c - 273;

            txt_celsius.Text = c.ToString();
            txt_kelvin.Text = k.ToString();
        }
        private void convertCelcius()
        {
            float f = 0;

            try
            {
                f = float.Parse(txt_celsius.Text);
            }
            catch
            {
                MessageBox.Show("Please Input a Number");
            }
            f = float.Parse(txt_celsius.Text);

            float c = 9f / 5f * (f) + 32;
            float k = c + 273;

            txt_fahrenheit.Text = c.ToString();
            txt_kelvin.Text = k.ToString();
        }
        private void convertKelvin()
        {
            float f = 0;

            try
            {
                f = float.Parse(txt_kelvin.Text);
            }
            catch
            {
                MessageBox.Show("Please Input a Number");
            }
            f = float.Parse(txt_kelvin.Text);

            float c = 9f / 5f * (f - 273) + 32;
            float k = c - 273;

            txt_fahrenheit.Text = c.ToString();
            txt_celsius.Text = k.ToString();
        }


        private void btn_celsius_Click(object sender, EventArgs e)
        {
            convertCelcius();
        }

        private void btn_kelvin_Click(object sender, EventArgs e)
        {
            convertKelvin();
        }
    }
}
