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
            //Excercise Methods start from line 204
            //Self Reflections start at line 165
            //Name: Richmond Mensah

            //Call the main menu method to display the available methods to the user
            MainMenu();
            
            //dont close the console until the user click the X
            while (true) 
            {
                try
                {
                    //variable for asthetics only
                    string consolelines = "---------------------------------------------";

                    //Determine which method to call based on the user input (The Key the user pressed)
                    switch (Console.ReadKey().Key)
                    {   //printPrimeNumbers
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
                            Console.Write("\nEnter Letter to Pick Selection or Press C to clear Screen: ");
                            break;
                        //getSeriesResult
                        case ConsoleKey.S:
                            Console.WriteLine("\n\n Welcome to the Get Series Method!!!");
                            Console.Write(consolelines + "\n");
                            //Get input from the user for the series to calculate
                            Console.Write("Enter a number to compute the series: ");
                            //Store the value to the n1 variable
                            long n1 = long.Parse(Console.ReadLine());
                            //Call the getSeriesResult Method and pass the parameter the user entered
                            double r1 = getSeriesResult(n1);
                            //Display the result of the method to the user
                            Console.WriteLine("\nThe sum of the series is: " + r1);
                            Console.Write(consolelines + "\n");
                            Console.Write("\nEnter Letter to Pick Selection or Press C to clear Screen: ");
                            break;
                        //decimalToBinary
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
                            Console.Write("\nEnter Letter to Pick Selection or Press C to clear Screen: ");
                            break;
                        //binaryToDecimal
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
                            Console.Write("\nEnter Letter to Pick Selection or Press C to clear Screen: ");
                            break;
                        //printTriangle
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
                            Console.Write("\nEnter Letter to Pick Selection or Press C to clear Screen: ");
                            break;
                        //computeFrequency
                        case ConsoleKey.F:
                            Console.WriteLine("\n\n Welcome to the Frequency Computer Method!!!");
                            Console.Write(consolelines + "\n");
                            //the array to show
                            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2, };
                            //show the user the array and frequency
                            Console.Write($"The frequency will be based on the array list of: ");
                            //display the content of the array to the user prior to executing the triangle method
                            foreach (int i in arr)
                            {
                                
                                Console.Write($"{i} ");
                            }
                            //Generate the headers
                            Console.WriteLine("\n\nNumber \tFrequency");
                            //call the triangle method and draw to the user
                            computeFrequency(arr);
                            Console.Write(consolelines + "\n");
                            Console.Write("\nEnter Letter to Pick Selection or Press C to clear Screen: ");
                            break;

                        //Go back to Main Menu and clear screen
                        case ConsoleKey.C:
                            //call the main menu method
                            MainMenu();
                            break;
                        //close the app
                        case ConsoleKey.Q:
                            //display a message to the user that the app is closing
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n\n!!!Application will now exit. Press any key to close!!!");
                            //require input from the user to confirm close
                            Console.ReadKey();
                            //close the app
                            Environment.Exit(0);
                            break;
                        //tell the user the option entered is not available
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
                 * self reflections: honestly, I didnt find the assignment to be challenging in terms of coding but found it challenging on how to do the calculations, especcially on the binary to decimal conversion
               
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
            Console.Write("\nSpring 2019 Assignment 1 Solution.\nProgrammed By: \t\tRichmond Mensah\nDate Programmed: \t1/21/2019 10:44:45 AM\nDue Date: \t\t1/27/2019 23:59:59 PM\nToday's Date: \t\t{0}\n", DateTime.Now);
            Console.Write("==============================================\n");

            //Assign the values to Menu Options
            Console.Write("\t\tOptions: \n");
            //Create an array to store the values
            String[] AvailbleOptions = new string[6];
            AvailbleOptions[0] = "P. printPrimeNumbers";
            AvailbleOptions[1] = "S. getSeriesResult";
            AvailbleOptions[2] = "D. decimalToBinary";
            AvailbleOptions[3] = "B. binaryToDecimal";
            AvailbleOptions[4] = "T. printTriangle";
            AvailbleOptions[5] = "F. computeFrequency";

            //Print Menu Options to the user
            foreach (var index in AvailbleOptions)
            {
                Console.WriteLine("\t"+index + "\t");
            }
            Console.Write("--------------------------------------------\n****Press C to Clear Screen || Q to Quit****\n"); //Allows the user to clear the screen or quit the app
            Console.ForegroundColor = ConsoleColor.White; //revert color ti white for method operations
            Console.Write("\nEnter Letter to Pick Selection: "); //Get user input. determines which method to call      
        }

        //Excercise Solutions 1-6

        //printPrimeNumbers
        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                int isPrime ;
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

                else //if no errors then compute the Primes
                {
                    for (int i = x; i <= y; i++)
                    {
                        //isprime initializer: all numbers are prime
                        isPrime = 1;
                        for (int j = 2; j < i; j++)
                        {
                            //not prime numbers if the module of i/2 is 0
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
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
        }

        //getSeriesResult
        public static double getSeriesResult(long n)
        {
            long product = 1; //variable to calculate the series
            try
            {
                //dont calculate for numbers less than 0.
                if (n <0)
                {
                    Console.Write("\nSorry, your input must be >=0\n");
                    return 0;
                }
                else
                {
                    int[] a = new int[n]; //to hold the iteration. can just change it to n

                    for (int i = 1; i <= a.Length; i++)
                    {
                        product = product * i;

                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return product; //return the series result
        }

        //decimalToBinary
        public static long decimalToBinary(long n)
        {
            string remainder = ""; //to hold the remainders
            try
            {

                do
                {
                    remainder = (n % 2) + remainder; //gets the remainder
                    n /= 2; //gets the quotient
                    //Console.WriteLine(n);
                    // Console.WriteLine(remainder);
                }

                while (n > 0); //do until the quotient is 0

                //Console.WriteLine(remainder);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            }

            return long.Parse(remainder);
        }

        //binaryToDecimal
        public static long binaryToDecimal(long n)
        {
            long ConvertedDecimal = 0, i = 0, remainder;
            try
            {
                
                //check for invalid binary numbers and return -1
                foreach (char c in n.ToString())
                {
                    if (c != '0' && c != '1')
                    {
                        // Console.Write(c); //print the invalid binary numbers
                        Console.WriteLine("*****Invalid Binary number detected*******");
                        return -1; 
                    }
                    //if valid binary then 
                    else
                    {
                    
                        while (n != 0)
                        {
                            remainder = n % 10;
                            n /= 10;
                            ConvertedDecimal += (long)(remainder * Math.Pow(2, i));
                            ++i;
                        }

                    }
                 }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }

            return ConvertedDecimal;
        }

        //printTriangle
        public static void printTriangle(int n)
        {
            try
            {
                //Prevent Triangle Size greater than 100
                if (n > 100 || n<0)
                {
                    Console.WriteLine("\n*****Sorry, triangle size must be between 0<{SIZE}>100.\n");
                }
                else
                {
                    Console.WriteLine();
                    for (int i = 1; i <= n; i++) //Iterates for the number of lines the triangle will use
                    {
                        for (int j = 1; j <= n - i; j++) //make spaces at the right to make it a perfect triangle. remove the -i to make it a 90* triangle.
                        {
                           Console.Write(" ");
                        }
                        for (int k = 1; k <= i; k++) //print the triangle using * that is first line will have 1, second line will have 2 and so forth till the nth size
                        {
                            Console.Write(" *");
                        }

                        Console.WriteLine("");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        //computeFrequency
        public static void computeFrequency(int[] a)
        {
            try
            {
                //Sort the Array
                Array.Sort(a);
                //Group the array elements
                foreach (var index in a.GroupBy(x => x))
                {
                    //print the array element and count and convert to string
                    Console.WriteLine($"{index.Key} \t{index.Count()}");
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }


    }
}
