using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new object[] {
                "January","February","March","April","May","June","July","August","September","October","November","December"
            });
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int month = comboBox1.SelectedIndex + 1;
            Object[] day;

            if (month == 4 || month == 6 || month == 9 || month == 11) day = new object[] {
            1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30};
            else if (month == 2) day = new object[] {
            1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29};
            else day = new object[] {
            1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31};

            comboBox2.DataSource = day;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0) MessageBox.Show("You not select month");
            else MessageBox.Show($"Your Birthday is {comboBox1.SelectedIndex + 1}/{comboBox2.SelectedValue.ToString()}");
        }
    }
}
