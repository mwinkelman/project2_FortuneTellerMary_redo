using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2_FortuneTellerMary_redo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nAnswer my mystical questions to receive your FREE personalized FortuneTeller5000 reading!");
            Console.WriteLine("_________________________________________________________________________________________");
            Console.WriteLine(".........................................................................................");
            Console.WriteLine("_________________________________________________________________________________________");
            Console.WriteLine("vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv");
            bool playGame = true;
            do
            {
                //NAME
                string firstName;
                Console.WriteLine("\nEnter your first name: ");
                firstName = Console.ReadLine();
                string firstNameLow = firstName.ToLower();

                string lastName;
                Console.WriteLine("\nEnter your last name: ");
                lastName = Console.ReadLine();
                string lastNameLow = lastName.ToLower();

                string fullName = firstName + " " + lastName;

                //AGE           
                int ageNumber;
                int age;

                while (true)
                {
                    Console.WriteLine("\nEnter your age as a whole number: ");
                    string ageAnswer = Console.ReadLine();
                    bool isValid = int.TryParse(ageAnswer, out ageNumber);
                    if (isValid)
                    {
                        if (ageNumber <= 0)
                        {
                            Console.WriteLine("\nImpossible. You can't be zero or fewer years old.\nI'll give you another chance to answer that question.\n");
                        }
                        else if (ageNumber > 150)
                        {
                            Console.WriteLine("\nThat's not true. \nAlthough I did hear from someone that the first person who will live to 150 is living today. \nSounds awful.\n");
                        }
                        else
                        {
                            age = ageNumber;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nThat's not the kind of answer I'm looking for. \nI'm going to have to ask you for your age again.\n");
                    }
                }

                //BIRTH MONTH            
                string months = "january february march april may june july august september october november december";
                string[] monthArray = months.Split();
                string birthMonthAnswer;
                string birthMonth = null;

                do
                {
                    Console.WriteLine("\nEnter your birth month: ");
                    birthMonthAnswer = Console.ReadLine();
                    for (int i = 0; i < monthArray.Length; i++)
                    {
                        bool validMonth = birthMonthAnswer.Equals(monthArray[i], StringComparison.CurrentCultureIgnoreCase);
                        if (validMonth)
                        {
                            birthMonth = monthArray[i];
                        }
                    }
                    if (birthMonth == null)
                    {
                        Console.WriteLine("\nThat is not a month I recognize. Make sure you are spelling the month correctly.\n");
                    }
                }
                while (birthMonth == null);

                //FAVORITE COLOR
                string colors = "red orange yellow green blue indigo violet";
                string[] colorArray = colors.Split();
                string colorAnswer;
                string favoriteColor = null;

                do
                {
                    Console.WriteLine("\nEnter your favorite ROYGBIV color: \nIf you do not know what ROYGBIV is, enter \"Help\".\n");
                    colorAnswer = Console.ReadLine();
                    for (int i = 0; i < colorArray.Length; i++)
                    {
                        bool validColor = colorAnswer.Equals(colorArray[i], StringComparison.CurrentCultureIgnoreCase);
                        if (validColor)
                        {
                            favoriteColor = colorArray[i];
                        }
                    }
                    if (favoriteColor == null)
                    {
                        if (colorAnswer.Equals("help", StringComparison.CurrentCultureIgnoreCase))
                        {
                            Console.WriteLine("\nRed\nOrange\nYellow\nGreen\nBlue\nIndigo\nViolet\n");
                        }
                        else
                        {
                            Console.WriteLine("\nNot a valid input.\nMake sure that you are spelling the name of the color or \"Help\" correctly.\n");
                        }
                    }
                }
                while (favoriteColor == null);

                //SIBLINGS
                string siblingAnswer;
                int siblingNumber;
                int siblingCount;

                while (true)
                {
                    Console.WriteLine("\nHow many siblings do you have? ");
                    siblingAnswer = Console.ReadLine();
                    bool validSiblings = int.TryParse(siblingAnswer, out siblingNumber);
                    if (validSiblings)
                    {
                        if (siblingNumber < 0)
                        {
                            Console.WriteLine("\nImpossible. You can't have less than zero siblings.\nI'm going to ask you again.\n");
                        }
                        else
                        {
                            siblingCount = siblingNumber;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nThat's not the kind of answer I'm looking for. \nI'm going to ask you again.\n");
                    }
                }
                //RETIREMENT
                int yearsToRetirement;
                if (age % 2 == 0)
                {
                    yearsToRetirement = 50;
                }
                else
                {
                    yearsToRetirement = 15;
                }

                //VACATION HOME
                string vacationHome;
                switch (siblingCount)
                {
                    case 0:
                        vacationHome = "Trashcan Heights, Oklahoma";
                        break;
                    case 1:
                        vacationHome = "Naptimeburgh, Ohio";
                        break;
                    case 2:
                        vacationHome = "Pizza Falls, Florida";
                        break;
                    case 3:
                        vacationHome = "Glitterglue Springs, Michigan";
                        break;
                    default:
                        vacationHome = "\"Idependence\" Village Retirement Community, \nlocated in scenic Aurora, Ohio";
                        break;
                }

                //TRANSPORTATION
                string modeOfTransportation;
                switch (favoriteColor)
                {
                    case "red":
                        modeOfTransportation = "a cool sports car";
                        break;
                    case "orange":
                        modeOfTransportation = "a Sit and Spin";
                        break;
                    case "yellow":
                        modeOfTransportation = "a boat-car combo vehicle that will exist by then";
                        break;
                    case "green":
                        modeOfTransportation = "a \"car\"";
                        break;
                    case "blue":
                        modeOfTransportation = "both feet left";
                        break;
                    case "indigo":
                        modeOfTransportation = "a big clear ball made of hard plastic (you know, \nlike the kind hamsters have)";
                        break;
                    default:
                        modeOfTransportation = "a Razor Scooter";
                        break;

                }

                //MONEY IN THE BANK
                double bankBalance = 0;

                int first_1 = firstNameLow.IndexOf(birthMonth[0]);
                int last_1 = lastNameLow.IndexOf(birthMonth[0]);
                double firstAmount = 10.00;

                int first_2 = firstNameLow.IndexOf(birthMonth[1]);
                int last_2 = lastNameLow.IndexOf(birthMonth[1]);
                double secondAmount = 100.00;

                int first_3 = firstNameLow.IndexOf(birthMonth[2]);
                int last_3 = lastNameLow.IndexOf(birthMonth[2]);
                double thirdAmount = 1000.00;

                if (first_1 >= 0 || last_1 >= 0)
                {
                    bankBalance += firstAmount;
                }
                if (first_2 >= 0 || last_2 >= 0)
                {
                    bankBalance += secondAmount;
                }
                if (first_3 >= 0 || last_3 >= 0)
                {
                    bankBalance += thirdAmount;
                }
                //OUTPUT
                Console.WriteLine($"\n{fullName} will retire in {yearsToRetirement} years with ${bankBalance} in the bank, \na vacation home in {vacationHome} and {modeOfTransportation} to get around.");
                int askToPlay = 1;
                do
                {
                    Console.WriteLine("Would you like to play again? Enter \"Yes\" or \"No\"");
                    string playAgainAnswer = Console.ReadLine();

                    if (playAgainAnswer.Equals("no", StringComparison.CurrentCultureIgnoreCase))
                    {
                        playGame = false;
                        Console.WriteLine($"\nFarewell, {firstName}.");
                        askToPlay = 0;
                    }
                    else if (playAgainAnswer.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("\nGreat! Let's play again.\n");
                        askToPlay = 0;
                    }
                    else
                    {
                        Console.WriteLine("\nPlease answer \"yes\" or \"no\"");
                    }
                }
                while (askToPlay == 1);
            }

            while (playGame == true);
        }
    }
}
