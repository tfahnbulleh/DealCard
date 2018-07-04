using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeal
{
    class Deck
    {
        private List<Card> DeckOfCard; //store deck of card

        //faces of card
        private String[] Faces={"Ace","Jack","Queen","King","2","3","4","5","6","7","8","9","10"};

        //suite of card
        private String[] Suites={"Spade","Heart","Club","Diamond"};

        public Deck()
        {
        
            this.DeckOfCard= new List<Card>(); 
           
            //fill the deck with 52 cards
            //iterate through each suite
            //iterate through each face
            //for each face, create a suite
            foreach(String suite in this.Suites)
            {
                
                foreach (String face in this.Faces)
                {
                    Card card = new Card(face, suite);
                    this.DeckOfCard.Add(card);
                }
            }
            
            Shuffle(); //method call to shuffle the cards
        }



        //deal the card
        //take a card fro mthe deck of cards
        //remove the card from the deck of card
        //return the card
        public Card GetDeal()
        {
            Card card = this.DeckOfCard.First();
            this.DeckOfCard.RemoveAt(0);
            return card;
        }


        //method to randomly shuffle the card
        private void Shuffle()
        {
            int totalCards = this.DeckOfCard.Count;
            for (int i = 0; i < totalCards; i++)
            {
                Random ran = new Random();
                int randNumber = ran.Next(this.DeckOfCard.Count);
                Card tempCard1;
                Card tempCard2;
                tempCard1 = this.DeckOfCard.ElementAt(i);
                tempCard2 = this.DeckOfCard.ElementAt(randNumber);
                this.DeckOfCard.Insert(i,tempCard2);
                this.DeckOfCard.Insert(randNumber, tempCard1);
            }
        }

       

    }
}
