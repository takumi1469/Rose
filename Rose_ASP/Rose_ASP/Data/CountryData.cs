using System.ComponentModel.DataAnnotations.Schema;

namespace Rose_ASP.Data
{
    public class CountryData
    {
        public int Id { get; set; }
        public string CountryName { get; set; } = string.Empty;
        public string DataType { get; set; } = string.Empty; // "GDP", "Population"
        public int Year { get; set; }
        public decimal Value { get; set; }
    }
}
