using System.Xml.Linq;
using Mission3Assignment;

// variables declared here that are used later in the progam
string fName = "";
string fCategory = "";
int fQuantity = 0;
string fExpDate = "";
int iterator = 0;
int deleteNum = 0;


while (true) //loop that keeps the program logic going until the user exits the program
        {
            Console.WriteLine("\nWelcome to the Food Bank Program!");
            Console.WriteLine("1. Add Food Items");
            Console.WriteLine("2. Delete Food Items");
            Console.WriteLine("3. Print List of Current Food Items");
            Console.WriteLine("4. Exit the Program");

            Console.Write("\nType in the number of what you'd like to do: "); 
            string userInput = Console.ReadLine();

            // error handling if statement so user inputs a valid choice
            if (int.TryParse(userInput, out int choice) && (choice >= 1 && choice <= 4))
            {
                Console.WriteLine($"You selected option {choice}.");

                // Perform action based on the valid choice
                switch (choice)
                {
                    case 1:
                        Console.Write("\nEnter the Food Name: ");
                        fName = Console.ReadLine();

                        Console.Write("\nEnter the Food Category: ");
                        fCategory = Console.ReadLine();

                        // error handling to make sure the food quantity is a valid number
                        while (true)
                        {
                            Console.Write("\nEnter the Food Quantity: ");
                            string input = Console.ReadLine(); // Get user input 

                            // Try to parse the input to an integer
                            if (int.TryParse(input, out fQuantity) && fQuantity >= 0)
                            {
                                break; // Valid input, break the loop
                    }

                            Console.WriteLine("Invalid quantity. Please enter a non-negative integer."); // If input is invalid, prompt again
                }

                    Console.Write("\nEnter the Food Expiration Date: ");
                    fExpDate = Console.ReadLine();

                    FoodItem newFoodItem = new FoodItem(fName, fCategory, fQuantity, fExpDate); // Create a new FoodItem using the constructor

                break;

                    case 2:
                
                        //if statement to make sure there are objects in the list to work with
                        if (FoodItem.GetFoodList().Count == 0)
                            {
                                Console.WriteLine("\nThere are no food items to delete\nDo something else home slice");
                                break;
                            }

                            Console.WriteLine("\nCurrent food items in the list:");
                          
                            // prints out all the food objects in the food list
                            foreach (var item in FoodItem.GetFoodList())
                            {
                                Console.WriteLine($"{iterator} Name: {item.Name}, Category: {item.Category}, Quantity: {item.Quantity}, Expiration: {item.ExpirationDate}");
                                iterator++; 
                            }
                          
                        while (true)
                        {
                            Console.WriteLine("\nPlease enter the number of the food item you would like to delete: ");

                            string input = Console.ReadLine(); // holds the input for a bit

                            // Try to parse the input to an integer
                            if (int.TryParse(input, out deleteNum))
                            {
                                // Check if the number is within the valid range (i.e., 0 <= deleteNum <= iterator)
                                if (deleteNum >= 0 && deleteNum < iterator)
                                {
                                    // Call the method to delete the food item
                                    FoodItem.deleteFoodItem(deleteNum);

                                    iterator = 0; //reset the iterator
                                    break; // Exit the loop after successful deletion
                                }
                                else
                                {
                                    Console.WriteLine($"\nPlease enter a valid number from the food list.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nInvalid input. Please enter a valid integer.");
                            }
                        }

                        break;

                    case 3:
                        //if statement to make sure there are objects in the list to work with
                        if (FoodItem.GetFoodList().Count == 0)
                            {
                                Console.WriteLine("\nThere are no food items to view\nDo something else home slice");
                                break;
                            }

                        Console.WriteLine("\nCurrent food items in the list:");

                    // prints out all the food objects in the food list
                    foreach (var item in FoodItem.GetFoodList())
                        {
                            Console.WriteLine($"\nName: {item.Name}, Category: {item.Category}, Quantity: {item.Quantity}, Expiration: {item.ExpirationDate}");
                        }
                    break;
                        
                    case 4:
                        Console.WriteLine("\nExiting the program. Goodbye!");
                        return; // Exit the program
                }
            }
            else
            {
                Console.WriteLine("\nInvalid choice. Please enter a number between 1 and 4.\n");
            }
        }







