using System;
using System.Collections; // Array list
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; // Stream reader
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string path = @"..\..\res\list.txt"; // alternative "..\\..\\res\\list.txt"
            loadTextFile(path);

            btn_add.Enabled = false; // disable add button when textbox empty
        }

        private void loadTextFile(string path)
        {
            List<string> lines = new List<string>();
            try
            {
                using (StreamReader r = new StreamReader(path))
                {
                    string line;
                    lb_name.Items.Clear();
                    while ((line = r.ReadLine()) != null)
                    {
                        lines.Add(line); // save list here
                        lb_name.Items.Add(line);
                    }
                }
            }
            catch(FileNotFoundException)
            {
                System.Diagnostics.Debug.WriteLine("File Not Found");
                MessageBox.Show("File Not Found", "Error");
            }

        }

        private void saveTextFile(string path)
        {
            try
            {
                StreamWriter w = new StreamWriter(path); // add parameter append:true for append file
                foreach (var item in lb_name.Items)
                {
                    w.WriteLine(item);
                }
                w.Close();
            }
            catch (DirectoryNotFoundException)
            {
                System.Diagnostics.Debug.WriteLine("Directory Not Found");
                MessageBox.Show("Directory Not Found", "Error");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!lb_name.Items.Contains(tb_name.Text))
            {
                lb_name.Items.Add(tb_name.Text);
                tb_name.Clear();
            }
            else
            {
                MessageBox.Show("Name already available", "Warning");
            }
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            btn_add.Enabled = !string.IsNullOrEmpty(tb_name.Text);
        }

        private void tb_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_name.Clear();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            string path = @"..\..\res\list.txt";
            loadTextFile(path);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string path = @"..\..\ress\list.txt";
            saveTextFile(path);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            lb_name.Items.Remove(lb_name.SelectedItem);
        }

        private void btn_clear_list_Click(object sender, EventArgs e)
        {
            lb_name.Items.Clear();
        }

        private void btn_ascending_Click(object sender, EventArgs e)
        {
            lb_name.Sorted = true;
            lb_name.Sorted = false; // Changed back to false so that it can be sorted again
        }

        private void btn_descending_Click(object sender, EventArgs e)
        {
            List<object> obj = new List<object>();

            foreach(var o in lb_name.Items)
            {
                obj.Add(o);
            }

            obj.Sort();
            obj.Reverse();
            lb_name.Items.Clear();

            foreach(var o in obj)
            {
                lb_name.Items.Add(o);
            }
        }

        private void btn_up(object sender, EventArgs e)
        {
            object selected = lb_name.SelectedItem;
            int newIndex = lb_name.SelectedIndex - 1;

            if (lb_name.SelectedIndex == -1) return;

            if (lb_name.SelectedIndex != 0)
            {
                lb_name.Items.Remove(selected);
                lb_name.Items.Insert(newIndex, selected);
                lb_name.SetSelected(newIndex, true);
            }

            return;
        }

        private void btn_down(object sender, EventArgs e)
        {
            object selected = lb_name.SelectedItem;
            int newIndex = lb_name.SelectedIndex + 1;

            if (lb_name.SelectedIndex == -1) return;

            if (lb_name.SelectedIndex != lb_name.Items.Count - 1)
            {
                lb_name.Items.Remove(selected);
                lb_name.Items.Insert(newIndex, selected);
                lb_name.SetSelected(newIndex, true);
            }

            return;
        }

        private void btn_save_to_Click(object sender, EventArgs e)
        {
            // Open folder
            /*FolderBrowserDialog saveDialog = new FolderBrowserDialog();
            
            DialogResult result = saveDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(saveDialog.SelectedPath))
            {
                string path = saveDialog.SelectedPath + @"\list.txt";
                saveTextFile(path);
            }*/

            // Open file
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = ".txt";
            saveDialog.Filter = "Text documents (.txt)|*.txt";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                //string path = Path.GetDirectoryName(saveDialog.FileName); // Get path file
                System.Diagnostics.Debug.WriteLine(saveDialog.FileName);
                saveTextFile(saveDialog.FileName);
            }
        }

        private void btn_load_from_Click(object sender, EventArgs e)
        {
            // Open folder
            /*using (FolderBrowserDialog loadDialog = new FolderBrowserDialog())
            {
                DialogResult result = loadDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(loadDialog.SelectedPath))
                {
                    String path = loadDialog.SelectedPath + @"/list.txt";
                    loadTextFile(path);
                }
            }*/

            // Open file
            OpenFileDialog loadDialog = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "txt files (*.txt)|*.txt"
            };

            loadDialog.InitialDirectory = @"C:\"; // Different method set parameter

            if (loadDialog.ShowDialog() == DialogResult.OK)
            {
                loadTextFile(loadDialog.FileName);
            }
        }
    }
}
