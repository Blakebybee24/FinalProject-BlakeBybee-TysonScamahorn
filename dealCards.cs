using System.Text;

namespace finalproject
{
    class DealCards: DeckOfCards
    {
        private Card[] playerHand;
         private Card[] computerHand;
         private Card[] sortedPlayerHand;
         private Card[] sortedComputerHand;

         public DealCards()
         {
            playerHand = new Card[5];
           computerHand = new Card[5];
            sortedPlayerHand = new Card[5];
           sortedComputerHand = new Card[5];

         }
         public void Deal()
         {
            setUpDeck();
            shuffleCards();
            getplayerHand();
            sortCards();
            displayCards();
           bid();
           Console.ReadKey();
            diplaycomputercards();
            evaluateHands();
         }
    public void getplayerHand()
    {
        for(int i =0;i<5;i++)
        {
            playerHand[i]= getDeck[i];

        }

        for(int i =5;i<10;i++)
        {
            computerHand[i-5]= getDeck[i];

            }

    }
     
        
    public void sortCards()
    {
        var queryPlayer = from hand in playerHand orderby hand.myValue select hand;

        var queryComputer = from hand in computerHand orderby hand.myValue select hand;
        var index= 0;
        foreach(var element in queryPlayer.ToList())
        {
            sortedPlayerHand[index]= element;
            index++;
        }
        index =0;
        foreach(var element in queryComputer.ToList())
        {
            sortedComputerHand[index]= element;
            index++;
        }
    }    
    public void displayCards()
    {
        Console.Clear();
        int x =0;
        int y = 1;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Player's Hand");
        for (int i = 0; i<5; i++)
        {
            //DrawCards.DrawCardOutline(x,y);
            DrawCards.DrawCardSuitValue(sortedPlayerHand[i],x,y);
            x++;

    }
        }
        public void diplaycomputercards(){
        int y = 15;
        int x=0;
        Console.SetCursorPosition(x,14);
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Computer's Hand");
        for(int i =5; i<10; i++)
        {
            //DrawCards.DrawCardOutline(x,y);
            DrawCards.DrawCardSuitValue(sortedComputerHand[i-5],x,y);
            x++;
        }}
     
public void evaluateHands()
    {
        HandEvaluator playerHandEvaluator = new HandEvaluator(sortedPlayerHand);
        HandEvaluator computerHandEvaluator = new HandEvaluator(sortedComputerHand);

        Hand playerHand = playerHandEvaluator.EvaluateHand();
        Hand computerHand= computerHandEvaluator.EvaluateHand();
        Console.WriteLine ("\n\n\n\n\nPlayer's Hand: " + playerHand);
        Console.WriteLine("\nCOmputer's Hand: " + computerHand);

        if (playerHand > computerHand ){
            Console.WriteLine("Player WINS!");
            //Console.WriteLine($"you won {oldbet}");
        }
        else if (playerHand<computerHand){
            Console.WriteLine("Computer WINS!");

        }
        else {
            if(playerHandEvaluator.HandValues.Total > computerHandEvaluator.HandValues.Total){
                Console.WriteLine("Player WINS!");
            }
            else if (playerHandEvaluator.HandValues.Total< computerHandEvaluator.HandValues.Total){
                Console.WriteLine("Computer WINS!");

            }
        else if (playerHandEvaluator.HandValues.HighCard> computerHandEvaluator.HandValues.HighCard){
            Console.WriteLine("Player WINS!");

        }
        else if (playerHandEvaluator.HandValues.HighCard < computerHandEvaluator.HandValues.HighCard){
            Console.WriteLine("Computer WINS!");

        }
        else {
            Console.WriteLine("Draw, no one wins!");
        }
        }
    }
    public void bid(){
        int user =2500;
        int thecomp = 2500;
       int bet;
    bool keepgoing = true;
    int oldbet = 0;
    while(keepgoing ==true){
    string action="";
    Console.WriteLine("please chose to raise, fold or check."); 
   action = Convert.ToString(Console.ReadLine().ToUpper());
    if(action == "RAISE"){
        Console.WriteLine($"You have {user} left");
        Console.WriteLine($"please chose how much you want to bid?");
         bet = Convert.ToInt32(Console.ReadLine());
        if(bet < user){
           oldbet = bet +oldbet;
           Console.WriteLine($"the current bet is {oldbet}");
            
        }
        else if(bet > user){

        }
    }
    else if(action == "FOLD"){
        
        keepgoing = false;
    }
    else if(action == "CHECK"){
        
        keepgoing = false;
    }
    
    else{
        Console.WriteLine("Try again");
    }
    
    }
}
    }
}