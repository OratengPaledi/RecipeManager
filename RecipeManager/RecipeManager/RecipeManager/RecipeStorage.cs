using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    public class RecipeStorage
    {
        //Declaring Private Methods
        private IngredientStorage[] ingredients;
        private Step[] steps;

        //Get Ingredients From User Method
        public void GetIngredientsFromUser()
        {
            Console.Write("Enter the number of ingredients: ");
            int numOfIngredients = int.Parse(Console.ReadLine());

            ingredients = new IngredientStorage[numOfIngredients];

            for (int i = 0; i < numOfIngredients; i++)
            {
                Console.Write($"Enter the name of ingredient #{i + 1}: ");
                string name = Console.ReadLine();

                Console.Write($"Enter the quantity of {name}: ");
                double quantity = double.Parse(Console.ReadLine());

                Console.Write($"Enter the unit of measurement for {name}: ");
                string unit = Console.ReadLine();

                ingredients[i] = new IngredientStorage { Name = name, Quantity = quantity, Unit = unit };
            }
        }

        //Get Steps From User Method
        public void GetStepsFromUser()
        {
            Console.Write("Enter the number of steps: ");
            int numOfSteps = int.Parse(Console.ReadLine());

            steps = new Step[numOfSteps];

            for (int i = 0; i < numOfSteps; i++)
            {
                Console.Write($"Enter step #{i + 1}: ");
                string description = Console.ReadLine();

                steps[i] = new Step { Description = description };
            }
        }

        //Display Recipe Method
        public void DisplayRecipe()
        {
            Console.WriteLine("**********************\nIngredients:\n**********************");
            foreach (IngredientStorage ingredient in ingredients)
            {
                Console.WriteLine($"{ingredient.Name} - {ingredient.Quantity} {ingredient.Unit}");
            }

            Console.WriteLine("\n**********************\nSteps:\n**********************");
            foreach (Step step in steps)
            {
                Console.WriteLine(step.Description);
            }
            Console.WriteLine("\n * *********************");
        }

        //Scale Recipe Method
        public void ScaleRecipe(double scaleFactor)
        {
            Console.WriteLine($"\nScaling recipe by a factor of {scaleFactor}...\n");

            foreach (IngredientStorage ingredient in ingredients)
            {
                ingredient.Quantity *= scaleFactor;
            }
        }


        //Reset Quantities Method
        public void ResetQuantities()
        {
            Console.WriteLine("\nResetting quantities to original values...\n");

            // assuming original quantities were all 1
            foreach (IngredientStorage ingredient in ingredients)
            {
                ingredient.Quantity /= ingredient.Quantity;
            }
        }

        //Clear Recipe Method
        public void ClearRecipe()
        {
            Console.WriteLine("\nClearing recipe...\n");

            ingredients = null;
            steps = null;
        }
    }
}
