using Microsoft.AspNetCore.Mvc;
using COMP2139_ICE.Models; 

namespace COMP2139_ICE.Controllers;

public class ProjectsController : Controller
{
    // une liste de projets (en mémoire)
    private static List<Project> projects = new List<Project>();

    public IActionResult Index()
    {
        // retourner la liste des projets
        return View(projects);
    }

    // GET: Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Create
    [HttpPost]
    public IActionResult Create(Project project)
    {
        projects.Add(project);
        return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
        // chercher le projet par son id
        var project = projects.FirstOrDefault(p => p.ProjectId == id);
        return View(project);
    }
}
