using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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

        private void Намери_Click(object sender, EventArgs e)
        {
            DGrid.Rows.Clear();
            for (int i = 0; i < gl.cards.Count; i++)
            {
                if (textBox1.Text.ToLower() == gl.cards[i].CardType.ToLower() && gl.cards[i].Balance > 0)
                {
                    DGrid.Rows.Add(gl.cards[i].CardNumber, gl.cards[i].CardType, gl.cards[i].Balance);
                    DGrid.Show();
                }
            }
            textBox1.Clear();
        }

        private void DisplayAverageBalances(Dictionary<string, decimal> averageBalance)
        {
            LB1.Items.Clear();
            foreach (var item in averageBalance)
            {
                LB1.Items.Add($"Вид карта: {item.Key}: {item.Value:F2} (средно салдо)");
            }
        }
        private Dictionary<string, decimal> CalculateAverageBalance(List<Card> cards)
        {
            Dictionary<string, decimal> averageBalances = new Dictionary<string, decimal>();

            foreach (var card in cards)
            {
                string cardType = card.CardType.ToLower();
                if (!averageBalances.ContainsKey(cardType))
                {
                    averageBalances[cardType] = 0;
                }

                averageBalances[cardType] += card.Balance;
            }

            foreach (var cardType in averageBalances.Keys.ToList())
            {
                int cardCount = cards.Count(card => card.CardType.ToLower() == cardType);
                decimal averageBalance = averageBalances[cardType] / cardCount;
                averageBalances[cardType] = averageBalance;
            }

            return averageBalances;
        }

        private void BT1_Click(object sender, EventArgs e)
        {
            var averageBalances = CalculateAverageBalance(gl.cards);

            DisplayAverageBalances(averageBalances);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
