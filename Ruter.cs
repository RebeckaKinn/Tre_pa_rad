namespace Tre_på_rad
{
    public class Ruter
    {
        public string One = "1";
        public string Two = "2";
        public string Three = "3";
        public string Four = "4";
        public string Five = "5";
        public string Six = "6";
        public string Seven = "7";
        public string Eight = "8";
        public string Nine = "9";

        public bool Player = true;

        public Ruter()
        {
            PrintBoard();
        }

        public void PrintBoard()
        {
            Console.Clear();
            string PlayerName = GetCurrentPlayerName();
            Console.WriteLine("Press the number of the square you want to choose.\n");
            Console.WriteLine($"{PlayerName}\n");
            Console.WriteLine($"| {One} | {Two} | {Three} |");
            Console.WriteLine($"-------------");
            Console.WriteLine($"| {Four} | {Five} | {Six} |");
            Console.WriteLine($"-------------");
            Console.WriteLine($"| {Seven} | {Eight} | {Nine} |");

            CheckInput();
        }

        public string GetCurrentPlayerName()
        {
            if (Player)
            {
                return "Player X's turn";
            }
            else
            {
                return "Player O's turn";
            }
        }

        public void CheckInput()
        {
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    CheckBoard(One);
                    break;
                case "2":
                    CheckBoard(Two);
                    break;
                case "3":
                    CheckBoard(Three);
                    break;
                case "4":
                    CheckBoard(Four);
                    break;
                case "5":
                    CheckBoard(Five);
                    break;
                case "6":
                    CheckBoard(Six);
                    break;
                case "7":
                    CheckBoard(Seven);
                    break;
                case "8":
                    CheckBoard(Eight);
                    break;
                case "9":
                    CheckBoard(Nine);
                    break;
                default:
                    Console.WriteLine("Invalid input, write a number between 1-9...");
                    Thread.Sleep(2000);
                    PrintBoard();
                    break;
            }
        }

        public void CheckBoard(string square)
        {
            if (square == "O" || square == "X")
            {
                Console.WriteLine("The square is occupied, try another...");
                Thread.Sleep(2000);
                PrintBoard();
            }
            else
            {
                Update(square);
                PrintBoard();
            }
        }

        public void Update(string square)
        {
            var newValue = CurrentPlayerInput();

            switch (square)
            {
                case "1":
                    One = newValue;
                    break;
                case "2":
                    Two = newValue;
                    break;
                case "3":
                    Three = newValue;
                    break;
                case "4":
                    Four = newValue;
                    break;
                case "5":
                    Five = newValue;
                    break;
                case "6":
                    Six = newValue;
                    break;
                case "7":
                    Seven = newValue;
                    break;
                case "8":
                    Eight = newValue;
                    break;
                case "9":
                    Nine = newValue;
                    break;
            }
            CheckValues();
        }

        public bool ChangePlayersTurn()
        {
            Player = !Player;
            return Player;
        }

        public string CurrentPlayerInput()
        {
            if (Player)
            {
                return "X";
            }
            else
            {
                return "O";
            }
        }

        public void CheckValues()
        {
            var playerValue = CurrentPlayerInput();
            if (One == playerValue && Two == playerValue && Three == playerValue) Winner(playerValue);
            else if (Four == playerValue && Five == playerValue && Six == playerValue) Winner(playerValue);
            else if (Seven == playerValue && Eight == playerValue && Nine == playerValue) Winner(playerValue);
            else if (One == playerValue && Four == playerValue && Seven == playerValue) Winner(playerValue);
            else if (Two == playerValue && Five == playerValue && Eight == playerValue) Winner(playerValue);
            else if (Three == playerValue && Six == playerValue && Nine == playerValue) Winner(playerValue);
            else if (One == playerValue && Five == playerValue && Nine == playerValue) Winner(playerValue);
            else if (Three == playerValue && Five == playerValue && Seven == playerValue) Winner(playerValue);
            else { ChangePlayersTurn(); }
        }

        public void Winner(string winningPlayer)
        {
            Console.WriteLine($"Congratulations Player {winningPlayer}!");
            Console.WriteLine("Press anything to play again.");
            Console.ReadLine();
            ResetBoard();
            PrintBoard();
        }

        public void ResetBoard()
        {
            One = "1";
            Two = "2";
            Three = "3";
            Four = "4";
            Five = "5";
            Six = "6";
            Seven = "7";
            Eight = "8";
            Nine = "9";
        }
    }
    // Hvis hele boarded er fullt, så lag en if hvis hele boarded er fylt, men ikke noen har vunnet. 
}
