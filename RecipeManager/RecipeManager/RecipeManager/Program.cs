using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{

    class Program
    {
        static void Main(string[] args)
        {
            //Declaring and assigning
            RecipeStorage recipe = new RecipeStorage();

            Console.WriteLine("Welcome to RecipeApp!");
            Console.WriteLine("Please select an option:\n");

            int selection = 0;

            //While and switch 
            while (selection != 5)

            {
                Console.WriteLine("1 - Enter recipe details");
                Console.WriteLine("2 - Display recipe");
                Console.WriteLine("3 - Scale recipe");
                Console.WriteLine("4 - Reset quantities");
                Console.WriteLine("5 - Clear recipe and exit");

                Console.Write("\nEnter selection (1-5): ");
                selection = int.Parse(Console.ReadLine());
                //
                switch (selection)
                {
                    case 1:
                        recipe.GetIngredientsFromUser();
                        recipe.GetStepsFromUser();
                        break;
                    case 2:
                        recipe.DisplayRecipe();
                        break;
                    case 3:
                        Console.Write("Enter scale factor (0.5, 2, or 3): ");
                        double scaleFactor = double.Parse(Console.ReadLine());
                        recipe.ScaleRecipe(scaleFactor);
                        break;
                    case 4: // Reset the recipe
                        recipe.ResetQuantities();
                        Console.WriteLine("Recipe has been reset.");
                        break;
                    case 5:
                        recipe.ClearRecipe();
                        break;
                }
            }
        }
    }
}
                