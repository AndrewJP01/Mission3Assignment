using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3Assignment
{
    internal class FoodItem
    {
        // Declare the foodList as a static class-level variable
        private static List<FoodItem> foodList = new List<FoodItem>();

        // Properties to store the food details
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public string ExpirationDate { get; set; }

        // Constructor to initialize the FoodItem object
        public FoodItem(string fName, string fCategory, string fQuantity, string fExpDate)
        {
            Name = fName;
            Category = fCategory;
            // Directly parse and set Quantity (assuming it is always valid)
            Quantity = int.Parse(fQuantity);
            ExpirationDate = fExpDate;
        }

        public static void Food(string fName, string fCategory, string fQuantity, string fExpDate)
        {
            // Create a new FoodItem object using the constructor and add it to the list
            FoodItem newFoodItem = new FoodItem(fName, fCategory, fQuantity, fExpDate);
            foodList.Add(newFoodItem);

        }

        public void Food(string fName) 
        { 
            foodList.Remove

        }

        public void Food()
        {

        }
    }

}
