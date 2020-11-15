using System;
using System.Collections.Generic;
using CookBookServer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CookBookServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipeController : ControllerBase
    {
        private IRepository repository { get; init; }
        private List<int> items { get; init; }
        private readonly ILogger<RecipeController> _logger;

        public RecipeController(ILogger<RecipeController> logger)
        {
            _logger = logger;
            repository = new MySQL();
        }

        [HttpGet]
        public IEnumerable<int> Get() => new List<int>() { 1, 2};
    }
}