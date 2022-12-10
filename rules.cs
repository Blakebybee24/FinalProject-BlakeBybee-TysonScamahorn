namespace finalproject;
class rules{
public void rule(){
    Console.WriteLine("HELLO THERE!!!");
Console.WriteLine("DO YOU KNOW HOW TO PLAY TEXAS HOLD'EM? yes or no");
bool user=true;
if (user == true)
{
string answer = (Console.ReadLine ());
 if (answer== "yes")
    {
        Console.WriteLine ("GET ONTO THE GAME AND DON'T LOSE ALL YOUR MONEY ;)");
    }

 if (answer == "no")
 {
    Console.WriteLine ("In our game of poker we made it so that you are playing agaist the computer");
    Console.WriteLine ("You will get 5 cards and have the decision whether you want to fold or raise");
    Console.WriteLine ("The poker hand ranking system will help you make your decision");
    Console.WriteLine("If you choose that you hand is not good and you want to fold it takes away 25 $ from your chips");
    Console.WriteLine();
    Console.WriteLine("If you want to raise type raise and it will ask you how much you wanna raise");
    Console.WriteLine("");
    Console.WriteLine("After you make your bet it will show you the computers hand and see if you won or lost the hand");
    Console.WriteLine("If you win then you get the same amount of points that you raised added into your chips");
    Console.WriteLine("If you lise then you get the same amount of points that you raised subtracted from your chips");
    Console.WriteLine("");
    Console.WriteLine("If you lose all your money it will give you 100 chips to play with");
    Console.WriteLine("The point of the game is to get the most money possible");
    Console.WriteLine("");
   
    Console.WriteLine("Do you know the Poker Hand Ranking System ");
    string answer2 = (Console.ReadLine ());
    if (answer2== "yes")
    {
        Console.WriteLine ("GET ONTO THE GAME AND DON'T LOSE ALL YOUR MONEY ;)");
    }
    if (answer2 == "no")
 {
    Console.WriteLine("These are in order from best to worst hands");
    Console.WriteLine("");
    Console.WriteLine("Royal Flush - Ace, King, Queen, Jack, 10 of all the same suit");
    Console.WriteLine("");
    Console.WriteLine("Straight Flush- Any straight that is the same suit");
    Console.WriteLine("");
    Console.WriteLine("Four of a Kind - Any 4 cards with the same number (four 7's or four 9's) ");
    Console.WriteLine("");
    Console.WriteLine("Full House - 3 of a kind, and pair - example (three 4's and two jacks");
    Console.WriteLine("");
    Console.WriteLine("Flush- 5 cards of the same suit");
    Console.WriteLine("");
    Console.WriteLine("Straight- 5 cards in a row");
    Console.WriteLine("");
    Console.WriteLine("Three of a kind- 3 cards of the same number");
    Console.WriteLine("");
    Console.WriteLine("Two Pair- two pairs of the same number");
    Console.WriteLine("");
    Console.WriteLine("Pair- 2 cards that are the same");
    Console.WriteLine("");
    Console.WriteLine("High card- the highest card");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.ReadKey();
}
}
}

}
}
