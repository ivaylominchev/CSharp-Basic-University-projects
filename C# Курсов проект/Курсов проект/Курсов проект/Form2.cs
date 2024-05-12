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
    public partial class Form2 : Form
    {
        Form1 gl;
        public Form2(Form1 gl)
        {
            InitializeComponent();
            this.gl = gl;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Намери_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gl.cards.Count; i++)
            {
                if (textBox1.Text == gl.cards[i].CardType && gl.cards[i].Balance > 0)
                {
                    DGrid.Rows.Add(gl.cards[i].CardNumber, gl.cards[i].CardType, gl.cards[i].Balance);
                    DGrid.Show();
                }
                    
            }
        }
    }
}
