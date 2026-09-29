using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sestaura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tocke = 0;
            if (comboBox1.Text == string.Empty)
            {
                MessageBox.Show("Nekaj izberi");
            }
            else if (!radioButton1.Checked &&
                !radioButton2.Checked &&
                !radioButton3.Checked &&
                !radioButton4.Checked)
            {
                MessageBox.Show("Izberi psa");
            }
            else
                {

            
                if (radioButton2.Checked)
                {
                    tocke++;
                }
                if (dateTimePicker1.Value.Date == Convert.ToDateTime("3.12.1800"))
                {
                    tocke++;
                }
                if (checkedListBox1.CheckedItems.Contains("Toyota") &&
                    checkedListBox1.CheckedItems.Contains("Suzuki") &&
                    checkedListBox1.CheckedItems.Contains("Honda") &&
                    checkedListBox1.CheckedItems.Count == 3)

                {
                    tocke++;
                }
                if (comboBox1.Text == "Drava")
                {
                    tocke++;
                }
                if (checkBox1.Checked)
                {
                    tocke++;
                }
                MessageBox.Show("dosezene tocke: " + tocke);
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
        }
    }
}
