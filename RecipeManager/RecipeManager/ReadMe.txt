Recipe Manager
Recipe Manager is a command-line application written in C# that allows you to create and scale recipes.

Prerequisites
.NET 5 SDK

How to Run application on visual studio

Run the following command to start the application:

Open Visual Studio and select "Open a project or solution" from the startup menu.
Navigate to the directory where the application is located and select
 the RecipeManager.sln file to open the solution in Visual Studio.
Press F5 or select "Start Debugging" from the Debug menu to build 
and run the application.
Follow the on-screen instructions to create and scale recipes.


Usage
To add an ingredient, select option 1 from the menu and enter the ingredient name, quantity, and unit of measurement.
To add a step, select option 2 from the menu and enter a description of the step.
To scale the recipe, select option 3 from the menu and enter the scaling factor (0.5, 2, or 3).
To reset the recipe to its original state, select option 4 from the menu.
To clear the recipe and start over, select option 5 from the menu.


Notes
The recipe data is not persisted between runs and is only stored in memory while the application is running.
The ingredients and steps are stored in arrays.
The application uses the metric system for units of measurement.