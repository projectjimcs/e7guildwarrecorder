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
    public Dictionary<string, List<Match>> MatchesByDefenseIds { get; set; }

    public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext db)
    {
        _logger = logger;
        _db = db;
    }

    public void OnGet()
    {
        MatchesByDefenseIds = new Dictionary<string, List<Match>>();

        Matches = _db.Match.ToList();

        foreach (var match in Matches)
        {
            List<int?> defenseIds = new List<int?>();

            // !!! Needs refactoring
            if (match.Defense1Id != null)
            {
                defenseIds.Add(match.Defense1Id);
            }

            if (match.Defense2Id != null)
            {
                defenseIds.Add(match.Defense2Id);
            }

            if (match.Defense3Id != null)
            {
                defenseIds.Add(match.Defense3Id);
            }

            defenseIds.Sort();

            var defenseKey = string.Join("-", defenseIds);

            if (MatchesByDefenseIds.ContainsKey(defenseKey))
            {
                MatchesByDefenseIds[defenseKey].Add(match);
            }
            else
            {
                MatchesByDefenseIds.Add(defenseKey, new List<Match> { match });
            }
            //foreach (var defId in defenseIds)
            //{
            //    Console.WriteLine(defId);
            //}
        }

        //foreach (var mat in MatchesByDefenseIds["8-9-15"])
        //{
        //    Console.WriteLine(mat.Result);
        //}

        Console.WriteLine(MatchesByDefenseIds.Count());
    }
}

