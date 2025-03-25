using System;
using System.IO;
class progt : Popeyes
{
    static void Main(string[] args)
    {
        // Getting file ready for use
        string tt = @"E:\repos\CRG\ConsoleApp7\TextFile1.txt";
        // lots of variables
        var m = new Popeyes();
        int st = 0;
        string[] receipt = new string[8] { "None", "None", "None", "None", "None", "None", "None", "None" };
        double[] link = new double[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
            int lop = 0;
        string first = "None";
                string ques = "None";
                int dw = 0;
        while (true)
        {
            try
            {

                
                if (st == 0)
                {
                    //Menu and introduction will run only once
                    m.RG();
                    Console.WriteLine("Here is the menu, take your time. In case your new the maximum amount of items I can allow you to have are 8 items.");
                    for (int i = 1; i < 7; i++)
                    {
                        Console.WriteLine($"{i}. {m.menuItems(i - 1)}");
                    }
                }
                do
                {
                    if (st == 0)
                    {
                        //Will only run one time just to start things off
                        Console.WriteLine("What number would you like from the menu?");
                        first = Console.ReadLine();
                        if (first.ToUpper() == "NO")
                        {
                            break;
                        }
                        int number = int.Parse(first);
                        if (number < 7)
                        {
                            string l = m.menuItems(number - 1);
                            link[lop] = m.menuprice(number - 1);
                            receipt[dw] = l;
                            Console.WriteLine(l);
                            st++;
                            lop++;


                        }
                        else { Console.WriteLine("Sorry we do not have that number item. The menu is above if you need it."); }
                        st++;

                    }

                    // this will continue to ask the user what they want until they are done
                    Console.WriteLine("What other number you would like from the menu? (say no if you are done or if you would like to remove something.)");

                    ques = Console.ReadLine();
                    switch (ques.ToUpper())
                    {

                        case "1":
                            {
                                Console.WriteLine(m.menuItems(0));
                                Console.WriteLine("Would you like the number 1 added? ");
                                string add = Console.ReadLine();
                                if (add.ToUpper() == "YES")
                                {
                                    Console.WriteLine("Okay I will add the number 1");
                                    string adder = m.menuItems(0);
                                    link[lop] = m.menuprice(0);
                                    receipt[lop] = adder;
                                    lop++;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("I will not add it.");
                                    break;
                                }
                            }
                        case "2":
                            {

                                Console.WriteLine(m.menuItems(1));
                                Console.WriteLine("Would you like the number 2 added? ");
                                string add = Console.ReadLine();
                                if (add.ToUpper() == "YES")
                                {

                                    Console.WriteLine("Okay I will add the number 2");
                                    string adder = m.menuItems(1);
                                    receipt[lop] = adder;
                                    link[lop] = m.menuprice(1);
                                    lop++;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("I will not add it.");
                                    break;
                                }
                            }
                        case "3":
                            {
                                Console.WriteLine(m.menuItems(2));
                                Console.WriteLine("Would you like the number 3 added? ");
                                string add = Console.ReadLine();
                                if (add.ToUpper() == "YES")
                                {
                                    Console.WriteLine("Okay I will add the number 3");
                                    string adder = m.menuItems(2);
                                    receipt[lop] = adder;
                                    link[lop] = m.menuprice(2);
                                    lop++;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("I will not add it.");
                                    break;
                                }
                            }
                        case "4":
                            {
                                Console.WriteLine(m.menuItems(3));
                                Console.WriteLine("Would you like the number 4 added? ");
                                string add = Console.ReadLine();
                                if (add.ToUpper() == "YES")
                                {
                                    Console.WriteLine("Okay I will add the number 4");
                                    string adder = m.menuItems(3);
                                    receipt[lop] = adder;
                                    link[lop] = m.menuprice(3);
                                    lop++;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("I will not add it.");
                                    break;
                                }
                            }
                        case "5":
                            {
                                Console.WriteLine(m.menuItems(4));
                                Console.WriteLine("Would you like the number 5 added? ");
                                string add = Console.ReadLine();
                                if (add.ToUpper() == "YES")
                                {
                                    Console.WriteLine("Okay I will add the number 5");
                                    string adder = m.menuItems(4);
                                    receipt[lop] = adder;
                                    link[lop] = m.menuprice(4);
                                    lop++;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("I will not add it.");
                                    break;
                                }
                            }
                        case "6":
                            {
                                Console.WriteLine(m.menuItems(5));
                                Console.WriteLine("Would you like the number 6 added? ");
                                string add = Console.ReadLine();
                                if (add.ToUpper() == "YES")
                                {
                                    Console.WriteLine("Okay I will add the number 6");
                                    string adder = m.menuItems(5);
                                    receipt[lop] = adder;
                                    link[lop] = m.menuprice(5);
                                    lop++;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("I will not add it.");
                                    break;
                                }
                            }

                        case "NO":
                            {
                                Console.WriteLine("Would you like to remove anything? (yes/no)");
                                string Rem = Console.ReadLine();
                                if (Rem.ToUpper() == "YES")
                                {
                                    Console.WriteLine("Here are your items.");
                                    


                                    while (true)
                                    {
                                        try
                                        {
                                            int count = 0;
                                            foreach (string i in receipt)
                                            {
                                                if (i == "None")
                                                {
                                                    continue;
                                                }
                                                count++;
                                                Console.WriteLine($"{count}. {i}");


                                            }
                                            Console.WriteLine("What number would you like to remove?");
                                            string rem5 = Console.ReadLine();
                                            if (rem5.ToUpper() == "NEVERMIND")
                                            {
                                                
                                                break;

                                            }
                                            int rem1 = int.Parse(rem5);
                                            if (receipt[rem1 - 1] == "None")
                                            {
                                                Console.WriteLine("There is nothing to be removed in this space.");

                                            }
                                            receipt[rem1 - 1] = "None";
                                            link[rem1 - 1] = 0;
                                            Console.WriteLine("Is there anything else you would like to remove? (yes/no)");
                                            string rem2 = Console.ReadLine();
                                            if (rem2 == "yes")
                                            {
                                                var color = ConsoleColor.Red;
                                                Console.ForegroundColor = color;
                                                Console.WriteLine($"{Environment.NewLine}Type Nevermind if you don't want to remove anything anymore.{Environment.NewLine}");
                                                Console.ForegroundColor = ConsoleColor.White;

                                                continue;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        catch (Exception e)
                                        {
                                            Console.WriteLine("That is not a valid number");
                                            continue;
                                        }
                                    }
                                }
                                else if (Rem.ToUpper() == "NO") { Console.WriteLine("Okay I will not remove anything.");}


                                break;
                            }
                        default: { Console.WriteLine("I did not catch that."); break; }

                    }
                }

                while (ques.ToUpper() != "NO" || receipt.Length != 8);
                
                if (ques.ToUpper() == "NO")
                {
                    // Confirms if finished
                    Console.WriteLine("Okay are you finished?");
                    string rea = Console.ReadLine();
                    if (rea.ToUpper() == "YES")
                    {
                        break;
                    }
                    
                    else if (rea.ToUpper() == "NO")
                    {
                        continue;
                    }
                    else
                    {
                        continue;
                    }
                }
               
                else if (first.ToUpper() == "NO")
                {
                    break;
                }
                st++;
                if (st == 8) { break; }
            }


            catch (IndexOutOfRangeException ex)
            {
                
                Console.WriteLine("That is the max amount of items I can allow.");
                break;
            }
            catch (Exception e)
            {
                Console.WriteLine("Type in a valid number");
                Console.WriteLine(e.Message);
                st++;
                continue;
            }






        }
        Console.WriteLine("Okay so you got:");
        int rs = 1;
        // All text will go into File
        // If not working correctly right-click TextFile.txt and press "Copy Full Path" and paste into string on line 7 if not working.
        using (StreamWriter sr = File.AppendText(tt)) { sr.WriteLine("Your receipt"); }
        foreach (string i in receipt)
        {
            if (i == "None")
            {
                continue;
            }
            Console.WriteLine($"{rs}.{i}");
            // All text will go into File
            // If not working correctly right-click TextFile.txt and press "Copy Full Path" and paste into string on line 7 if not working.
            using (StreamWriter sr = File.AppendText(tt)) { sr.WriteLine($"{Environment.NewLine}{rs}.{i}"); }
            rs = rs + 1;

        }

        double total = 0;
        for (int h = 0; h != 8; h = h + 1)
        {
            // subtotal of every item they chose
            total = total + link[h];


        }
        // All text will go into File
        // If not working correctly right-click TextFile1.txt and press "Copy Full Path" and paste into string on line 7 if not working.
        using (StreamWriter sr = File.AppendText(tt)) { sr.WriteLine($"{Environment.NewLine}SubTotal: {total}{Environment.NewLine}Thank you for choosing Popeyes. :){Environment.NewLine}"); }
        
        Console.WriteLine($"The subtotal will be ${total}");
        Console.ReadKey();
    }

}
