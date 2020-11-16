using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookBookServer.DTO
{
    public record RecipeStep
    {
        public RecipeStep(int id, string name, string description, string url) => 
            (ID, Name, Description, URL) = (id, name, description, url);
        /// <summary>
        /// ID of the recipe step
        /// </summary>
        public int ID { get; }
        /// <summary>
        /// The Name of the step, likely used as a title
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// The description of the step. This can be the method
        /// </summary>
        public string Description { get; }
        /// <summary>
        /// Location of the associated asset. This will likely change over time
        /// </summary>
        public string URL { get; }
    }
}
