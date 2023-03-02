namespace Week6_FA

{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Reflection.Metadata;
    //Fabian Acosta
    //Assignment 6
    //03-02-2023

    internal class Program
    {
        static void Main(string[] args)
        {
           ProblemOne();
           ProblemTwo();
        }

        static void ProblemOne()        //List Problem
        {
            //Declare variables
            List<string> friends = new List<string>();
            string userInput = "";
            int counter = 0;

            //Ask user to enter names
            do
            {
                Console.WriteLine("Enter a name for a friend or press ENTER to end program: ");
                userInput = Console.ReadLine();

                if (userInput == "") { } //If the user presses ENTER first, nothing will be added to the list and the loop will terminate

                else                         //else, the user input is added to list and the counter will be used for later
                {
                    friends.Add(userInput);
                    counter++;
                }
            } while (userInput != "");

            //Depending on the users number of inputs, the outcome will be different
            if (friends.Count == 0)
            {
                Console.WriteLine("\n");
            }
            else if (friends.Count == 1)
            {
                Console.WriteLine("[" + friends[0] + "] likes your post.\n");
            }
            else if (friends.Count == 2)
            {
                Console.WriteLine("[" + friends[0] + "] and [" + friends[1] + "] like your post.\n");
            }
            else
            {
                Console.WriteLine("[" + friends[0] + "], [" + friends[1] + "] and [" + (counter - 2) + "] others liked your post.\n");    //Counter is used for the remaining of friends
            }                                                                                                                           //and subtracts first two elements
        }                                                                                                                               //I don't know if this was the best way to do it


        static void ProblemTwo()
        {
            //Declare values
            Dictionary<char, int> userSentence = new Dictionary<char, int>();
            string userInput;

            //Prompt user
            Console.WriteLine("Enter a sentence: ");
            userInput = Console.ReadLine();

            char[] charArr = userInput.ToCharArray();           //Convert sentence into an array of characters
            
            for(int i = 0; i < charArr.Length; i++)             
            {
                if (userSentence.ContainsKey(charArr[i]))       //If the userSentence contains the character in the array
                {                                                //if the character is a space, remove it from the dictionary
                    if (charArr[i] ==  ' ')                           //else add the number of times the character is mentioned
                    {
                        userSentence.Remove(charArr[i]);
                    }
                    else
                    {
                        userSentence[charArr[i]]++;
                    }
                   
                }
                else
                {                                                       //if the character isn't in the dictionary, add it to dictionary
                    if (charArr[i] == ' ')                                 //I included this if for the first iteration of the space that is not included in the dictionary already
                    {                                                       //Not sure if I did this the most efficient way either
                        //userSentence.Remove(charArr[i]);
                    }
                    else { userSentence.Add(charArr[i], 1); }
                }
                  
            }
            foreach(KeyValuePair<char, int> letter in userSentence)         //Output
            {
                Console.WriteLine(letter.Key + " | " + letter.Value);
            }



        }
    }
}