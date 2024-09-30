using System;

class Program{
static void Main(string[] args){
    GetMenuOption();
}

static void GetMenuOption() {
    int crust = 9;
    Random random = new Random();

    while(true){
        Console.WriteLine ("Welcome to Crimson Crust! ");
        Console.WriteLine ();
        Console.WriteLine ("Menu: Make selection by entering a number 1-4");
        Console.WriteLine ("1: no toppings");
        Console.WriteLine ("2: cheese");
        Console.WriteLine ("3: pepperoni");
        Console.WriteLine ("4: EXIT");
       
    if(int.TryParse(Console.ReadLine(), out int menuOption)){

         switch (menuOption){
            case 1:

                        for (int i = crust; i >= 1; i--) 
                        {
                            Console.WriteLine("");
                            for (int j = 1; j <= i; j++) 
                            {
                                Console.Write("*    ");  
                            }                           
                            Console.WriteLine();   
                        }                      
                        break; 


            case 2:
                    
                        for (int i = crust; i >= 1; i--)
                        {
                            Console.WriteLine("");
                            for(int j = 1; j <= i; j++)
                            {
                                if(i == crust){
                                    Console.Write("*    ");
                                }
                                else{
                                if(j == 1 || j == i){
                            
                                    Console.Write("*    ");
                                }
                                else{
                                    Console.Write("#    ");
                                }
                                }
                            }
                            Console.WriteLine();
                        }
                        break;
                

            case 3:
                        for (int i = crust; i >= 1; i--)
                        {
                            Console.WriteLine("");
                            for(int j = 1; j <= i; j++)
                            {
                                if(i == crust){
                                    Console.Write("*    ");
                                }
                                else{
                                if(j == 1 || j == i){
                            
                                    Console.Write("*    ");
                                }
                                else{
                                        if (random.Next(4) == 0){
                                            Console.Write("[]    ");
                                        }
                                        else{
                                            Console.Write("#    ");
                                        }
                                    
                                }
                                }
                            }
                            Console.WriteLine();
                        }
                        break;


            case 4: 
            Console.WriteLine("Exit");
                return;
            default: 
            Console.WriteLine ("Error: please make menu option (1-4)");
                break;
         }
    }
    else{
        Console.WriteLine("Invalid. Please enter a number between 1 and 4.");
        Console.WriteLine ();
    }
    }
}
}