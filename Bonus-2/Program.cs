using System;
namespace Bonus2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
                    //Declear and initialize DateTime variable
                    DateTime today = DateTime.Today;
                    //get just today's date using the Today property
                    int year = today.Year;
                    int currentMonth = today.Month;
                    int currentDay = today.Day;

                    //Ask the user to input his birthday in a special formate
                    Console.WriteLine("Hello please enter your birthday in this formate (yyyy,MM,DD)");
                    //read the user input
                    string input = Console.ReadLine();

                    //Declear and initialize string array to store the user input
                    string[] userInput = input.Split(',');

                    int[] arrInt = new int[3];  // Declare int array of zeros
                    //store the user bithday inside an array
                    for(int i =0; i < 3; i++)
                    {   
                         arrInt[i] = int.Parse(userInput[i]);
                    }

                    //Store the user birthday in DayTime variable
                     DateTime userBirthday = new DateTime(arrInt[0], arrInt[1], arrInt[2]);
                    

                    // If the current day is the user's birthday,print a nice message.
                    if (currentMonth == userBirthday.Month && currentDay == userBirthday.Day)
                         {
                             Console.WriteLine("* Happy Birthday *");
                         }

                    //Calculate the age of the user in days
                    TimeSpan interval = today - userBirthday ;
                    Console.WriteLine("Age in Days:"+ interval.TotalDays);

                    //Calculate the age of the user in years
                    int Years = new DateTime(DateTime.Now.Subtract(userBirthday).Ticks).Year - 1;
                    Console.WriteLine("Age in years:" + Years);

        }
    }
}
