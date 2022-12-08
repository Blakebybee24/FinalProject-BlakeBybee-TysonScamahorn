/*namespace finalproject;
class bidding{
int user =2500;
int thecomp = 2500;
int bet;
public int bid(int bet){
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
            return oldbet;
        }
        if(bet > user){

        }
    }
    if(action == "FOLD"){
        return oldbet;
        keepgoing = false;
    }
    if(action == "CHECK"){
        return oldbet;
        keepgoing = false;
    }
    
    else{
        Console.WriteLine("Try again");
    }
    
    }
}

}*/