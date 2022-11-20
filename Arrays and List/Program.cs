using System;
using System.Collections.Generic;
using System.Text;



class Program
{
    static void Main()
    {
        //Defining variable and assigning value including defining the length
        //Creating new instance called an object
        string[] strArray = { "Sunday", "Wednesday", "Thrusday", "Saturday", "Friday", "Tuesday", "Monday" };
        Console.WriteLine("Please select a number from 0-6 for your lucky day:");
        int selectedWord = int.Parse(Console.ReadLine());
        //Starting 0 as base index in the array
        for (int i = 0; i < strArray.Length; i++) //Using else and if statement to display value of the chosen index from the user
        {
            if (selectedWord == 0)
            {
                Console.WriteLine("Your Lucky Day is: " + strArray[0]);
                break;
            }
            else if (selectedWord == 1)
            {
                Console.WriteLine("Your Lucky Day is: " + strArray[1]);
                break;
            }
            else if (selectedWord == 2)
            {
                Console.WriteLine("Your Lucky Day is: " + strArray[2]);
                break;
            }

            else if (selectedWord == 3)
            {
                Console.WriteLine("Your Lucky Day is: " + strArray[3]);
                break;
            }


            else if (selectedWord == 4)
            {
                Console.WriteLine("Your Lucky Day is: " + strArray[4]);
                break;
            }

            else if (selectedWord == 5)
            {
                Console.WriteLine("Your Lucky Day is:  " + strArray[5]);
                break;
            }
            else if (selectedWord == 6)
            {
                Console.WriteLine("Your Lucky Day is: " + strArray[6]);
                break;
            }

            else
            {
                Console.WriteLine("Sorry, that is a wrong choice. Please try again later.");
                System.Threading.Thread.Sleep(5000);
                Environment.Exit(0);
            }


        }

        //Creating a integer array and assining values to it
        int[] myArraynumber = { 6, 19, 30, 26, 18 };

        Console.WriteLine("Please select a number from 0-4 for your lucky number:");
        int selectedNum = int.Parse(Console.ReadLine());

        for (int m = 0; m < myArraynumber.Length; m++)// Using if and else statement to displaying the content of the index
        {

            if (selectedNum == 0)
            {
                Console.WriteLine("Your Lucky Number is: " + myArraynumber[0]);
                break;
            }
            else if (selectedNum == 1)
            {
                Console.WriteLine("Your Lucky Number is: " + myArraynumber[1]);
                break;
            }
            else if (selectedNum == 2)
            {
                Console.WriteLine("Your Lucky Number is: " + myArraynumber[2]);
                break;
            }
            else if (selectedNum == 3)
            {
                Console.WriteLine("Your Lucky Number is: " + myArraynumber[3]);
                break;
            }
            else if (selectedNum == 4)
            {
                Console.WriteLine("Your Lucky Number is: " + myArraynumber[4]);
                break;
            }
            else
            {
                Console.WriteLine("Sorry, you entered a wrong number. Please try again later.");//Message when a user's input is out of the length of the array
                System.Threading.Thread.Sleep(5000);
                Environment.Exit(0);
            }
        }

        //Creating a list of strings and adding value 
        List<string> luckyColor = new List<string>();
        luckyColor.Add("Green");
        luckyColor.Add("Red");
        luckyColor.Add("White");
        luckyColor.Add("Blue");

        Console.WriteLine("Please select a number from 0-3 for your lucky color:");
        int selectColor = int.Parse(Console.ReadLine()); // Asking for the user input

        for (var d = 0; d < luckyColor.Count; d++) //Using if and else statement to display the value of the user input
        {
            if (selectColor == 0)
            {
                Console.WriteLine("Your lucky color is: " + luckyColor[0]);
            }
            else if (selectColor == 1)
            {
                Console.WriteLine("Your lucky color is: " + luckyColor[1]);
                break;
            }
            else if (selectColor == 2)
            {
                Console.WriteLine("Your lucky color is: " + luckyColor[2]);
                break;
            }
            else if (selectColor == 3)
            {
                Console.WriteLine("Your lucky color is: " + luckyColor[3]);
                break;
            }
            else
            {
                Console.WriteLine("Sorry, that is not an option. Please try again later.");
                System.Threading.Thread.Sleep(5000);
                Environment.Exit(0);
            }

            Console.ReadLine();
        }
    }
}
          





               

            
        

   