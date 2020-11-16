using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookBookServer.DTO
{
    public record Recipe
    {
        //Constructor
        public Recipe(int id, string title, List<RecipeStep> steps, int userID) => 
            (ID, Title, Steps, UserID) = (id, title, steps, userID);

        //DTO stuff
        /// <summary>
        /// ID of the Recipe
        /// </summary>
        public int ID { get; }
        /// <summary>
        /// Title to display
        /// </summary>
        public string Title { get; }
        /// <summary>
        /// All the steps involved in the recipe
        /// </summary>
        public List<RecipeStep> Steps { get; }
        /// <summary>
        /// Chef the recipe is associated with
        /// </summary>
        public int UserID { get; }
    }
}
