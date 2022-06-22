using E7GuildWarRecorder.Database;
using E7GuildWarRecorder.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace E7GuildWarRecorder.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly ApplicationDbContext _db;
    public List<Match>? Matches { get; set; }

    public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext db)
    {
        _logger = logger;
        _db = db;
    }

    public void OnGet()
    {
        Matches = _db.match.ToList();

        foreach (var match in Matches)
        {
            if (match.Offense1 != null)
            {
                Console.WriteLine(match.Offense1.Name);
            } else
            {
                Console.WriteLine("Did not work");
            }
        }
    }
}

