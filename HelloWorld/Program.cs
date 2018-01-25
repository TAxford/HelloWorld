using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part one greetings statement
            string messageOne = "Hello World!";
            string messageTwo = "I am Spartacus";

            //Part two set initial Spartacus attributes
            int ageOne = 35;
            int ageTwo = 45;
            int ageThree = 80;
            double heightOne = 72.50;
            double heightTwo = 91.45;
            float weightOne = 210.0284606f;
            float weightTwo = 331.12345678f;
            bool isGodLikeOne = true;
            bool isGodLikeTwo = false;
            char genderMale = 'M';
            char genderFemale = 'F';

            ////Part three display variable values
            //Console.WriteLine(messageOne);/*Display intial greeting to console*/
            //Console.WriteLine(messageTwo);

            ////Part four mathematical operator, bool and char examples
            //Console.WriteLine(ageOne + ageTwo);/*Addition example*/
            //Console.WriteLine(heightOne - heightTwo);/*Subtraction example*/
            //Console.WriteLine(weightOne * weightTwo);/*Multiplication example*/
            //Console.WriteLine(isGodLikeOne);/*Division example*/
            //Console.WriteLine(genderMale);/*Char Example*/

            ////Part five variable reassignment
            //ageTwo = 70;
            //heightTwo = 35.12345f;
            //weightTwo = -429.1234573f;

            ////Part six mathematical operator examples
            //Console.WriteLine(ageOne + ageTwo);
            //Console.WriteLine(heightOne - heightTwo);
            //Console.WriteLine(weightOne * weightTwo);
            //Console.WriteLine(ageTwo / ageOne);
            //Console.WriteLine(ageTwo % ageOne);
            //Console.WriteLine(ageThree / ageOne);
            //Console.WriteLine(ageThree % ageOne);

            ////Part seven increment and decrement operator examples
            //ageTwo++;
            //Console.WriteLine(ageTwo);
            //ageTwo--;
            //Console.WriteLine(ageTwo);
            //Console.WriteLine("5" == "5");
            //Console.WriteLine(40 != 40);
            //Console.WriteLine(11 < 4);

            ////Part eight concantenation example
            //Console.WriteLine(messageOne + " " + messageTwo + ".");
            //Console.WriteLine("I am" + " " + ageOne + " " + "years old " + " " + "and yes its" + " " + isGodLikeOne + " " + "I am Godlike");
            //Console.WriteLine("I weigh around" + " " + weightOne + " " + "pounds, and am around" + " " + heightOne + " " + "inches tall");
            //Console.WriteLine("I am {0} years old and yes its {1} I am Godlike.", ageOne, isGodLikeOne);
            //Console.WriteLine("I weigh around {0} pounds, and am around {1} inches tall.", weightOne, heightOne);
            //Console.WriteLine("My father is {0} years old, and yes it's {1} he is a god.", ageThree, isGodLikeOne);

            ////Part nine string equality examples
            //Console.WriteLine(messageTwo.Equals(messageOne));
            //Console.WriteLine(messageTwo.Equals("I am Spartacus"));

            //string myGreeting = "Hello";
            //Console.WriteLine(myGreeting.ToUpper());
            //Console.WriteLine(myGreeting.ToLower());
            //Console.WriteLine(myGreeting);

            ////part ten string lenth examples
            //int messOneLength = messageOne.Length;
            //int messTwoLength = messageTwo.Length;

            //Console.WriteLine("The length of messageOne is" + messageOne.Length);
            //Console.WriteLine("The length of messageTwo is" + messageTwo.Length);
            //Console.WriteLine("The length of messageOne is" + messOneLength);
            //Console.WriteLine("The length of messageTwo is" + messTwoLength);

            ////part eleven conditional example
            //string city1 = "Vesuvius";
            //string city2 = "Nola";
            //string city3 = "Nuceria";
            //int city1distance, city2distance, city3distance;

            ////part twelve solicit user input example
            //Console.WriteLine("What is the distance to {0}?", city1);
            //city1distance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the distance to " + city2 + "?");
            //city2distance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the distance to Nuceria?");
            //city3distance = int.Parse(Console.ReadLine());

            //if ((city1distance <= 125) && ((city1distance < city2distance) && (city1distance < city3distance)))
            //{
            //    Console.WriteLine("We will march to Vensuvius");
            //}
            //if ((city2distance <= 125) && ((city2distance < city1distance) && (city2distance < city3distance)))
            //{
            //    Console.WriteLine("We will march to Nola");
            //}
            //if ((city3distance <= 125) && ((city3distance < city1distance) && (city3distance < city2distance)))
            //{
            //    Console.WriteLine("We will march to Nuceria");
            //}
            //Console.WriteLine("What is your rank?");
            //string rank = Console.ReadLine();

            //Console.WriteLine("What is your age?");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("What is your job soldier");
            //string job = Console.ReadLine();

            //if ((rank == "officer") && (age >= 26))

            //{
            //    Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //}

            //else if ((job == "cook") || (age <= 26))
            //{
            //    Console.WriteLine("Sorry, you are staying home.");
            //}
            //else
            //{
            //    Console.WriteLine("My army has to eat. Pack your pots and pans");
            //}
            //{
            //    Console.WriteLine("Sorry you are staying home.");
            //}

            //switch (job)
            //{
            //    case "infantry":
            //        Console.WriteLine("You will carrry a sword");
            //        break;

            //    case "archers":
            //        Console.WriteLine("You will carry a bow and arrow");
            //        break;

            //    case "supply":
            //        Console.WriteLine("You will carry pots and pans");
            //        break;

            //    case "specialist":
            //        Console.WriteLine("You will operate catapults");
            //        break;

            //    default:
            //        Console.WriteLine("You will ride horseback");
            //        break;

            //}
            //part thirteen array examples
            string[] foodlist = new string[5];
            foodlist[0] = "Milk";
            foodlist[1] = "Fruit";
            foodlist[2] = "Meat";
            foodlist[3] = "Wine";
            foodlist[4] = "Bread";
            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}", foodlist[0], foodlist[1], foodlist[2], foodlist[3], foodlist[4]);

            int[] foodAmount = new int[] { 1000, 100, 2000, 10000, 1500 };
            //Console.WriteLine(foodAmount[0]+ "," + foodAmount[1]+ "," + foodAmount[2] + "," + foodAmount[3] +"," + foodAmount[4]);

            //Console.WriteLine(foodlist[0] + " " + foodAmount[0] + "," + foodlist[1] + " " + foodAmount[1] + "," + foodlist[2] + " " + foodAmount[2] + "," + foodlist[3] + " " + foodAmount[3] + "," + foodlist[4] + " " + foodAmount[4]);

            //Console.WriteLine(foodlist.Length);

            //string[] elements = messageTwo.Split(' ');
            //Console.WriteLine(elements[0]); // prints "I"
            //Console.WriteLine(elements[1]); // prints "am"
            //Console.WriteLine(elements[2]); // prints "Spartacus"

            //Console.WriteLine(elements.Length);

            //string myName = "Sue";
            //char[] letters = myName.ToCharArray();
            //Console.WriteLine("The first letter of my name is " + letters[0]);
            //Console.WriteLine("The second letter of my name is " + letters[1]);
            //Console.WriteLine("The third letter of my name is " + letters[2]);

            // Console.WriteLine(letters.Length);
            // letters[0] = 's';
            //letters[1] = 'u';
            //letters[2] = 'e';
            //Console.WriteLine("{0}{1}{2}", letters[0], letters[1], letters[2]);

            //part fourteen while loop example
            //string action = " ";
            //while (action != "exit")
            //{
            //    Console.WriteLine("What is your rank soldier?");
            //    string rank = Console.ReadLine();

            //    Console.WriteLine("What is your age soldier?");
            //    int age = int.Parse(Console.ReadLine());
            //    Console.WriteLine("What is your job soldier?");
            //    string job = Console.ReadLine();

            //    if ((rank == "officer") || (age <= 26))
            //    {
            //        Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //    }
            //    else if ((job == "cook") || (age >= 26))
            //    {
            //        Console.WriteLine("My army has to eat. Pack your pots and pans");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry you are staying home.");
            //    }
            //    Console.WriteLine("Add another? Type exit to quit");
            //    action = Console.ReadLine();
            //}

            //string action = " ";
            //do
            //{
            //    Console.WriteLine("What is your rank soldier?");
            //    string rank = Console.ReadLine();

            //    Console.WriteLine("What is your age soldier?");
            //    int age = int.Parse(Console.ReadLine());
            //    Console.WriteLine("What is your job soldier?");
            //    string job = Console.ReadLine();

            //    if ((rank == "officer") || (age <= 26))
            //    {
            //        Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //    }
            //    else if ((job == "cook") || (age >= 26))
            //    {
            //        Console.WriteLine("My army has to eat. Pack your pots and pans");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry you are staying home.");
            //    }
            //    Console.WriteLine("Add another? Type exit to quit");
            //    action = Console.ReadLine();
            //} while (action != "exit");

            //Part fifteen for-loop examples
            for (int i = 0; i < foodAmount.Length; i++)
            {
                Console.WriteLine(i);
            }


























        }

    }
}
