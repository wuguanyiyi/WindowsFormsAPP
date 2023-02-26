using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            var form = new AddForm();
            form.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var form = new ReviseForm();
            form.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var form = new DeleteForm();
            form.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            var form = new InquireForm();
            form.Show();
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            var form = new ViewForm();
            form.Show();
        }









    }
}
