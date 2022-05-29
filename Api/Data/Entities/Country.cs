using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Data.Entities;

public class Country
{
    [Column("country_id")]
    public int CountryId { get; set; }
    [Column("country_name"),MaxLength(40),Required]
    public string? CountryName { get; set; }
    [Column("region_id"),Required]
    public int RegionId { get; set; }
}