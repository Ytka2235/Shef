using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Shef
{
    public partial class Form1 : Form
    {
        public string[] strings1 = new string[] { "Макароны", "Стейк" };
        public string[] strings2 = new string[] { "Котлета", "Рыба" };
        public string[] strings3 = new string[] { "Чай", "Кофе" };
        public string[] strings4 = new string[] { "Оливье", "Цезарь" };

        public int[] ints1 = new int[] {100,1000};
        public int[] ints2 = new int[] {200,2000};
        public int[] ints3 = new int[] {300,3000 };
        public int[] ints4 = new int[] {400,4000 };


        public Form1()
        {
            InitializeComponent();
            foreach (var item in strings1 ) 
            {
                comboBox1.Items.Add(item);
            }
            foreach (var item in strings2)
            {
                comboBox2.Items.Add(item);
            }
            foreach (var item in strings3)
            {
                comboBox3.Items.Add(item);
            }
            foreach (var item in strings4)
            {
                comboBox4.Items.Add(item);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)sender;
            string selectedEmployee = (string)comboBox1.SelectedItem;
            int resultIndex = -1;
            resultIndex = comboBox1.FindStringExact(selectedEmployee);
            if (resultIndex != -1)
            {
                labelRez1.Text = ints1[resultIndex].ToString();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)sender;
            string selectedEmployee = (string)comboBox2.SelectedItem;
            int resultIndex = -1;
            resultIndex = comboBox2.FindStringExact(selectedEmployee);
            if (resultIndex != -1)
            {
                labelRez2.Text = ints2[resultIndex].ToString();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)sender;
            string selectedEmployee = (string)comboBox3.SelectedItem;
            int resultIndex = -1;
            resultIndex = comboBox3.FindStringExact(selectedEmployee);
            if (resultIndex != -1)
            {
                labelRez3.Text = ints3[resultIndex].ToString();
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)sender;
            string selectedEmployee = (string)comboBox4.SelectedItem;
            int resultIndex = -1;
            resultIndex = comboBox4.FindStringExact(selectedEmployee);
            if (resultIndex != -1)
            {
                labelRez4.Text = ints4[resultIndex].ToString();
            }
        }

        private void but1_Click(object sender, EventArgs e)
        {
            lablePrice.Text = "" + (int.Parse(lablePrice.Text) + int.Parse(labelRez1.Text));
        }

        private void but2_Click(object sender, EventArgs e)
        {
            lablePrice.Text = "" + (int.Parse(lablePrice.Text) + int.Parse(labelRez2.Text));
        }

        private void but3_Click(object sender, EventArgs e)
        {
            lablePrice.Text = "" + (int.Parse(lablePrice.Text) + int.Parse(labelRez3.Text));
        }

        private void but4_Click(object sender, EventArgs e)
        {
            lablePrice.Text = "" + (int.Parse(lablePrice.Text) + int.Parse(labelRez4.Text));
        }

        private void butreset_Click(object sender, EventArgs e)
        {
            lablePrice.Text = "0";
        }
    }
}
