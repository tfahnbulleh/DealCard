using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeal
{
    class CardPlayer
    {

        private List<Card> DealtCards; //store cards that have been deal from aa deck of card


        //constructor
        public CardPlayer()
        {
            this.DealtCards = new List<Card>();
        }


        //constructor
        public CardPlayer(Card[] cards)
        {
            this.DealtCards.AddRange(cards);
        }


        //methood to add card to the deal card list
        //this method should be call when dealing a card from the deck
        public void AddCard(Card card)
        {
            this.DealtCards.Add(card);
        }

       
        public void AddCard(IEnumerable<Card> cards)
        {
            this.DealtCards.AddRange(cards);
        }

        public IEnumerable<Card> showCards()
        {
            return this.DealtCards.AsEnumerable();
        }

        public void Clear()
        {
            this.DealtCards.Clear();
        }
    }
}
