using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CookBookServer.Interfaces;
using CookBookServer.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;



namespace CookBookServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipeController : ControllerBase
    {
        //DI! The Recipe repository needs to be configured
        private readonly IRecipeRepository _repository;
        private readonly ILogger<RecipeController> _logger;

        public RecipeController(ILogger<RecipeController> logger, IRecipeRepository repository)
        {
            //Configuring out DI
            _logger = logger;
            _repository = repository;
        }

        private void SeedRepo()
        {
            for(int i = 0; i < 100; i++)
            {
                var item = new Recipe
                (
                    i,
                    $"Recipe{i}",
                    new List<RecipeStep> {
                        new RecipeStep
                        (
                            0,
                            "First Recipe Step",
                            "This is a description",
                            "This is a URL"
                        ),
                        new RecipeStep
                        (
                            1,
                            "Second  Recipe Step",
                            "This is a description",
                            "This is a URL"
                        )
                    },
                    0);

                _repository.Add(item);
            }
        }

        [HttpGet]
        public IEnumerable<int> Get() => new List<int>() { 1, 2};

        [HttpGet, Route("/GetAll")]
        public IEnumerable<Recipe> GetAll() => _repository.GetAll();

        [HttpPost]
        [Route("/AddRecipe")]
        public void AddRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.Title);
            _repository.Add(recipe);
        }
    }
} 