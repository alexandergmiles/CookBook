using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CookBookServer.Interfaces;
using CookBookServer.Objects;

namespace CookBookServer.Repos
{
    public class RecipeRepository : IRecipeRepository
    {
        //As we're in memory right now, this is how we're storing
        private List<Recipe> items = new List<Recipe>();
        
        public bool Add(Recipe item)
        {
            items.Add(item);
            //If it's been added, great! If not, how are we here without an exception?
            return items.Contains(item);
        }

        /// <summary>
        /// Get all items in the collection
        /// </summary>
        /// <returns>Returns an Item of T</returns>
        public IEnumerable<Recipe> GetAll()
        {
            Console.WriteLine(items.Count);
            return items;
        }

        /// <summary>
        /// Gets an Item based upon it's ID
        /// </summary>
        /// <param name="id">ID (index) of the Item</param>
        /// <returns>Item of type T</returns>
        public Recipe GetByID(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Remove item from repository
        /// </summary>
        /// <param name="item">Item to remove</param>
        /// <returns>Boolean representing if the removal was successful</returns>
        public bool Remove(Recipe item)
        {
            throw new NotImplementedException();
        }
    }
}
