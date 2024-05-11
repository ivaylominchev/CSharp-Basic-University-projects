using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсов_проект
{
    public partial class Form1 : Form
    {
        public List<Card> cards = new List<Card>();
        FileStream fs;
        string fileName = "Cards.txt";
        public Form1()
        {
            InitializeComponent();
            fs = new FileStream(fileName, FileMode.OpenOrCreate);
            BinaryReader br = new BinaryReader(fs);
            while (fs.Position < fs.Length)
            {
                Card cr = new Card();
                cr.CardNumber = br.ReadInt32();
                cr.CardType = br.ReadString();
                cr.Date = br.ReadString();
                cr.Currency = br.ReadString();
                cr.Balance = br.ReadDecimal();
                cards.Add(cr);
                DGrid.Rows.Add(cr.CardNumber, cr.CardType, cr.Date, cr.CardNumber, cr.Balance);
            }
            fs.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2(this).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form3(this).Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void AddToDGrid(int CardNumber, string CardType, string Date, string Currency, decimal Balance)
        {
            DGrid.Rows.Add(CardNumber, CardType, Date, Currency, Balance);
        }
    }
}
