using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Data.Entities;

public class Job
{
    [Column("job_id")]
    public int JobId { get; set; }
    [Column("job_title"),MaxLength(35),Required]
    public string? JobTitle { get; set; }
    [Column("min_salary")]
    public decimal MinSalary { get; set; }
    [Column("max_salary")]
    public decimal MaxSalary { get; set; }
}