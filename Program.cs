using finalproject;

Console.SetWindowSize(90,45);
Console.BufferWidth=90;
Console.BufferHeight = 45;
Console.Title = "Poker Game";
DealCards dc= new DealCards();

bool quit = false;
while(!quit)
{
    Console.BackgroundColor = ConsoleColor.DarkMagenta;
    dc.Deal();
    Console.ReadKey();
    Console.Clear();
    char selection = ' ';
    while(!selection.Equals('Y')&& !selection.Equals('N'))
    {
        Console.WriteLine("Do you want to play agian? Y/N");
        selection = Convert.ToChar(Console.ReadLine().ToUpper());
        if( selection.Equals('Y')){
            quit = false;
        }
        else if (selection.Equals('N'))
        {
            quit = true;

        }
        else
        Console.WriteLine("Invalid selection. Try again");
    }
}

Console.ReadKey();

