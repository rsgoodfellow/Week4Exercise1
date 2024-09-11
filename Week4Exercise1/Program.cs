using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Exercise1
{
    internal class Program
    {
        static Dictionary<string, int> votes = new Dictionary<string, int> //declares and initializes dictionary
        {
            {"Mark", 0}, {"Jerry", 0}, {"Dave", 0} //dictionary keys and values
        };
        static void CastVote(string canidateName) //method to cast a vote
        {

            if (votes.ContainsKey(canidateName)) //if condition to check if user input is a valid canidate
            {
                votes[canidateName]++; //adds vote to the selected canidate
                Console.WriteLine("You have voted for " + canidateName); //displays text informing user who they voted for
                Console.WriteLine(); //prints blank line
            }
            else
            {
                Console.WriteLine("Please enter a valid canidate."); //informs the user to enter a valid canidate
                Console.WriteLine(); //prints blank line
            }
        }

        static void DisplayResults() //method to display results
        {
            foreach (var canidate in votes) //foreach loop to display the votes for each canidate
            {
                Console.WriteLine(canidate.Key + " has " + canidate.Value + " votes."); //displays how many votes a canidate got
            }
            Console.WriteLine(); //prints blank line
        }

        static void ResetVotes() //method to reset votes
        {
            for (int i = 0; i < votes.Count; i++) //for loop to go through each canidate and reset their votes to 0
            {
                var candidate = votes.Keys.ElementAt(i); //declares and initializes var to the key in the dictionary
                votes[candidate] = 0; //sets canidates votes to 0
            }
        }
        static void Main(string[] args) //main method
        {
            int input = 0; //declares and initializes integer to 0

            while (input != 4) //while loop for as long a input does not equal 0
            {
                Console.WriteLine("Please select an option:"); //displays text to select an option
                Console.WriteLine("1. Cast a vote"); //displays option
                Console.WriteLine("2. Display results"); //displays option
                Console.WriteLine("3. Reset votes"); //displays option
                Console.WriteLine("4. exit"); //displays option
                Console.WriteLine(); //prints blank line

                input = Convert.ToInt32(Console.ReadLine()); //converts user input into input variable
                Console.WriteLine(); //prints blank line

                switch (input) //switch loop for users input
                {
                    case 1:
                        Console.WriteLine("Please enter a canidates name: "); //displays text to enter a name
                        string canidateName = Console.ReadLine(); //converts user input into string
                        Console.WriteLine(); //prints blank line
                        CastVote(canidateName); //calls CastVote method with user input
                        Console.WriteLine(); //prints blank line
                        break; //breaks from switch loop
                    case 2:
                        Console.WriteLine("Results"); //displays text
                        DisplayResults(); //calls DisplaysResults method
                        Console.WriteLine(); //prints blank line
                        break; //breaks from switch loop
                    case 3:
                        Console.WriteLine("The votes have been reset to 0."); //displays text
                        Console.WriteLine(); //prints blank line
                        ResetVotes(); //calls ResetVotes method
                        break; //breaks from switch loop
                    case 4:
                        return; //breaks from loop
                }
            }


            Console.Read(); //lets user read program
        }
    }
}
