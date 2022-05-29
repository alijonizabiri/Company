using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Data.Entities;

public class Dependent
{
    [Column("dependent_id")]
    public int DependentId { get; set; }
    [Column("first_name"),MaxLength(50),Required]
    public string? FirstName { get; set; }
    [Column("last_name"),MaxLength(50),Required]
    public string? LastName { get; set; }
    [MaxLength(25),Required]
    public string? RelationShip { get; set; }
    [Column("employee_id"),Required]
    public int EmployeeId { get; set; }
    
}