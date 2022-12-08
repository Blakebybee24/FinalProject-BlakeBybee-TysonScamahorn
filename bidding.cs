namespace finalproject;
class bidding{
int user =2500;
int thecomp = 2500;
public void bid(int user, int thecomp){
    bool keepgoing = true;
    while(keepgoing ==true){
    string action="";
        int bet = 0;
    Console.WriteLine("please chose to raise, fold or check."); 
   action = Convert.ToString(Console.ReadLine().ToUpper());
    if(action == "RAISE"){
        Console.WriteLine($"You have {user} left");
        Console.WriteLine($"please chose how much you want to bid?");
         bet = Convert.ToInt32(Console.ReadLine());
        if(bet < user){}
        if(bet > user){}
    }
    if(action == "FOLD"){}
    if(action == "CHECK"){}
    
    else{
        Console.WriteLine("Try again");
    }
    
    }
}

}