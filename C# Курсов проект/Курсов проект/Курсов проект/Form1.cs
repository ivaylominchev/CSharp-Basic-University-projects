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

        private void button3_Click(object sender, EventArgs e)
        {
            cards.Clear();
            for (int i = 0; i < DGrid.RowCount - 1; i++)
            {
                Card cr = new Card();
                cr.CardNumber = Convert.ToInt32(DGrid[0, i].Value.ToString());
                cr.CardType = DGrid[1, i].Value.ToString();
                cr.Date = DGrid[2, i].Value.ToString();
                cr.Currency = DGrid[3, i].Value.ToString();
                cr.Balance = Convert.ToDecimal(DGrid[4, i].Value.ToString());
                cards.Add(cr);
            }
            fs = new FileStream(fileName, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            for (int i = 0; i < cards.Count; i++)
            {
                bw.Write(cards[i].CardNumber);
                bw.Write(cards[i].CardType);
                bw.Write(cards[i].Date);
                bw.Write(cards[i].Currency);
                bw.Write(cards[i].Balance);
            }
            fs.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Изход от приложението!");
            Application.Exit();
        }
    }
}
