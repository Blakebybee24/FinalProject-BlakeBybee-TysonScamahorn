using System.Text;
namespace finalproject
{
    class DrawCards {
      
         public static void DrawCardSuitValue(Card card, int xcoor, int ycoor){
            
          
              Console.ForegroundColor = ConsoleColor.White;
            int x = xcoor *12;
            int y = ycoor;
            Console.SetCursorPosition(x,y);
            Console.Write(" __________\n");
            for (int i = 0; i < 10; i++){
                Console.SetCursorPosition(x,y+1+i);

                if(i <5){
                Console.WriteLine("|          |");
                }
                if(i == 5){
                    switch(card.mySuit){
                case Card.Suit.Hearts :
                 Console.Write("|  ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Hearts");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("  |");
                break;
                
            

             case Card.Suit.Diamonds :
                Console.Write("| ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Diamonds");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" |");
                break;

             case Card.Suit.Clubs :
                Console.Write("|   ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("Clubs");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("  |");
                break;

            case Card.Suit.Spades :
                Console.Write("|  ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("Spades");
                Console.ForegroundColor = ConsoleColor.White;
                 Console.WriteLine("  |");
                break;
            }
            
                }
            if(i>5&&i<9){
                Console.WriteLine("|          |");}
                if(i == 9) {
                    Console.WriteLine("|__________|");
                }                    
            }
          
            Console.SetCursorPosition(x+5,y+5);
           
            Console.SetCursorPosition(x+4, y+7);
            Console.Write(card.myValue);
            }
        }

    }