# DealCard

DEALING CARDS:

Write a class named Card, which can be used to represent a card from a deck of cards. 
The class should be able to store a card's suit and face value. A card's suit can be one of the following:
Hearts, Diamonds, Spades or Clubs. A card's face value can be Ace, Jack, Queen, King, or a value in the range of two through ten.

Next write a Deck class. This class constructor should create a list of 52 Card objects, 
each representing a valid card in a deck of cards. The class should have a shuffle method that 
randomly shuffles the Card objects in the list. It should also have a deal method "deals" a card from the deck. 
It does this by removing the Card object at the beginning of the list and returning a reference to that object.

Next, write CardPlayer class. This class should keep a list of Card objects that have been dealt to it. 
This represents a hand of cards. A method named getCard should accept a reference to the Card object, 
which is added to the list. A method named showCards displays the Card objects in the list.

Demonstrate these classes in an application that creates a Deck object, shuffles the cards it contains, 
and deals five cards from the Deck to a CardPlayer object. The CardPlayer should then display its cards.

