{
    string Rock = "Rock".ToUpper();
    string paper = "paper".ToUpper();
    string scissor = "scissor".ToUpper();

    int computerScore = 0, userScore = 0, winingScore = 3;

    Console.WriteLine("Game Started into your choice".ToUpper());

    while (userScore <= winingScore || computerScore <= winingScore)
    {
        Console.WriteLine("enter your choice:");
        Console.WriteLine("1: Rock");
        Console.WriteLine("2: paper");
        Console.WriteLine("3: scissor");

        string userchoice = Console.ReadLine();
        String computerchoice = "";

        int randomNumber = new Random().Next(1, 3);

        switch (randomNumber)
        {
            case 1:
                computerchoice = Rock;
                break;
            case 2:
                computerchoice = paper;
                break;
            case 3:
                computerchoice = scissor;
                break;
        }
        if (userchoice != "1" && userchoice != "2" && userchoice != "3")
            Console.WriteLine("please enter a number between 1 to 3");

        else
        {
            switch (userchoice)
            {
                case "1":
                    userchoice = Rock;
                    break;
                case "2":
                    userchoice = paper;
                    break;
                case "3":
                    userchoice = scissor;
                    break;

            }
            Console.WriteLine("computer selected :" + computerchoice);
            Console.WriteLine("your choice was :" + userchoice);

            if (computerchoice == userchoice)
            {
                Console.WriteLine("Draw!");
            }
            else if (computerchoice == Rock && userchoice == scissor)
            {
                computerScore += computerScore + 1;
            }
            else if (computerchoice == Rock && userchoice == paper)
            {
                userScore += +1;
            }
            else if (computerchoice == scissor && userchoice == paper)
            {
                computerScore += 1;

            }
            else if (computerchoice == scissor && userchoice == Rock)
            {
                userScore += 1;
            }
            else if (computerchoice == paper && userchoice == Rock)
            {
                computerScore += 1;
            }
            else if (computerchoice == paper && userchoice == scissor)
            {

                userScore += 1;
                Console.BackgroundColor = ConsoleColor.Green;
                if (userScore > computerScore)
                    Console.WriteLine("you won the GAMEEEE!!");
                else
                    Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Red;

                Console.WriteLine(" \n Loser!");
                Console.ResetColor();
            }

        }

    }
    Console.ReadKey();
}




