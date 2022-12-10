using finalproject;

Console.SetWindowSize(90,45);
Console.BufferWidth=90;
Console.BufferHeight = 45;
Console.Title = "Poker Game";
DealCards dc= new DealCards();
rules display = new rules();
display.rule();
bool quit = false;
while(!quit)
{
    Console.BackgroundColor = ConsoleColor.DarkCyan;
    dc.Deal();
    Console.ReadKey();
    Console.Clear();
    string selection = " ";
    while(!selection.Equals('Y')&& !selection.Equals('N'))
    {   
        Console.WriteLine("Do you want to play agian? Y/N");
        selection = Convert.ToString(Console.ReadLine().ToUpper());
        if( selection.Equals("Y")){
            quit = false;
            break;
        }
        else if (selection.Equals("N"))
        {
            quit = true;
            break;
        }
        else if(selection !=""){
            Console.WriteLine("Invalid selection. Try again");
            continue;
        }
        else{
        Console.WriteLine("Invalid selection. Try again");
        }
    }
}




