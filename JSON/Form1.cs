using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JSON
{
    public partial class Form1 : Form
    {
        List<Data> data = new List<Data>();

        public Form1()
        {
            InitializeComponent();
            btn_add.Enabled = false;

            // Load JSON
            String jsonFormat = System.IO.File.ReadAllText(@"..\..\res\load.json");
            JToken jsonType = JToken.Parse(jsonFormat);
            if (jsonType is JArray)
            {
                System.Diagnostics.Debug.WriteLine("Array JSON");
                List<Data> jsonData = JsonConvert.DeserializeObject<List<Data>>(jsonFormat);
                jsonFormat = JsonConvert.SerializeObject(jsonData, Formatting.Indented); // Formatting JSON
                data.AddRange(jsonData);
            }
            else if (jsonType is JObject)
            {
                System.Diagnostics.Debug.WriteLine("Object JSON");
                Data jsonData = JsonConvert.DeserializeObject<Data>(jsonFormat);
                jsonFormat = JsonConvert.SerializeObject(jsonData, Formatting.Indented); // Formatting JSON
                data.Add(jsonData);
            }

            System.IO.File.WriteAllText(@"..\..\res\save.json", jsonFormat);
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            btn_add.Enabled = !Controls.OfType<TextBox>().Any(x => string.IsNullOrEmpty(x.Text));
        }

        private void tb_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tb_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void tb_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tb_hobbies_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ',');
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //convert to int
            //int val = 0;
            //int convert = 0;
            //convert Int32.TryParse(tb_id.Text, out val);
            //convert = Int32.Parse(tb_id.Text);

            String[] hobbies = tb_hobbies.Text.Split(',');

            data.Add(new Data
            {
                id = Convert.ToInt32(tb_id.Text),
                name = tb_name.Text,
                gender = cb_gender.Text,
                age = Convert.ToInt32(tb_age.Text),
                hobbies = new List<String>(hobbies)
            });

            string jsonFormat = JsonConvert.SerializeObject(data, Formatting.Indented); // Formatting JSON
            System.IO.File.WriteAllText(@"..\..\res\save.json", jsonFormat);

            tb_clear();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_clear();
        }

        private void tb_clear()
        {
            tb_id.Clear();
            tb_name.Clear();
            tb_age.Clear();
            tb_hobbies.Clear();
            cb_gender.SelectedIndex = -1;
        }
    }
}
