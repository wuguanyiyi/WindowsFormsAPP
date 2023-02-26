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
using WindowsFormsAPP.Models;

namespace WindowsFormsAPP
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContactsTable data = new ContactsTable()
            {
                name = textBox1.Text.Trim(),
            };
            try
            {
                ContactsModel context = new ContactsModel();
                context.ContactsTable.(data);
                context.SaveChanges();
                MessageBox.Show("刪除完成");
                ClearTextBoxes();
            }
            catch (Exception ex)
            { MessageBox.Show($"發生錯誤 {ex.ToString()}"); }
        }
        private void ClearTextBoxes()
        {
            textBox1.Clear();
        }
    }
}
