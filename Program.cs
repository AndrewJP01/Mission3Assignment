using Mission3Assignment;


        while (true)
        {
            Console.WriteLine("Welcome to the Food Bank Program!");
            Console.WriteLine("1. Add Food Items");
            Console.WriteLine("2. Delete Food Items");
            Console.WriteLine("3. Print List of Current Food Items");
            Console.WriteLine("4. Exit the Program");
            Console.Write("Type in the number of what you'd like to do: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int choice) && (choice >= 1 && choice <= 4))
            {
                Console.WriteLine($"You selected option {choice}.");

                // Perform action based on the valid choice
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the Food Name: ");
                        string fName = Console.ReadLine();

                        Console.Write("Enter the Food Category: ");
                        string fCategory = Console.ReadLine();

                        Console.Write("Enter the Food Quantity: ");
                        string fQuantity = "";

                        while (true)
                        {
                            fQuantity = Console.ReadLine();
                            if (int.TryParse(fQuantity, out int parsedQuantity) && parsedQuantity >= 0)
                            {
                                // Valid input, proceed with parsedQuantity
                                break; // Exit the loop when the input is valid
                            }
                            Console.WriteLine("Invalid quantity. Please enter a non-negative integer.");
                            Console.Write("Enter the Food Quantity: ");
                        }

                        Console.Write("Enter the Food Expiration Date: ");
                        string fExpDate = Console.ReadLine();
                        FoodItem.Food(fName, fCategory, fQuantity, fExpDate);
                        break;

                    case 2:
                        Console.WriteLine("Deleting food items...");
                        break;

                    case 3:
                        Console.WriteLine("Printing list of current food items...");
                        break;
                        
                    case 4:
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return; // Exit the program
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.\n");
            }
        }







