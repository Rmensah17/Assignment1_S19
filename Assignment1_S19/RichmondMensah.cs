using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_S19
{
    class RichmondMensah
    {
        static void Main(string[] args)
        {
            /*
            This application contains a set of Methods that a user can call at run time. The available methods are printPrimeNumbers,getSeriesResult,decimalToBinary,
             binaryToDecimal,printTriangle,and computeFrequency. An Additional method was made to contain the console properties and menu of methods for the user
             to select from.
             
            Excercise Methods start from line 244
            Self Reflections start at line 184
            Credits: Richmond Mensah
            */

            //Call the main menu method to display the available methods to the user
            MainMenu();
            
            //dont close the console until the user closes the window or presses the Q key on the keyboard
            while (true) 
            {
                try
                {
                    //variable to draw lines for asthetics only. Reason I created this variable was because I used it multiple times and didnt want to keep drawing it
                    string consolelines = "---------------------------------------------";
                    //Variable to displat message after each method executon. Was used in a lot of places that's why I created the method.
                    string CalMessage = "\nEnter Letter to Pick Selection or Press C to clear Screen: ";

                    //Determine which method to call based on the user input (The Key the user pressed on the Keyboard)
                    switch (Console.ReadKey().Key)
                    {   //If the user press P, then call the printPrimeNumbers  method
                        case ConsoleKey.P:
                            Console.WriteLine("\n\nWelcome to the Print Prime Number Methods. Let's Begin:");
                            Console.Write(consolelines + "\n");
                            //Get Start Input from the user
                            Console.Write("Enter your Start number: ");
                            //Store the input to the start variable
                            int Start = int.Parse(Console.ReadLine());
                            //Get the end number from the user
                            Console.Write("Enter your End number: ");
                            //store the value to the end variable
                            int End = int.Parse(Console.ReadLine());
                            Console.WriteLine("\nPrime Numbers between {0} and {1} are:", Start.ToString(), End.ToString());
                            //Call the PrintPrimeNUmber Method and give the parameters the user entered. Output will be displayed to the user
                            printPrimeNumbers(Start, End);
                            Console.Write("\n"+consolelines +"\n");
                            Console.Write(CalMessage);
                            break;

                        //If the user presses S then call the getSeriesResult method.
                        case ConsoleKey.S:
                            Console.WriteLine("\n\n Welcome to the Get Series Method!!!");
                            Console.Write(consolelines + "\n");
                            //Get input from the user for the series to calculate its factorial
                            Console.Write("Enter a number to compute the series: ");
                            //Store the value to the n1 variable
                            long n1 = long.Parse(Console.ReadLine());
                            //Call the getSeriesResult Method and pass the parameter the user entered
                            double r1 = getSeriesResult(n1);
                            //Display the result of the method to the user
                            Console.WriteLine("\nThe sum of the series is: " + r1);
                            Console.Write(consolelines + "\n");
                            Console.Write(CalMessage);
                            break;

                        //If the user presses the D then call the decimalToBinary method
                        case ConsoleKey.D:
                            Console.WriteLine("\n\n Welcome to the Decimal to Binary Method!!!");
                            Console.Write(consolelines + "\n");
                            //Get input from the user for the decimal number
                            Console.Write("Enter the number to convert to binary: ");
                            //store the value to the n2 variable
                            long n2 = long.Parse(Console.ReadLine());
                            //Call the decimaltoBinary method and pass the parameter the user entered
                            long r2 = decimalToBinary(n2);
                            //display the result to the user
                            Console.WriteLine("\nBinary conversion of the decimal number " + n2 + " is: " + r2);
                            Console.Write(consolelines + "\n");
                            Console.Write(CalMessage);
                            break;

                        //if the user presses the B button then call the binaryToDecimal method
                        case ConsoleKey.B:
                            Console.WriteLine("\n\n Welcome to the Binary to Decimal Method!!!");
                            Console.Write(consolelines + "\n");
                            //Get Input from the user
                            Console.Write("Enter the binary number to convert to decimal: ");
                            //Store the value the user entered to the n3 variable
                            long n3 = long.Parse(Console.ReadLine());
                            //Call the binarytodecimal method and pass the value the user entered
                            long r3 = binaryToDecimal(n3);
                            //display the resul to the user
                            Console.WriteLine("\nDecimal conversion of the binary number " + n3 + " is: " + r3);
                            Console.Write(consolelines + "\n");
                            Console.Write(CalMessage);
                            break;

                        //if the user presses the T button then call the printTriangle method
                        case ConsoleKey.T:
                            Console.WriteLine("\n\n Welcome to the Print Triangle Method!!!");
                            Console.Write(consolelines + "\n");
                            //get input from the user about the lenght of the triangle
                            Console.Write("Enter the triangle lenght: ");
                            //store the input to the n4 variable
                            int n4 = int.Parse(Console.ReadLine());
                            //call the printtriangle method and draw the triangle to the user
                            printTriangle(n4);
                            Console.Write(consolelines + "\n");
                            Console.Write(CalMessage);
                            break;

                        //if the user presses the F button then call the computeFrequency method
                        case ConsoleKey.F:
                            Console.WriteLine("\n\n Welcome to the Frequency Computer Method!!!");
                            Console.Write(consolelines + "\n");
                            //the array to show
                            int[] arr = new int[] { 1, 2, 3, 2, 2, 2, 3, 2, };
                            //show the user the array and frequency
                            Console.Write($"The frequency will be based on the array list of: ");
                            //display the content of the array to the user prior to executing the triangle method
                            foreach (int i in arr)
                            {
                                
                                Console.Write($"{i} ");
                            }
                            //Generate the headers in a tab form
                            Console.WriteLine("\n\nNumber \tFrequency");
                            //call the triangle method and draw to the user
                            computeFrequency(arr);
                            Console.Write(consolelines + "\n");
                            Console.Write(CalMessage);
                            break;

                        //Go back to Main Menu and clear screen if the user presses the C key
                        case ConsoleKey.C:
                            //call the main menu method
                            MainMenu();
                            break;
                        
                            //close the app if the user presses the Q key
                        case ConsoleKey.Q:
                            //display a message to the user that the app is closing
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n\n!!!Application will now exit. Press any key to close!!!");
                            //require input from the user to confirm close
                            Console.ReadKey();
                            //close the app
                            Environment.Exit(0);
                            break;
                        
                            //tell the user the option entered is not available if none of the above keyboard keys are pressed
                        default:
                            Console.Write("\nOption not available yet. Enter Another Selection: ");
                            break;

                    }
                }
                //Return to main menu if input validations fails during any of the method executions
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed; //display error message in red
                    Console.Write("\n*****An Unexpected error has occured. Please Try again*****\n       Returning to Main Window in ");
                    //Display a count down to the main menu
                    for (int i = 5; i >= 0; i--)

                    {  
                        //pause 1 sec in each count
                        System.Threading.Thread.Sleep(1000);
                         Console.Write(" {0} >",i);                       
                    }
                    //call the main menu method
                    MainMenu();
                }

            }
            {
                /*
                 * Self Reflections:
                 * Rating (1 - 5): 5
                 * 
                 * Struggles:
                 *      While some of the method computations were stragihtforward, others were a little challenging.
                 *      My initial struggle was figuring out what logic I needed to use to do the computations. So I had to write some pseudo codes to simplify how I was going to program some of the calculations,
                 *      especially the Binary to decimal, decimal to binary conversions, and the Triangle.
                 * 
                 * What I learned :
                 *      I found the assignment interesting and even started creating other console apps. The Method I liked the most was the Printing of the Triangle . It was amazing how the output looked.
                 *      I also learned a lot about the IDE and developed some familiarity with setting console properties.
                 *      I mostly used C# in my leisure to create Windows Form Application and never thought of creating console apps, but I found it straightforward to create console apps and also started 
                 *      translating some of my GUI apps into console apps.
                 * 
                 *      This is the first time I published code to GitHub and after pushing this code, I was able to push an SSIS package code I have been working on as a leisure project to GitHub.
                 * 
                 * Recommendations:
                 *       I know this might be the first assignment, but instead of giving a specific set of functions to create, I think the students should be given the option to come up with an idea and create a function off that.
                 *      That way it engages the student to do some critical thinking to decide what they can do.
               
                 * 
                 */
            }
        }

        //Optional Method to hold menu options and console properties
        public static void MainMenu()
            {
            //Set the Console Properties
            Console.SetWindowSize(120,40); //resize the console window
            Console.ForegroundColor = ConsoleColor.DarkRed; //display menu options in red
            Console.Clear();
            Console.Title = "Spring 2019: Assignment One"; //Set a title for the console
            Console.Write("==============================================");
            //general information and a Today's Date that displays the current date and time
            Console.Write("\nSpring 2019 Assignment 1 Solution.\nProgrammed By: \t\tRichmond Mensah\nDate Programmed: \t1/21/2019 10:44:45 AM\nDue Date: \t\t1/27/2019 23:59:59 PM\nToday's Date: \t\t{0}\n", DateTime.Now);
            Console.Write("==============================================\n");

            //Variable to contain the caption for the Method values stored in the array below
            Console.Write("\t\tOptions: \n");
            //Create an array to store the names of the methods in this application
            String[] AvailbleOptions = new string[6];
            AvailbleOptions[0] = "P. printPrimeNumbers";
            AvailbleOptions[1] = "S. getSeriesResult";
            AvailbleOptions[2] = "D. decimalToBinary";
            AvailbleOptions[3] = "B. binaryToDecimal";
            AvailbleOptions[4] = "T. printTriangle";
            AvailbleOptions[5] = "F. computeFrequency";

            //Print each instance in the arrray on a new line to the user
            foreach (var index in AvailbleOptions)
            {
                Console.WriteLine("\t"+index + "\t");
            }
            Console.Write("--------------------------------------------\n****Press C to Clear Screen || Q to Quit****\n"); //Allows the user to clear the screen or quit the app
            Console.ForegroundColor = ConsoleColor.White; //revert color to white for method operations
            Console.Write("\nEnter Letter to Pick Selection: "); //Get user input. determines which method to call      
        }

        //Begining of Excercise Solutions: 1-6

        //1. printPrimeNumbers
        //Desciption: This method prints all the prime numbers between x and y
        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                int isPrime ; //to assign 1 if prime and 0 if not a prime number
                bool xnegative = x < 0; //used to determine if the start number entered by the user is less than 0
                bool ynegative = y < 0; //used to determine if the end number entered by the user is less than 0

                if (xnegative || ynegative) //if Start or End number is negative, then throw the message below:
                    {
                        Console.Write("***Negative number(s) detected*** \nPlease Check your input and try again.");
                    }
                else if (x > y) //else if the Start is greater than the End, throw the message below
                {

                    Console.Write("***Invalid range detected*** \nPlease Check your input and try again.");
                }

                else //if no errors then compute the Primes number determiner
                {
                    //outer loop to iterate through the Start and End inputs from the user
                    for (int i = x; i <= y; i++)
                    {
                        //isprime initializer: considers all numbers are prime
                        isPrime = 1;
                        //Inner loop to iterate between from 2 to the variable i above to determine what if the next number prime number
                        for (int j = 2; j < i; j++)
                        {
                            //not a prime number if the module of i/2 is 0
                            if (i % j == 0)
                            {
                                isPrime = 0;
                                break;
                            }
                        }
                        //is a prime number if the module is 1
                        if (isPrime == 1)
                        {
                            Console.Write("{0}\t", i.ToString());
                        }

                    }
                }
            }
            //display error message if the Prime number can't be computed due to an error from the Try block
            catch 
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
        }

        //2. getSeriesResult
        //Description: This method computes the series of  n!. that is it will calculate the factorial of the number specified by the user
        //In this method, I used a recursive method to calculate the Factorial. It takes the parameters of n from the user and computes
        public static double getSeriesResult(long n)
        {
            long zeroFactorial = 1; // holds the return value for 0!
            try
            {
                //user input must be greater than 0 to calculate series.
                if (n <0)
                {
                    Console.Write("\nSorry, your input must be >=0\n");
                    return 0;
                }
                else if(n > 0) //if n>0 then compute the series by using a recursive function
                {
                  return n*getSeriesResult(n-1);
                }
            }
            //display error message if the series can't be computed due to an error from the Try block
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return zeroFactorial; //return the factorial of 0 if input is 0
        }

        //3. decimalToBinary
        //This method converts a number from decimal (base 10) to binary (base 2)
        public static long decimalToBinary(long n)
        {
            string remainder = ""; //to hold the remainder after dividing by 2
            try
            {
                //Display error message if the value is n<0
                if(n<0)
                {
                    Console.Write("\n*****Please enter a number greater than or equal to 0 and try again.\n");
                    return -1; //retrn -1 as a result
                }

                //If n>=0 then  Do the following actions until the condition in the While block is met 
                do
                {
                    remainder = (n % 2) + remainder; //gets the remainder
                    n /= 2; //get the quotient after each divide
                }

                while (n > 0); //do until the quotient is 0
            }
            //display error message if the decimal number to Binary can't be computed due to an error from the Try block
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            }

            return long.Parse(remainder); //parse the remainder variable to long and return to the user
        }

        //4. binaryToDecimal
        //This method converts a number from binary (base 2) to decimal (base 10)
        public static long binaryToDecimal(long n)
        {
            //declare variables to use
            //convertedDecimal to hold the final result of the binary conversion
            //remainder to hold the remainder
            long ConvertedDecimal = 0, i = 0, remainder;
            try
            {
                
                //check for invalid binary numbers entered by the user and return -1 as defualt if found. Invalid binary is any number not in the range 0<=n<=1
                foreach (char c in n.ToString())
                {
                    if (c != '0' && c != '1')
                    {
                        //print the invalid binary numbers detected
                        // Console.Write(c); 
                        Console.WriteLine("*****Invalid Binary number detected*******");
                        return -1; //return -1 as a result
                    }
                    //if valid binary detected then 
                    else
                    {
                    
                        while (n != 0) //while the user input <> 0, do calculate the decimal convertion
                        {
                            //gets the remainder after deviding the binary by base 10
                            remainder = n % 10;
                            //get the quotient of the user input after diving by 10
                            n /= 10;
                            //Compute the Decimal number
                            ConvertedDecimal += (long)(remainder * Math.Pow(2, i));
                            ++i;
                        }

                    }
                 }
            }
            //display error message if the binary number to decimal cant be computed due to an error from the Try block
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }

            return ConvertedDecimal; //return the converted binary to decimal number
        }

        //5. printTriangle
        //This method prints a triangle using * for the lenght the user specifies
        public static void printTriangle(int n)
        {
            try
            {
                //Prevent Triangle Size greater than 100
                if (n > 100 || n<0)
                {
                    Console.WriteLine("\n*****Sorry, triangle size must be between 0<{SIZE}<=100.\n");
                }
                else //if above conditions are satisfied then draw the triangle for the length specified by the user
                {
                    Console.WriteLine();
                    for (int i = 1; i <= n; i++) //Iterates for the number of lines the triangle will use
                    {
                        for (int j = 1; j <= n - i; j++) //make spaces at the right to make it a perfect triangle. remove the -i to make it a 90*(right) triangle.
                        {
                           Console.Write(" ");
                        }
                        for (int k = 1; k <= i; k++) //print the triangle using *. That is, first line will have 1 *, second line will have 2 *'s and so forth till the nth size specified by the user
                        {
                            Console.Write(" *");
                        }

                        Console.WriteLine("");
                    }
                }
            }
            //display error message if the Triangle cant be computed due to an error from the Try block
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        //6. computeFrequency
        //This method computes the frequency of each element in the array
        public static void computeFrequency(int[] a)
        {
            try
            {
                //Sort the Array in Ascending order
                Array.Sort(a);
                //Group the array elements and print each unique and count of the unique
                foreach (var index in a.GroupBy(x => x))
                {
                        //print the array element and count and convert to string
                        Console.WriteLine($"{index.Key} \t{index.Count()}");
                }
            }
            //display error message if the Frequency cant be computed due to an error from the Try 
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }

           //The End of Assignment 1
           //By Richmond Mensah.
           //Date of Completion: 1/27/19 12:29:33 PM
    }
}
