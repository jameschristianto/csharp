using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonAndText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn_disconnect.Enabled = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            btn_connect.Enabled = false;
            btn_disconnect.Enabled = true;
            status.Text = "Connected";
            greet.Text = "Hi, Welcome to my application...";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            btn_connect.Enabled = true;
            btn_disconnect.Enabled = false;
            status.Text = "Disonnected";
            greet.Text = null;
        }
        private async void btn_exit_Click(object sender, EventArgs e)
        {
            btn_connect.Enabled = false;
            btn_disconnect.Enabled = false;
            await Task.Run(() => showLabel(greet, "Closing application..."));
            System.Threading.Thread.Sleep(500); //sync delay
            //await Task.Delay(500); //async delay
            this.Close(); //close app
        }
        private void showLabel(Label label, String text)
        {
            Action action = () =>
            {
                label.Text = text;
            };

            if (label.InvokeRequired)
                label.Invoke(action); // When in different thread
            else
                action(); // When in the main thread
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
