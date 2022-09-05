using System;

namespace Full_GRASP_and_SOLID_2.Library
{
    //
    public class ConsolePrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.TextResult());
        }
    }
}