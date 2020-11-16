using System;
using System.Collections.Generic;

using CookBookServer.Objects;

namespace CookBookServer.Interfaces {
    public interface IRecipeRepository
    {
        /// <summary>
        /// Add the item to the repository
        /// </summary>
        /// <param name="item">Item to add</param>
        /// <returns>bool based on result of add</returns>
        bool Add(Recipe item);
        /// <summary>
        /// Gets a collection of all items
        /// </summary>
        /// <returns>IEnumerable of type T</returns>
        IEnumerable<Recipe> GetAll();
        /// <summary>
        /// Get an item from its ID in the collection.
        /// </summary>
        /// <param name="id">ID of item</param>
        /// <returns>Result of T</returns>
        Recipe GetByID(int id);
        /// <summary>
        /// Remove the given item from the collection
        /// </summary>
        /// <param name="item">Item to remove</param>
        /// <returns>Boolean based on result</returns>
        bool Remove(Recipe item);

    }
}