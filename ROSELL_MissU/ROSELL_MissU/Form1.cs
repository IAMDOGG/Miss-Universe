using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ROSELL_MissU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Top_20_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Top_20.SelectedItem != null)
            {

                string selectedItem = Top_20.SelectedItem.ToString();


                if (Top_20.Items.Count == 10)
                {
                    MessageBox.Show("Top 10 is full.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                Top_20.Items.Remove(selectedItem);
                Top_10.Items.Add(selectedItem);
            }

            if (Top_10.Items.Count == 10)
            {
                Top_20.Enabled = false;
            }





        }

        private void SavetoFile(ListBox listBox, string fileName)
        {
            
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                
                foreach (string item in listBox.Items)
                {
                    sw.WriteLine(item);
                }
            }
        }
        private void btn_t20_Click(object sender, EventArgs e)
        {
            
            if (Top_10.Items.Count != 0)
            {
                string fileName = "Top_20.txt";
                File.WriteAllText(fileName, "");
                
                SavetoFile(Top_20, fileName);

                
                MessageBox.Show("Success!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The list is empty. Nothing to print.");
                return;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Top_10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Top_10.SelectedItem != null)
            {
                string selectedItem = Top_10.SelectedItem.ToString();
                Top_10.Items.Remove(selectedItem);
                Top_3.Items.Add(selectedItem);

                if (Top_3.Items.Count == 3)
                {
                    MessageBox.Show("Top 3 is full.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            if (Top_3.Items.Count == 3)
            {
                Top_10.Enabled = false;
            }
        }

        private void btn_t10_Click(object sender, EventArgs e)
        {
            if (Top_10.Items.Count != 0)
            {

                string fileName = "Top_10.txt";
                File.WriteAllText(fileName, "");
                
                SavetoFile(Top_10, fileName);

                
                MessageBox.Show("Success!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The list is empty. Nothing to print.");
                return;
            }
        }

        private void Top_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Top_3.SelectedItem != null)
            {

                string selectedItem = Top_3.SelectedItem.ToString();
                Top_3.Items.Remove(selectedItem);
                Miss_Universe.Items.Add(selectedItem);

                MessageBox.Show(selectedItem + " is the Miss Universe!", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Miss_Universe.Items.Count == 1)
            {
                Top_3.Enabled = false;
            }
        }

        private void btn_t3_Click(object sender, EventArgs e)
        {
            if (Top_3.Items.Count != 0)
            {
                string fileName = "Top_3.txt";
                File.WriteAllText(fileName, "");
                
                SavetoFile(Top_3, fileName);

                
                MessageBox.Show("Success!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The list is empty. Nothing to print.");
                return;
            }
        }

        private void btn_missU_Click(object sender, EventArgs e)
        {
            if (Miss_Universe.Items.Count != 0)
            {
                string fileName = "Miss_U.txt";
                File.WriteAllText(fileName, "");
                
                SavetoFile(Miss_Universe, fileName);

                
                MessageBox.Show("Success!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The list is empty. Nothing to print.");
                return;
            }
        }
    }
    }
    


