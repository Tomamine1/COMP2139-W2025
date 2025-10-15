using System.ComponentModel.DataAnnotations;

namespace COMP2139_ICE.Area.ProjectManagement.Models;

public class ProjectTask
{
    [Key]
    public int ProjectTaskId { get; set; }
    
    [Required]
    public required string Title { get; set; }
    
    [Required] //asp.net on the webpage
    public required string Description { get; set; }
    
    public int ProjectId { get; set; }
    
    public Project? Project  { get; set; }
    
}