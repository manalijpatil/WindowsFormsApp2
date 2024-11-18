using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains(textValue.Text))
            {
                MessageBox.Show("This value is already exist!!");
            }
            else
            {
                listBox1.Items.Add(textValue.Text);


            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains(textValue.Text))
            
            {
                listBox1.Items.Remove(textValue.Text);
                MessageBox.Show(textValue.Text + " is deleted");
            }
            else
            {
                MessageBox.Show("Your list is empty");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textValue.Clear();
        }
    }
}
