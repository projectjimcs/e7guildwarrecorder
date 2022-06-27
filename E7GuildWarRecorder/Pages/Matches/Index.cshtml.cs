using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E7GuildWarRecorder.Database;
using E7GuildWarRecorder.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E7GuildWarRecorder.Pages.Matches
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public List<Match>? Matches { get; set; }
        public List<Hero>? Heroes { get; set; }

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet(int defense1Id)
        {
            Console.WriteLine(defense1Id);
            Heroes = _db.Hero
            .OrderBy(hero => hero.Name)
            .ToList();

            Matches = _db.Match.ToList();
        }
    }
}
