using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject {
   public enum Hand{
    Nothing,
    OnePair,
    TwoPair,
    ThreeKind,
    Straight,
    Flush,
    FullHouse,
    FourKind

   }
   public struct HandValue {
    public int Total {get; set;}
    public int HighCard {get; set;}
   }
    class HandEvaluator:Card {
        private int heartsSum;
        private int diamondSum;
        private int clubSum;
        private int spadesSum;
        private Card[] cards;
        private HandValue  handValue;

        public HandEvaluator(Card[]sortedHand){
            heartsSum = 0;
            diamondSum= 0;
            clubSum = 0;
            spadesSum = 0;
            cards = new Card[5];
            Cards = sortedHand;
            handValue = new HandValue();
        }
        public HandValue HandValues{
            get {return handValue;}
            set {handValue = value;}
        }
        public Card[]Cards {
            get {return cards;}
            set {
                cards[0] = value[0];
                cards[1] = value[1];
                cards[2] = value[2];
                cards[3] = value[3];
                cards[4] = value[4];
                
            }
        }
        public Hand EvaluateHand(){
            getNumberOfSuit();
            if(FourOfKind()){
            return Hand.FourKind;
            }
            else if (FullHouse()){
                return Hand.FullHouse;
            }
            else if (Flush ()){
                return Hand.Flush;
            
            }
            else if (Straight()){
                return Hand.Straight;
            }
            else if (ThreeOfKind()){
                return Hand.ThreeKind;
            
            }
            else if(TwoPair()){
                return Hand.TwoPair;
            
            }
            else if (OnePair()){
                return Hand.OnePair;
               

            }
             handValue.HighCard= (int)cards[4].myValue;
             return Hand.Nothing;
        }
        private void getNumberOfSuit(){
            foreach(var element in Cards){
                if (element.mySuit == Card.Suit.Hearts){
                    heartsSum++;
        
                }
                else if (element.mySuit == Card.Suit.Diamonds){
                    diamondSum++;
                }
                else if (element.mySuit == Card.Suit.Clubs){
                    clubSum++;
                }
                else if (element.mySuit == Card.Suit.Spades){
                    spadesSum++;
                }
            }
            
        }
        private bool FourOfKind(){
            if(cards[0].myValue == cards[1].myValue && cards[0].myValue == cards[2].myValue && cards[0].myValue == cards[3].myValue){
                handValue.Total = (int) cards[1].myValue * 4;
                handValue.HighCard = (int)cards[4].myValue;
                return true;
            }
            else if (cards[1].myValue == cards[2].myValue && cards [1].myValue == cards [3].myValue && cards[1].myValue == cards[4].myValue){
                handValue.Total = (int)cards[1].myValue* 4;
                handValue.HighCard = (int)cards[0].myValue;
                return true; 
            }
            return false; 
        }
        private bool FullHouse(){
            if ((cards[0].myValue == cards[1].myValue && cards[0].myValue == cards[2].myValue && cards[3].myValue == cards[4].myValue ) ||
                (cards[0].myValue == cards[1].myValue && cards[2].myValue == cards[3].myValue && cards[2].myValue == cards[4].myValue)) {
                    handValue.Total = (int)(cards[0].myValue)+ (int)(cards[1].myValue)+ (int)(cards[2].myValue)+ (int)(cards[3].myValue)+ 
                    (int)(cards[4].myValue);
                    return true;
                }
                return false;
        }
        private bool Flush(){
            if(heartsSum == 5 || diamondSum == 5 || clubSum == 5 || spadesSum == 5){
                handValue.Total = (int)cards[4].myValue;
                return true;
            }
            return false;
        }
        private bool Straight(){
            if(cards[0].myValue + 1 == cards[1].myValue &&
            cards[1].myValue+1 == cards [2].myValue &&
            cards[2].myValue+1 == cards[3].myValue &&
            cards[3].myValue+1 == cards[4].myValue) {
                handValue.Total = (int)cards[4].myValue;
                return true;

            }
            return false;
        }
        private bool ThreeOfKind(){
            if ((cards[0].myValue == cards[1].myValue && cards[0].myValue == cards [2].myValue) ||
            (cards[1].myValue == cards[2].myValue && cards[1].myValue == cards[3].myValue)) {
                handValue.Total = (int)cards [2].myValue *3;
                handValue.HighCard = (int)cards[4].myValue;
            return true ;
            }
            else if (cards[2].myValue == cards[3].myValue && cards[2].myValue == cards[4].myValue ){
                handValue.Total = (int)cards[2].myValue *3;
                handValue.HighCard = (int)cards[1].myValue;
                return true;
            }
            return false;
        }
        private bool TwoPair(){
            if(cards[0].myValue == cards[1].myValue && cards[2].myValue == cards[3].myValue){
                handValue.Total = ((int)cards[1].myValue*2)+ ((int)cards[3].myValue *2);
                handValue.HighCard = (int)cards[4].myValue;
                return true;
            }
              else if(cards[0].myValue == cards[1].myValue && cards[3].myValue == cards[4].myValue){
                handValue.Total = ((int)cards[1].myValue*2)+ ((int)cards[3].myValue *2);
                handValue.HighCard = (int)cards[2].myValue;
                return true;
        }
         else if(cards[1].myValue == cards[2].myValue && cards[3].myValue == cards[4].myValue){
                handValue.Total = ((int)cards[1].myValue*2)+ ((int)cards[3].myValue *2);
                handValue.HighCard = (int)cards[0].myValue;
                return true;
         }
         return false;
        
        
    }
    private bool OnePair(){
        if (cards[0].myValue == cards[1].myValue){
            handValue.Total = (int) cards[0].myValue*2;
            handValue.HighCard = (int)cards[4].myValue;
            return true;
        }
        if (cards[1].myValue == cards[2].myValue){
            handValue.Total = (int) cards[1].myValue*2;
            handValue.HighCard = (int)cards[4].myValue;
            return true;
        }
        if (cards[2].myValue == cards[3].myValue){
            handValue.Total = (int) cards[2].myValue*2;
            handValue.HighCard = (int)cards[4].myValue;
            return true;
        }
        if (cards[3].myValue == cards[4].myValue){
            handValue.Total = (int) cards[3].myValue*2;
            handValue.HighCard = (int)cards[2].myValue;
            return true;
        }
        return false; 
    }
}
}