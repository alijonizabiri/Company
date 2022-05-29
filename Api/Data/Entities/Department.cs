using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Data.Entities;

public class Department
{
    [Column("department_id")]
    public int DepartmentId { get; set; }
    [Column("department_name"),MaxLength(30),Required]
    public string? DepartmentName { get; set; }
    [Column("location_id")]
    public int LocationId { get; set; }
}