using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookBookServer.Objects
{
    public class Recipe
    {
        //Constructor
        public Recipe(int id, string title, List<RecipeStep> steps, int userID) =>
            (ID, Title, Steps, UserID) = (id, title, steps, userID);

        //DTO stuff
        /// <summary>
        /// ID of the Recipe
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Title to display
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// All the steps involved in the recipe
        /// </summary>
        public List<RecipeStep> Steps { get; set; }
        /// <summary>
        /// Chef the recipe is associated with
        /// </summary>
        public int UserID { get; set; }
    }
}
