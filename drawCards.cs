using System.Text;
namespace finalproject
{
    class DrawCards {
       /* public static void DrawCardOutline (int xcoor, int ycoor){
           Console.ForegroundColor = ConsoleColor.White;
            int x = xcoor *12;
            int y = ycoor;
            Console.SetCursorPosition(x,y);
            Console.Write(" __________\n");
            for (int i = 0; i < 10; i++){
                Console.SetCursorPosition(x,y+1+i);

                if(i !=9){
                Console.WriteLine("|          |");
                }
                if(i == 5){
                   
                }
                else {
                    Console.WriteLine("|__________|");
                }
            }
        }*/
         public static void DrawCardSuitValue(Card card, int xcoor, int ycoor){
            
          //  int x = xcoor *12;
          //  int y = ycoor;
              Console.ForegroundColor = ConsoleColor.White;
            int x = xcoor *12;
            int y = ycoor;
            Console.SetCursorPosition(x,y);
            Console.Write(" __________\n");
            for (int i = 0; i < 10; i++){
                Console.SetCursorPosition(x,y+1+i);

                if(i !=5){
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
                Console.Write("| Diamonds |");
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
                Console.WriteLine("Spades");
                Console.ForegroundColor = ConsoleColor.White;
                 Console.WriteLine("  |");
                break;
            }
            if(i !=9){
                Console.WriteLine("|          |");
                }
                   
                }
                else {
                    Console.WriteLine("|__________|");
                }                    
            }
           /* switch(card.mySuit){
                case Card.Suit.Hearts :
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Hearts");
                break;
                
            

             case Card.Suit.Diamonds :
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Diamonds");
                break;

             case Card.Suit.Clubs :
                
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("Clubs");
                break;

            case Card.Suit.Spades :
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("Spades");
                break;
            }  */ 
            Console.SetCursorPosition(x+5,y+5);
           
            Console.SetCursorPosition(x+4, y+7);
            Console.Write(card.myValue);
            }
        }

    }