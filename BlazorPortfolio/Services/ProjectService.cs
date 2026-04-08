using BlazorPortfolio.Models;

namespace BlazorPortfolio.Services;

public class ProjectService
{
    private readonly List<Project> _projects =
    [
        new()
        {
            ProjectId = 1,
            ProjectName = "Portfolio Web App (MVC)",
            ProjectDescription = "A personal portfolio site built with ASP.NET MVC 5, Entity Framework, and Materialize CSS. Features a projects CRUD admin panel.",
            ProjectImg = "images/coffee.jpg",
            ProjectRepo = "http://github.com/atlasaeon/portfoliowebappcsharp"
        },
        new()
        {
            ProjectId = 2,
            ProjectName = "Portfolio Web App (Blazor)",
            ProjectDescription = "A redesigned portfolio site migrated to .NET 10 Blazor Web App with interactive server-side rendering, Bootstrap 5, and Font Awesome.",
            ProjectImg = "images/jet-engine.jpg",
            ProjectRepo = "http://github.com/atlasaeon/portfoliowebappcsharp"
        }
    ];

    public IReadOnlyList<Project> GetAll() => _projects.AsReadOnly();

    public Project? GetById(int id) => _projects.FirstOrDefault(p => p.ProjectId == id);

    public void Add(Project project)
    {
        project.ProjectId = _projects.Count > 0 ? _projects.Max(p => p.ProjectId) + 1 : 1;
        _projects.Add(project);
    }

    public bool Update(Project project)
    {
        var existing = _projects.FirstOrDefault(p => p.ProjectId == project.ProjectId);
        if (existing is null) return false;
        existing.ProjectName = project.ProjectName;
        existing.ProjectDescription = project.ProjectDescription;
        existing.ProjectImg = project.ProjectImg;
        existing.ProjectRepo = project.ProjectRepo;
        return true;
    }

    public bool Delete(int id)
    {
        var project = _projects.FirstOrDefault(p => p.ProjectId == id);
        if (project is null) return false;
        _projects.Remove(project);
        return true;
    }
}
