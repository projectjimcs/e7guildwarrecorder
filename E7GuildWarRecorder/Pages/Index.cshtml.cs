using E7GuildWarRecorder.Database;
using E7GuildWarRecorder.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace E7GuildWarRecorder.Pages;

public class IndexModel : PageModel
{
    const int withinDays = -30;
    const int maxMatchesToShow = 10;

    private readonly ILogger<IndexModel> _logger;
    private readonly ApplicationDbContext _db;
    public List<Match>? Matches { get; set; }
    public Dictionary<string, List<Match>> MatchesByDefenseIds { get; set; }
    public Dictionary<string, Dictionary<string, float>> MatchStatsByIds { get; set; }
    public Dictionary<string, Match> DisplayedMatches { get; set; }

    public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext db)
    {
        _logger = logger;
        _db = db;
    }

    public void OnGet()
    {
        // !!! Think I did server side here but client side on the matches page, might refactor for consistency later
        // !!! Ideally don't need to maintain two lists, probably come back to this
        MatchesByDefenseIds = new Dictionary<string, List<Match>>();
        MatchStatsByIds = new Dictionary<string, Dictionary<string, float>>();
        DisplayedMatches = new Dictionary<string, Match>();

        Matches = _db.Match.Where(m => m.CreatedAt >= DateTime.UtcNow.AddDays(withinDays)).ToList();

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

            string defenseKey = string.Join("-", defenseIds);

            if (MatchesByDefenseIds.ContainsKey(defenseKey))
            {
                MatchesByDefenseIds[defenseKey].Add(match);
            }
            else
            {
                MatchesByDefenseIds.Add(defenseKey, new List<Match> { match });
            }
        }

        foreach (var matchArray in MatchesByDefenseIds)
        {
            float wonCount = 0;
            float lostCount = 0;
            float totalMatches = 0;
            float winRate;

            foreach (var match in matchArray.Value)
            {
                if (match.Result == "lost")
                {
                    lostCount++;
                }
                else
                {
                    wonCount++;
                }

                totalMatches++;
            }

            winRate = (wonCount / totalMatches) * 100;

            MatchStatsByIds.Add(matchArray.Key, new Dictionary<string, float>());
            MatchStatsByIds[matchArray.Key].Add("won", wonCount);
            MatchStatsByIds[matchArray.Key].Add("lost", lostCount);
            MatchStatsByIds[matchArray.Key].Add("rate", winRate);
        }

        float currentLowestWinRate = 100;
        Dictionary<string, float> DisplayedMatchesRateTracker = new Dictionary<string, float>();

        foreach (var stats in MatchStatsByIds)
        {
            if (DisplayedMatches.Count() < maxMatchesToShow)
            {
                DisplayedMatches.Add(stats.Key, MatchesByDefenseIds[stats.Key].First());
                DisplayedMatchesRateTracker.Add(stats.Key, stats.Value["rate"]);

                if (stats.Value["rate"] <= currentLowestWinRate)
                {
                    currentLowestWinRate = stats.Value["rate"];
                }
            }
            else
            {
                if (stats.Value["rate"] > currentLowestWinRate)
                {
                    DisplayedMatchesRateTracker = DisplayedMatchesRateTracker.OrderBy(key => key.Value)
                        .ToDictionary(pair => pair.Key, pair => pair.Value);

                    DisplayedMatches.Remove(DisplayedMatchesRateTracker.First().Key);
                    DisplayedMatchesRateTracker.Remove(DisplayedMatchesRateTracker.Keys.First());

                    DisplayedMatches.Add(stats.Key, MatchesByDefenseIds[stats.Key].First());
                    DisplayedMatchesRateTracker.Add(stats.Key, stats.Value["rate"]);

                    currentLowestWinRate = DisplayedMatchesRateTracker.OrderBy(key => key.Value)
                        .ToDictionary(pair => pair.Key, pair => pair.Value).First().Value;
                }
            }
        }
    }
}

