using Microsoft.AspNetCore.Mvc;
using System.Formats.Asn1;
using System.Globalization;
using CsvHelper;
using Rose_ASP.Data;
using System.Linq;

namespace Rose_ASP.Controllers
{
    [ApiController]
    [Route("api")]
    public class DataInputController : ControllerBase
    {
        public AppDbContext _context { get; set; }
        public ILogger<DataInputController> _logger { get; set; }

        public DataInputController(AppDbContext context, ILogger<DataInputController> logger) 
        {
            _context = context;
            _logger = logger;
        }

        [HttpPost("ImportCsv")]
        public IActionResult ImportCsv(IFormFile csvFile)
        {
            using (var reader = new StreamReader(csvFile.OpenReadStream()))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<CountryData>();
                var recordList = records.ToList<CountryData>();
                Console.WriteLine(recordList[23].Value);

                foreach(CountryData data in recordList)
                {
                    _context.CountryDatas.Add(data);
                }
                _context.SaveChanges();

                return Ok(recordList);
            }
        }
    }
}
