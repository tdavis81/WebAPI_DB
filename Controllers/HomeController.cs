using Microsoft.AspNetCore.Mvc;
using WebAPI_DB.Infrastructure.DatabaseContext;
using WebAPI_DB.Infrastructure.Entities;

namespace WebAPI_DB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {

        private readonly ILogger<HomeController> _logger;
        private readonly DatabaseContext _dbContext;

        public HomeController(
            ILogger<HomeController> logger,
            DatabaseContext dbContext
        )
        {
            _dbContext = dbContext;
            _logger = logger;
        }


        /*This is a sample call here, will need to change*/
        [HttpGet(Name = "GetDataFromDB")]
        public bool Get()
        {
            List<User> userResults = _dbContext.User.ToList();

            return userResults.Count >= 0;
        }
    }
}