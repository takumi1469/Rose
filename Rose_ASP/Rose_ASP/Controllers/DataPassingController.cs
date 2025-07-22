using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using Rose_ASP.Data;
using System.Globalization;
using Microsoft.EntityFrameworkCore;

namespace Rose_ASP.Controllers
{
    [ApiController]
    [Route("api")]
    public class DataPassingController : ControllerBase
    {
        public AppDbContext _context { get; set; }
        public ILogger<DataInputController> _logger { get; set; }

        public DataPassingController(AppDbContext context, ILogger<DataInputController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet("PassDataToReact")]
        public async Task<IActionResult> PassDataToReact()
        {
            List<CountryData> AllData = await _context.CountryDatas.ToListAsync();
            return Ok(AllData);
        }
    }
}
