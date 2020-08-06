using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
            if (textBox1.Text=="Eduardo" && textBox2.Text=="123456")
            {
                MessageBox.Show("Sejá muito bem vindo!");
                Form2 frm = new Form2();
                frm.Show();
            }

            else
            {
                MessageBox.Show("Usuário ou senha está incorreto.");
            }

        }
    }
}
