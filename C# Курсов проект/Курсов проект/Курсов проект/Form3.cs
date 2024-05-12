using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсов_проект
{
    public partial class Form3 : Form
    {
        Form1 gl;
        public Form3(Form1 gl)
        {
            InitializeComponent();
            this.gl = gl;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse( textBox1.Text, out int cardNumber);
            string cardType = textBox2.Text;
            string date = textBox3.Text;
            string currency = textBox4.Text;
            decimal.TryParse(textBox5.Text, out decimal balance);
            gl.AddToDGrid(cardNumber, cardType, date, currency, balance);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
