using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3Assignment
{
    internal class FoodItem
    {
        // Declare the foodList that foodItem object will be stored in
        private static List<FoodItem> foodList = new List<FoodItem>();

        // Properties to store the food details
        public  string Name { get; set; }
        public  string Category { get; set; }
        public  int Quantity { get; set; }
        public  string ExpirationDate { get; set; }

        // contructor for foodItem objects
         public FoodItem(string name, string category, int quantity, string expirationDate)
        {
            Name = name;
            Category = category;
            Quantity = quantity;
            ExpirationDate = expirationDate;

            // Add the new object to the foodList
            foodList.Add(this);
        }

        // Method that retrieves all items in the foodList
        public static List<FoodItem> GetFoodList()
        {
            return foodList;
        }
        
        // this method deletes a food item based on the number the user inputs:
        public static void deleteFoodItem(int number)
        {
            foodList.RemoveAt(number);
            Console.WriteLine($"Food item number {number} was deleted bruv"); 
        }
    }

}
