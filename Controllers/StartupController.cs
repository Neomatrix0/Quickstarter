using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

public class StartupController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly ILogger<StartupController> _logger;

    // Constructor with ILogger to handle logging
    public StartupController(ApplicationDbContext context, ILogger<StartupController> logger)
    {
        _context = context;
        _logger = logger;
    }

    // GET: Startup/CreateStartup
    [HttpGet]
    public IActionResult CreateStartup()
    {
        return View();
    }

    // POST: Startup/CreateStartup
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> CreateStartup(ProjectStartup project)
    {
        if (ModelState.IsValid)
        {
            _context.Projects.Add(project);
            await _context.SaveChangesAsync();

            // Log a message confirming the creation of the project in the console
            _logger.LogInformation($"Project {project.CompanyName} created successfully at {DateTime.Now}.");
            
            // Output message to console
            Console.WriteLine($"Project {project.CompanyName} created successfully at {DateTime.Now}.");

            return RedirectToAction("Index","Home");
        }

        return View(project);
    }

    // Index Action to display SuccessMessage
    public IActionResult Index()
    {
        return View();
    }
}
