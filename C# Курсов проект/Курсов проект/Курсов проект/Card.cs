using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсов_проект
{
    public class Card
    {
        public int CardNumber { get; set; }
        public string CardType { get; set; }
        public string Date { get; set; }
        public string Currency { get; set; }
        public decimal Balance { get; set; }

       /* public Card(int cardNumber, string cardType, string date, string currency, decimal balance)
        {
            CardNumber = cardNumber;
            CardType = cardType;
            Date = date;
            Currency = currency;
            Balance = balance;
        }*/

    }
}
