namespace BlazorPortfolio.Models;

public class Project
{
    public int ProjectId { get; set; }
    public string ProjectName { get; set; } = string.Empty;
    public string ProjectDescription { get; set; } = string.Empty;
    public string ProjectImg { get; set; } = string.Empty;
    public string ProjectRepo { get; set; } = string.Empty;
}
