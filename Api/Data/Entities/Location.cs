using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Data.Entities;

public class Location
{
    [Column("location_id")]
    public int LocationId { get; set; }
    [Column("street_address"),MaxLength(35)]
    public string? StreetAddress { get; set; }
    [Column("postal_code"),MaxLength(12)]
    public string? PostalCode { get; set; }
    [MaxLength(30),Required]
    public string? City { get; set; }
    [Column("state_province"),MaxLength(25)]
    public string? StateProvince { get; set; }
    [Column("country_id"),Required]
    public int CountryId { get; set; }
}