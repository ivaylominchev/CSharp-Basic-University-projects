﻿using System;
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
            gl.AddToDGrid(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToDecimal(textBox5.Text));
            Close();
        }
    }
}
