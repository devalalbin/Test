using System;
using System.IO;


//Gjord av Albin de Val
namespace TestKurs
{
    class Program
    {
        public class Person
        {
            public string name;
            public int health,luck,strenght;
        
            public void Greetings()
            {
                Console.WriteLine("Hey! My name is " + name + " hp is: " + health + " luck is: " + luck + " strenght is: " + strenght);
            }
            public void GenerateStats()
            {
                Random rd = new Random(); // hp 50-10 luck 1-50 and strenght is 1-20 range
                health = rd.Next(50, 100);
                luck = rd.Next(1, 50);
                strenght = rd.Next(1, 20);
            }

        }
        static void Main(string[] args)
        {
            int userChoice;
            int colorCount = 0; //to help in function 3 with the color choice
            FunktionList();
            while (true)
            {
               


                Console.WriteLine("Please choose your function: (1-16)");
                userChoice = Convert.ToInt32(Console.ReadLine());

                if (userChoice < 0 && userChoice > 18)// when user dosen't put in a number in the correct range 1-17
                {
                    Console.WriteLine("Your desired function dosen't exist");
                }
                else
                {
                    switch (userChoice)
                    {      //switch case statement as the "menu"
                        case 0: return; // exit
                        case 1:
                            FuncOne();
                            break;
                        case 2:
                            FuncTwo();
                            break;
                        case 3:
                            colorCount = FuncThree(colorCount);
                            break;
                        case 4:
                            FuncFour();
                            break;
                        case 5:
                            Console.WriteLine("Please enter your first number: ");
                            int valOne = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Please enter your second number: ");
                            int valTwo = Convert.ToInt32(Console.ReadLine());
                            FuncFive(valOne, valTwo);
                            break;
                        case 6:
                            FuncSix();
                            break;
                        case 7:
                            FuncSeven();
                            break;
                        case 8:
                            FuncEight();
                            break;
                        case 9:
                            FuncNine();
                            break;
                        case 10:
                            FuncTen();
                            break;
                        case 11:
                            FuncEleven();
                            break;
                        case 12:
                            FuncTwelve();
                            break;
                        case 13:
                            FuncThirteen();
                            break;
                        case 14:
                            FuncFourteen();
                            break;
                        case 15:
                            FuncFifteen();
                            break;
                        case 16:
                            FuncSixteen();
                            break;
                       

                    }
                }


            }
            static void FuncOne() //1.Funktion som skriver ut ”Hello World” i konsolen
            {
                Console.WriteLine("Hello World");
                return;
            }

            static void FuncTwo()//2.Funktion som tar in input från användaren (Förnamn, Efternamn, Ålder) och sedan skriver ut dessa i konsolen
            {
                Console.WriteLine("Please enter your first name: ");
                string fName = Console.ReadLine();
                Console.WriteLine("Please enter your secound name: ");
                string sName = Console.ReadLine();
                Console.WriteLine("Enter your age");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(fName + " " + sName + " your age is " + age);
            }

            static int FuncThree(int color) //3.Funktion som ändrar färgen på texten i konsolen (och ändrar tillbaka om man använder funktionen igen
            {

                if (color % 2 == 0) //Modulus to swap between colors
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                color++;
                return color;
            }

            static void FuncFour()//4.Funktion för att skriva ut dagens datum
            {
                DateTime today = DateTime.Now;
                Console.WriteLine(today.ToString("d")); // d = todays date
                return;
            }

            static void FuncFive(int inOne, int inTwo)//5.Funktion som tar två input värden, sedan skriver ut vilket av dem som är störst.
            {
                Console.WriteLine("comparing: " + inOne + " with " + inTwo);
                if (inOne > inTwo)
                {
                    Console.WriteLine(inOne + " Is larger than "+inTwo);
                    return;
                }
                else { Console.WriteLine(inTwo + " Is larger than "+ inOne); }
                return;
            }

            static void FuncSix() //6.Funktion som genererar att slumpmässigt tal mellan 1 och 100. Användaren ska sedan gissa talet
            {
                Random rd = new Random();
                int rndNr = rd.Next(1, 100);
                //Console.WriteLine("The random number is " + rndNr);    <- enable this to see the generated number
                Console.WriteLine("Guess the random number 1-100: (enter 0 to exit to menu)");
                int guess = Convert.ToInt32(Console.ReadLine());
                while (guess != 0) // if 0 quit
                    if (rndNr == guess)
                    {
                        Console.WriteLine("You guessed correctly! the number was " + rndNr);
                        return;
                    }
                    else if (rndNr > guess)
                    {
                        Console.WriteLine("Your guess is too low, Guess again: ");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }

                    else
                    {
                        Console.WriteLine("Your guess is too high, Guess again: ");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }
                return;
            }
            static void FuncSeven() //7.Funktion där användaren skriver in en textrad, som sedan sparas i en fil på hårddisken
            {
                Console.WriteLine("Please write something to be saved to a file");
                var path = @"C:\testprojekt\func7.txt";

                string message = Console.ReadLine();
                File.WriteAllText(path, message);

                Console.WriteLine("text written into c: testprojekt\func7.txt");
            }

            static void FuncEight() //8.Funktion där en fil läses in från hårddisken (för enkelhetens skull kan man använda filen från uppgift 7)
            {
                Console.WriteLine("Reading from file c: testprojekt\func7.txt");
                var path = @"C:\testprojekt\func7.txt";
                Console.WriteLine(File.ReadAllText(path));
             
            }
            static void FuncNine() //9.Funktion där användaren skickar in ett decimaltal och får tillbakaroten ur, upphöjt till 2 och upphöjt till 10
            {

                Console.WriteLine("Enter a decimal number:  ");
                double number = Convert.ToDouble(Console.ReadLine());
                double sqrt = Math.Sqrt(number);
                double squared = number * number;
                double powerTen = Math.Pow(number, 10);
                Console.WriteLine("Square root of "+ number + " = " + sqrt); 
                Console.WriteLine(number + "^2 = " + squared);
                Console.WriteLine(number + "^10 = " + powerTen);
                return;
            }

            static void FuncTen() //10.Funktion där programmet skriver ut en multiplikationstabell från 1 till 10.
            {
                int i ;
                int j ;
                for (i = 1; i < 11; i++) {
                    for (j = 1; j < 11; j++)
                    {
                        Console.Write(i*j + " "); // så text skrivs på samma rad
                    }
                    Console.WriteLine(" "); // så det blir ny rad

                }
                return;
            }
            static void FuncEleven() //11.Funktion som skapar två arrayer. Den första fylls med slumpmässiga tal. Den andra fylls med talen från den första i stigande ordning.
            {
                
                Random rd = new Random();
                int elements = rd.Next(1,10);  // first we randomize how number of elements in array between 1 and 10 (restricted to max 10 at the moment can be changed)
                int i;
                int fillerNr;
                int j;
                int temp = 0;
                int[] ar = new int[elements];
                Console.WriteLine("nr of elements: " + elements);
                Console.WriteLine("Randomly generated list: ");
                for (i = 0; i < elements; i++) { // fills the array from array[0] to array[elements -1 ] = total elements
                    fillerNr = rd.Next(1, 1000); //The element value (restricted to 1000 at the moment can be changed)
                    ar[i] = fillerNr;
                    Console.Write(ar[i]+" ");
                    
                }
                //Sorting compares 2 elements and swap their places/ then moves up in the list
                for (i = 0; i < elements; i++)
                {
                    for (j = i + 1; j < elements; j++) //compars ar[x] is bigger than ar[x+1] and swaps them if thats the case
                    {
                        if (ar[i] > ar[j])
                        {
                            temp = ar[i];
                            ar[i] = ar[j];
                            ar[j] = temp;
                        }
                   
                    }
                   
                }
                //printing of the sorted list
                Console.WriteLine(" ");
                Console.WriteLine("Sorted list: ");
                for (i = 0; i < elements; i++)
                {
                    Console.Write(ar[i] + " ");
                }
            }
            static void FuncTwelve() //12.Funktion som tar en input från användaren och kontrollerar ifall det är en palindrom
            {
                Console.WriteLine("Enter name or word: ");// get the lenght and reverse it, then compare
                string word = Console.ReadLine();
                int lenght = word.Length - 1;
                string reverse = ""; //needed to be filled with some starting value
                while(lenght>=0)
                {
                    reverse = reverse + word[lenght]; //reverse = word[lenght] doesnt seem to work
                    lenght--;
                   
                }
                // get the lenght and reverse it
                //then compare
                //Console.WriteLine(reverse);
                if(reverse == word) {
                    Console.WriteLine(word + " IS a palindrome cause reversed it says: " + reverse); }
                else
                {
                    Console.WriteLine(word + " IS NOT a palindrome cause reversed it says: " + reverse);
                
                }
                return;
            }
            static void FuncThirteen() //13.Funktion som tar två inputs från användaren och skriver sedan ut alla siffror som är mellan de två inputsen.
            {
                Console.Write("Please enter your first value: ");
                int valOne = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter your second value: ");
                int valTwo = Convert.ToInt32(Console.ReadLine()); // get 2 values, see what value is bigger and compare them to see the differance
                int diff,lowval;

                if (valOne > valTwo) { // check what value is the lowest and count the differance
                    diff = valOne - valTwo;
                    lowval = valTwo;
                }
                else
                {
                    diff = valTwo - valOne;
                    lowval = valOne;
                }

                while (diff != 1) //count from lower value up the difference-1
                {
                    Console.WriteLine(lowval + 1);
                    diff--;
                    lowval++;
                }
                return;
            }
            static void FuncFourteen() //14.Funktion där användaren skickar in ett antal värden (komma-separerade siffror) som sedan sorteras och skrivs ut efter udda och jämna värden. 
            {
                // read a long string of userinputs 
                Console.WriteLine("Enter some values seperated by ,");
                string strList = Console.ReadLine();  // read a string of values from user
                string[] strSplit = strList.Split(","); //split it using .Split
                int strNumb = 0; //
                int[] evenArray = new int[32]; // not sure how to make the arrays dynamic size
                int[] oddArray = new int[32];
                int i = 0;
                int j = 0;

                foreach (string str in strSplit)
                {// for each split string convert it to int and check if its even or unevel
                  
                    strNumb = Convert.ToInt32(str); //convert it to integer
                  //  Console.WriteLine(strNumb);
                    if(strNumb%2 == 0) // checking with modulus if number is even add to "even array" else add to odd array
                    {
                        //Console.WriteLine("this number is even");
                        evenArray[i] = strNumb;
                        i++;
                    }
                    else
                    {
                      //  Console.WriteLine("this number is odd");
                        oddArray[j] = strNumb;
                        j++;
                    }
                }

                // display the even and odd arrays
                Console.WriteLine("Even Numbers: ");
                foreach (var evenitem in evenArray )
                {
                    if (evenitem != 0)
                    {                      
                        Console.Write(evenitem.ToString() + " ");
                    }

                }
                Console.WriteLine(" ");
                Console.WriteLine("Odd Numbers: ");
                foreach (var odditem in oddArray)
                {
                    if (odditem != 0)
                    {
                      Console.Write(odditem.ToString() + " ");
                    }
                }
                Console.WriteLine(" ");

                return;
            }
            
           
        static void FuncFifteen(){
            Console.WriteLine("Enter some values seperated by ,");
            string strList = Console.ReadLine();  // read a string of values from user
            string[] strSplit = strList.Split(","); //split it using .Split
            int strNumb = 0; //
            int totalValue = 0;
            
            foreach (string str in strSplit)
            {// for each split string convert it to int and check if its even or unevel

                strNumb = Convert.ToInt32(str); //convert it to integer
                Console.Write("+"+strNumb);
                    totalValue = totalValue + strNumb;
            }
                Console.WriteLine(" = The total value is " + totalValue);
            }
        
            static void FuncSixteen() 
            {
                Person human = new Person();
                Person enemy = new Person();
                Console.WriteLine("Please enter your character name: ");
                human.name = Console.ReadLine();
                Console.WriteLine("Please enter your enemy name: ");
                enemy.name = Console.ReadLine();
                human.GenerateStats();
                enemy.GenerateStats();
                human.Greetings();
                enemy.Greetings();
                return;
            }

            static void FunktionList()
            {
                Console.WriteLine(" ");
                Console.WriteLine("Function list:");
                Console.WriteLine("1:Hello world!");
                Console.WriteLine("2:Namn och ålder");
                Console.WriteLine("3:Ändra färg");
                Console.WriteLine("4:Dagens datum");
                Console.WriteLine("5:Jämför två tal storleksmässigt");
                Console.WriteLine("6:Gissa talet");
                Console.WriteLine("7:Spara textrad till fil");
                Console.WriteLine("8:Läs upp textrad ifrån fil");
                Console.WriteLine("9:Roten ur/^2 och ^10");
                Console.WriteLine("10: multiplikationstabell");
                Console.WriteLine("11:Skapa array sedan sortera");
                Console.WriteLine("12: Palindrom ");
                Console.WriteLine("13:Siffror mellan två tal");
                Console.WriteLine("14:Sortera värden");
                Console.WriteLine("15:Addera värden");
                Console.WriteLine("16:Karaktär och motståndare");

            }
          
        }
    }
}
