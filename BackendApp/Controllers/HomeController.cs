using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BackendApp.Models;

/**
 * The main controller to handle HTTP requests and return the JSON result
 */
namespace BackendApp.Controllers
{
    [ApiController]
    [Route("/api")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Course>> Get()
        {
			return new Course[]
			{
				new Course
				{
					subject = "Strategic Management Accounting",
					results = new Result[]
					{
						new Result
						{
							year = 2015,
							grade = Result.FAIL
						},
						new Result
						{
							year = 2016,
							grade = Result.PASS
						}
					}
				},
				new Course
				{
					subject = "Financial Reporting",
					results = new Result[]
					{
						new Result
						{
							year = 2015,
							grade = Result.FAIL
						},
						new Result
						{
							year = 2016,
							grade = Result.PASS
						}
					}
				},
				new Course
				{
					subject = "Advanced Taxation",
					results = new Result[]
					{
						new Result
						{
							year = 2016,
							grade = Result.PASS
						}
					}
				},
				new Course
				{
					subject = "Financial Risk Management",
					results = new Result[]
					{
						new Result
						{
							year = 2015,
							grade = Result.PASS
						}
					}
				},
				new Course
				{
					subject = "Advanced Audit and Assurance",
					results = new Result[]
					{
						new Result
						{
							year = 2015,
							grade = Result.PASS
						}
					}
				},
			};
		}
    }
}
