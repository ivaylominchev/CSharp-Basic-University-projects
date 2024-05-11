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
        public Form3(Form1 f)
        {
            InitializeComponent();
            gl = f;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Card cr = new Card();
            cr.CardNumber = Convert.ToInt32(textBox1.Text);
            cr.CardType = textBox2.Text;
            cr.Date = textBox3.Text;
            cr.Currency = textBox4.Text;
            cr.Balance = Convert.ToDecimal(textBox5.Text);
            gl.cards.Add(cr);
            Close();
        }
    }
}
