using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            listBox1.HorizontalScrollbar = true;
            listBox1.MultiColumn = true;
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Items.AddRange(new object[] {
                "January","February","March","April","May","June","July","August","September","October","November","December"
            });
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                MessageBox.Show(listBox1.SelectedItem.ToString());
            }
        }
    }
}
