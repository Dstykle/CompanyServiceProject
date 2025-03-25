using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CarrolsRG
{
    internal string name = "None";
    internal string slogan = "None";
    
    
bool isRestaurant = true;
        bool isChickenBased = true;
        bool isBurgerBased = true;
        bool isCarrolsRG = true;
    
    public virtual void RG()
    {
        if (isRestaurant && isChickenBased & isCarrolsRG)
        {
            Console.WriteLine($"Hello! Welcome to {name}.{Environment.NewLine}{slogan}{Environment.NewLine}This is a chicken based restaurant.{Environment.NewLine}Also owned by the Carrols Restaurant Group.");
        }
        else if (isRestaurant && isCarrolsRG && isBurgerBased)
        {
            Console.WriteLine($"Hello! Welcome to {name}.{Environment.NewLine}{slogan}{Environment.NewLine}This is a burger based restaurant.{Environment.NewLine}Also owned by the Carrols Restaurant Group.");
        }

    }

}

    public class BK : CarrolsRG
    {
    internal string name = "Burger King";
    internal string slogan = "Have it your way";
    protected bool isRestaurant = true;
    protected bool isChickenBased = false;
    protected bool isCarrolsRG = true;
    protected bool isBurgerBased = true;

        public override void RG()
        {
        
        if (isRestaurant && isChickenBased & isCarrolsRG)
        {
            Console.WriteLine($"Hello! Welcome to {name}.{Environment.NewLine}{slogan}{Environment.NewLine}This is a chicken based restaurant.{Environment.NewLine}Also owned by the Carrols Restaurant Group.");
        }
        else if (isRestaurant && isCarrolsRG && isBurgerBased)
        {
            Console.WriteLine($"Hello! Welcome to {name}.{Environment.NewLine}{slogan}{Environment.NewLine}This is a burger based restaurant.{Environment.NewLine}Also owned by the Carrols Restaurant Group.");
        }
    }
    public string menuItems(int num1)
    {
        
        //Console.Write($"meal    sandwich only{Environment.NewLine}Whopper	$6.99	$4.29{ Environment.NewLine } Texas Double Whopper	$8.89	$8.19 {Environment.NewLine}Impossible Whopper	$7.59	$5.490{ Environment.NewLine} Bacon King	$8.99   $6.99{ Environment.NewLine} Double Stacker King  $8.99   $6.99{ Environment.NewLine} Bacon & Cheese Whopper   $7.99   $5.49{ Environment.NewLine} Whopper Jr. $5.49	$2.29{ Environment.NewLine} Original Chicken Sandwich	$6.69	$4.49{ Environment.NewLine } Crispy Chicken    $6.99	$4.99{ Environment.NewLine}Spicy Crispy Chicken	$6.99	$4.99{ Environment.NewLine}BBQ Bacon Crispy Chicken Sandwich	$8.09	$6.09{ Environment.NewLine}Bacon & Cheese Crispy Chicken	$8.09	$6.09{ Environment.NewLine}Chicken Fries    $5.59	$3.29{ Environment.NewLine}Big Fish Sandwich	$6.49	$4.29");
        string[] items = { "Whopper", "Texas Double Whopper","Impossible Whopper", "Bacon King", "Double Stacker King", "Bacon & Cheese Whopper", "Whopper Jr.", "Original Chicken Sandwich","Crispy Chicken Sandwich", "Spicy Crispy Chicken Sandwich", "BBQ Bacon Crispy Chicken Sandwich","Bacon & Cheese Crispy Chicken","Chicken Fries", "Big Fish Sandwich"};

        double[] price = { 6.99,8.89,7.59,8.99,8.99,7.99,5.49,6.69,6.99,6.99,8.09,8.09,5.59,6.49 };
        while (true)
        {
            try
            {
                return items[num1] + " for " + price[num1];

            }
            catch (Exception)
            {
                
                Console.WriteLine("Incorrect number item, Type in a valid number. ");
                num1 = int.Parse(Console.ReadLine());
                
                return menuItems(num1);


            }
        }
    }
    public double menuprice(int num1)
    {
        double[] price = { 6.99, 8.89, 7.59, 8.99, 8.99, 7.99, 5.49, 6.69, 6.99, 6.99, 8.09, 8.09, 5.59, 6.49 };
        try
        {
            return price[num1];

        }
        catch (Exception)
        {

            return 0;




        }
    }
}




/*
{ Environment.NewLine} Bacon King	$8.99   $6.99{ Environment.NewLine} Double Stacker King  $8.99   $6.99{ Environment.NewLine} Bacon & Cheese Whopper   $7.99   $5.49{ Environment.NewLine} Whopper Jr. $5.49	$2.29{ Environment.NewLine} Original Chicken Sandwich	$6.69	$4.49{ Environment.NewLine } Crispy Chicken    $6.99	$4.99{ Environment.NewLine}Spicy Crispy Chicken	$6.99	$4.99{ Environment.NewLine}BBQ Bacon Crispy Chicken Sandwich	$8.09	$6.09{ Environment.NewLine}Bacon & Cheese Crispy Chicken	$8.09	$6.09{ Environment.NewLine}Chicken Fries    $5.59	$3.29{ Environment.NewLine}"Big Fish Sandwich	$6.49	$4.29");
*/

class Popeyes : CarrolsRG
{
    internal string name = "Popeyes";
    internal string slogan = "Love that chicken from Popeyes.";
    protected bool isRestaurant = true;
    protected bool isChickenBased = true;
    protected bool isCarrolsRG = true;
    protected bool isBurgerBased = false;

    public override void RG()
    {

        if (isRestaurant && isChickenBased & isCarrolsRG)
        {
            Console.WriteLine($"Hello! Welcome to {name}.{Environment.NewLine}{slogan}{Environment.NewLine}This is a chicken based restaurant.{Environment.NewLine}Also owned by the Carrols Restaurant Group.");
        }
        else if (isRestaurant && isCarrolsRG && isBurgerBased)
        {
            Console.WriteLine($"Hello! Welcome to {name}.{Environment.NewLine}{slogan}{Environment.NewLine}This is a burger based restaurant.{Environment.NewLine}Also owned by the Carrols Restaurant Group.");
        }
    }

    public string menuItems(int num1)
    {


        string[] items = { "eight_piece_chicken_only", "eight_piece_with_1_large_side_and_4_Biscuits", "twelve_piece_chicken_only", "twelve_piece_with_2_large_side_and_6_Biscuits", "sixteen_piece_chicken_only", "sixteen_piece_with_3_large_side_and_8_Biscuits" };

        double[] price = { 18.99, 12.99, 17.99, 25.99, 23.99, 33.99 };
        while(true){
            try
            {
                return items[num1]+" for " +price[num1];

            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect number item, Type in a valid number. ");
                num1 = int.Parse(Console.ReadLine());


            }
        }
    }
    public double menuprice(int num1)
    {
        double[] price = { 18.99, 12.99, 17.99, 25.99, 23.99, 33.99 };
        try
        {
            return price[num1];

        }
        catch (Exception)
        {
            return 0;
            


        }
    }
}
