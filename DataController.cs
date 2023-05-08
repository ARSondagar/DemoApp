using DemoApp.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp
{  
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly IDataService _dataService;

        public DataController(IDataService dataService)
        {
            _dataService = dataService;
        }


        [HttpPost("getCountOfTheString")]
        public async Task<int> GetCountOfTheString([FromBody] string request)
        {
            return await _dataService.GetStringCount(request);
        }

    }
}
