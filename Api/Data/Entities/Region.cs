using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Data.Entities;

public class Region
{
    [Column("region_id")]
    public int RegionId { get; set; }
    [Column("region_name"),MaxLength(25)]
    public string? RegionName { get; set; }
}