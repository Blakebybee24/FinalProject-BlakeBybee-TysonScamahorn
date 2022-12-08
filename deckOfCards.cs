namespace finalproject{
class DeckOfCards : Card{
    const int num_of_cards = 52;

    private Card[]deck;
    public DeckOfCards(){
    deck = new Card[num_of_cards];
    }
    public Card[] getDeck{get{return deck;}}
    // create deck of 52 cards:
    public void setUpDeck(){
        int i = 0;
        foreach(Suit s in Enum.GetValues(typeof(Suit))){
            foreach(Value v in Enum.GetValues(typeof(Value)) ){
                deck[i] = new Card{mySuit=s, myValue = v};
                i++;
            }
        }

    }
    
    public void shuffleCards(){
        Random rand = new Random();
        Card temp;
        int r = 0;
        r = rand.Next(1,30000);
        for (int shuffleTimes = 0; shuffleTimes<r;shuffleTimes++){
            for(int i =0; i < num_of_cards;i++){
                // Swap the cards
                int secondCardIndex = rand.Next(13);
                temp = deck[i];
                deck[i] = deck[secondCardIndex];
                deck[secondCardIndex]= temp;
                
            }
        }

        

    }
}
}