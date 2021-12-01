// See https://aka.ms/new-console-template for more information

namespace RPSLS
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to RPSLS C# addition!");
            Console.WriteLine("What is player one's name?: ");
            string playerOneName = Console.ReadLine();
            human playerOne = new human(playerOneName, 0, 0);

            Console.WriteLine("What is player two's name?: ");
            string playerTwoName = Console.ReadLine();
            human playerTwo = new human(playerTwoName, 0, 0);

            Console.WriteLine("Welcome " + playerOne.name + " and " + playerTwo.name);
            Console.WriteLine("Let's go over the Gestures!");
            Gesture rock = new Gesture("Rock");
            Gesture paper = new Gesture("Paper");
            Gesture scissors = new Gesture("Scissors");
            Gesture lizard = new Gesture("Lizard");
            Gesture spock = new Gesture("Spock");
            Console.WriteLine($"There are five Gestures: {rock.name}, {paper.name}, {scissors.name}, {lizard.name}, and {spock.name}");
            Console.WriteLine("Every round you will be asked to pick one.");
            Console.WriteLine("After we have both of your picks, we will compare them to display a Winner!");
            Console.WriteLine("The first player to win the best of 2 Rounds out of 3 will be declared the Champion!");
            Console.WriteLine("Lets begin!");
            int goal = 2;
            int[,] compares = new int[5, 5]{ { 0, -1, 1, 1, -1 },
                                             { 1, 0, -1, -1, 1 },
                                             { -1, 1, 0, 1, -1 },
                                             { -1, 1, -1, 0, 1 },
                                             { 1, -1, 1, -1, 0 }, };
            string[] gestures = { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            while (goal > playerOne.score & goal > playerTwo.score)
            {
                Console.WriteLine($"It {playerOne.name}'s turn!");
                Console.WriteLine("Please pick a number for the corresponding Gesture: ");
                Console.WriteLine($"1. {rock.name}");
                Console.WriteLine($"2. {paper.name}");
                Console.WriteLine($"3. {scissors.name}");
                Console.WriteLine($"4. {lizard.name}");
                Console.WriteLine($"5. {spock.name}");
                string playerOneInput = Console.ReadLine();
                int num1 = Convert.ToInt32(playerOneInput);
                playerOne.currentPick = num1 - 1;
                Console.WriteLine($"It {playerTwo.name}'s turn!");
                Console.WriteLine("Please pick a number for the corresponding Gesture: ");
                Console.WriteLine($"1. {rock.name}");
                Console.WriteLine($"2. {paper.name}");
                Console.WriteLine($"3. {scissors.name}");
                Console.WriteLine($"4. {lizard.name}");
                Console.WriteLine($"5. {spock.name}");
                string playerTwoInput = Console.ReadLine();
                int num2 = Convert.ToInt32(playerTwoInput);
                playerTwo.currentPick = num2 - 1;
                int winner = compares[num1, num2];
                if(winner == 0)
                {
                    Console.WriteLine("Looks like we have a tie!");
                }
                else if(winner == 1)
                {
                    Console.WriteLine($"{playerOne.name} has won this round with {gestures[num1 - 1]}");
                    playerOne.score += 1;
                }
                else if(winner == -1)
                {
                    Console.WriteLine($"{playerTwo.name} has won this round with {gestures[num2 - 1]}");
                    playerTwo.score += 1;
                }
            }
            string champion = "";
            if(playerOne.score > playerTwo.score)
            {
                champion = playerOne.name;
            }
            else
            {
                champion = playerTwo.name;
            }
            Console.WriteLine($"Our champion is {champion}! Thanks for playing!");
        }
    }
}

