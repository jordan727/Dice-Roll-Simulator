// Dice Roll Simulator by Jordan A
#nullable disable
Console.Clear();

// Create random object
Random rnd = new Random();
bool loop = true;

// Welcome
Console.WriteLine("Welcome to the Dice Roll Simulator");

while (loop) {
    Console.WriteLine("\nDice Roll Simulator Menu");
    Console.WriteLine("1. Roll Dice Once");
    Console.WriteLine("2. Roll Dice 5 Times");
    Console.WriteLine("3. Roll Dice 'n' Times");
    Console.WriteLine("4. Roll Dice until Snake Eyes");
    Console.WriteLine("5. Exit");
    Console.Write("Select an option (1-5): ");
    string option = Console.ReadLine();

        
    if (option == "1") {
        int diceOne = rnd.Next(1, 7);
        int diceTwo = rnd.Next(1, 7);
        int sum = diceOne + diceTwo;
        Console.WriteLine($"{diceOne},{diceTwo} (sum: {sum})");    
    } else if (option == "2") {
        for (int n = 1; n <= 5; n++) {
            int diceOne = rnd.Next(1, 7);
            int diceTwo = rnd.Next(1, 7);
            int sum = diceOne + diceTwo;
            Console.WriteLine($"{diceOne},{diceTwo} (sum: {sum})");
        }
    } else if (option == "3") {
        Console.Write("How many rolls would you like? ");
        int amountRolls = Convert.ToInt32(Console.ReadLine());
        for (int n = 1; n <= amountRolls; n++) {
            int diceOne = rnd.Next(1, 7);
            int diceTwo = rnd.Next(1, 7);
            int sum = diceOne + diceTwo;
            Console.WriteLine($"{diceOne},{diceTwo} (sum: {sum})");
        }
    } else if (option == "4") {  
        int rolls = 0; 
        bool snakeEyeLoop = true;
        while (snakeEyeLoop) {
            int diceOne = rnd.Next(1, 7);
            int diceTwo = rnd.Next(1, 7);
            int sum = diceOne + diceTwo;
            Console.WriteLine($"{diceOne},{diceTwo} (sum: {sum})");
            rolls++;
            if (sum == 2) {
                snakeEyeLoop = false;
                Console.WriteLine($"SNAKE EYES! It took {rolls} rolls to get snake eyes.");
            }
        }
    } else if (option == "5") {
        Console.WriteLine("Goodbye");
        loop = false;
    } else {
        Console.WriteLine("Invalid Number");
    }
}