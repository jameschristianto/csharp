using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConvertion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_fahrenheit_Click(object sender, EventArgs e)
        {
            float temp_fahrenheit = 0;
            float temp_celcius = 0;
            float temp_kelvin = 0;
            float temp_rankine = 0;

            try
            {
                temp_fahrenheit = float.Parse(tb_fahrenheit.Text);
            }
            catch/*(Exception err)*/
            {
                //MessageBox.Show(err.Message, "Warning");
                //MessageBox.Show(err.GetType().ToString(), "Warning");
                MessageBox.Show("Please input correct number", "Warning");
                return;
            }

            temp_celcius = (temp_fahrenheit - 32) * 5f / 9f;
            tb_celcius.Text = temp_celcius.ToString("0.00");
            temp_kelvin = (temp_fahrenheit + 459.67f) * 5f / 9f;
            tb_kelvin.Text = temp_kelvin.ToString("0.00");
            temp_rankine = temp_fahrenheit + 459.67f;
            tb_rankine.Text = temp_rankine.ToString("0.00");

        }

        private void btn_celcius_Click(object sender, EventArgs e)
        {
            float temp_fahrenheit = 0;
            float temp_celcius = 0;
            float temp_kelvin = 0;
            float temp_rankine = 0;

            try
            {
                temp_celcius = float.Parse(tb_celcius.Text);
            }
            catch/*(Exception err)*/
            {
                //MessageBox.Show(err.Message, "Warning");
                //MessageBox.Show(err.GetType().ToString(), "Warning");
                MessageBox.Show("Please input correct number", "Warning");
                return;
            }

            temp_fahrenheit = (temp_celcius * 9f / 5f) + 32;
            tb_fahrenheit.Text = temp_fahrenheit.ToString("0.00");
            temp_kelvin = temp_celcius + 273.15f;
            tb_kelvin.Text = temp_kelvin.ToString("0.00");
            temp_rankine = (temp_celcius * 9f / 5f) + 491.67f;
            tb_rankine.Text = temp_rankine.ToString("0.00");
        }

        private void btn_kelvin_Click(object sender, EventArgs e)
        {
            float temp_fahrenheit = 0;
            float temp_celcius = 0;
            float temp_kelvin = 0;
            float temp_rankine = 0;

            try
            {
                temp_kelvin = float.Parse(tb_kelvin.Text);
            }
            catch/*(Exception err)*/
            {
                //MessageBox.Show(err.Message, "Warning");
                //MessageBox.Show(err.GetType().ToString(), "Warning");
                MessageBox.Show("Please input correct number", "Warning");
                return;
            }

            temp_celcius = temp_kelvin - 273.15f;
            tb_celcius.Text = temp_celcius.ToString("0.00");
            temp_fahrenheit = (temp_kelvin * 9f / 5f) - 459.67f;
            tb_fahrenheit.Text = temp_fahrenheit.ToString("0.00");
            temp_rankine = temp_kelvin * 9f / 5f;
            tb_rankine.Text = temp_rankine.ToString("0.00");
        }

        private void btn_rankine_Click(object sender, EventArgs e)
        {
            float temp_fahrenheit = 0;
            float temp_celcius = 0;
            float temp_kelvin = 0;
            float temp_rankine = 0;

            try
            {
                temp_rankine = float.Parse(tb_rankine.Text);
            }
            catch/*(Exception err)*/
            {
                //MessageBox.Show(err.Message, "Warning");
                //MessageBox.Show(err.GetType().ToString(), "Warning");
                MessageBox.Show("Please input correct number", "Warning");
                return;
            }

            temp_celcius = (temp_rankine * 5f / 9f) - 273.15f;
            tb_celcius.Text = temp_celcius.ToString("0.00");
            temp_fahrenheit = temp_rankine - 459.67f;
            tb_fahrenheit.Text = temp_fahrenheit.ToString("0.00");
            temp_kelvin = temp_rankine * 5f / 9f;
            tb_kelvin.Text = temp_kelvin.ToString("0.00");
        }

        private void tb_fahrenheit_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.KeyChar); // log pressed key

            if ((sender as TextBox).TextLength == 0 && (e.KeyChar == ','))
            {
                e.Handled = true;
                return;
            }
            else if ((sender as TextBox).Text.Contains('-') && (sender as TextBox).TextLength == 1 && (e.KeyChar == ','))
            {
                e.Handled = true;
                return;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1)) // -1 means there is no ','
            {
                e.Handled = true;
            }

            // allow one negative point
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.Contains('-') || ((sender as TextBox).SelectionStart != 0)))
            {
                e.Handled = true;
            }
        }

        private void tb_celcius_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.KeyChar); // log pressed key

            if ((sender as TextBox).TextLength == 0 && (e.KeyChar == ','))
            {
                e.Handled = true;
                return;
            }
            else if ((sender as TextBox).Text.Contains('-') && (sender as TextBox).TextLength == 1 && (e.KeyChar == ','))
            {
                e.Handled = true;
                return;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1)) // -1 means there is no ','
            {
                e.Handled = true;
            }

            // allow one negative point
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.Contains('-') || ((sender as TextBox).SelectionStart != 0)))
            {
                e.Handled = true;
            }
        }

        private void tb_kelvin_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.KeyChar); // log pressed key

            if ((sender as TextBox).TextLength == 0 && (e.KeyChar == ','))
            {
                e.Handled = true;
                return;
            }
            else if ((sender as TextBox).Text.Contains('-') && (sender as TextBox).TextLength == 1 && (e.KeyChar == ','))
            {
                e.Handled = true;
                return;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1)) // -1 means there is no ','
            {
                e.Handled = true;
            }

            // allow one negative point
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.Contains('-') || ((sender as TextBox).SelectionStart != 0)))
            {
                e.Handled = true;
            }
        }

        private void btn_rankine_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.KeyChar); // log pressed key

            if ((sender as TextBox).TextLength == 0 && (e.KeyChar == ','))
            {
                e.Handled = true;
                return;
            }
            else if ((sender as TextBox).Text.Contains('-') && (sender as TextBox).TextLength == 1 && (e.KeyChar == ','))
            {
                e.Handled = true;
                return;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1)) // -1 means there is no ','
            {
                e.Handled = true;
            }

            // allow one negative point
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.Contains('-') || ((sender as TextBox).SelectionStart != 0)))
            {
                e.Handled = true;
            }
        }
    }
}
