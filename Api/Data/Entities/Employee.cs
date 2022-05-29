using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Api.Data.Entities;

public class Employee
{
    [Column("employee_id")]
    public int EmployeeId { get; set; }
    [Column("first_name"),MaxLength(20)]
    public string? FirstName { get; set; }
    [Column("last_name"),MaxLength(25),Required]
    public string? LastName { get; set; }
    [MaxLength(100),Required]
    public string? Email { get; set; }
    [Column("phone_number"),MaxLength(20)]
    public int PhoneNumber { get; set; }
    [Column("hire_date"),Required]
    public DateTime HireDate { get; set; }
    [Column("job_id"),Required]
    public int JobId { get; set; }
    [Required]
    public decimal Salary { get; set; }
    [Column("department_id")]
    public int DepartmentId { get; set; }
}