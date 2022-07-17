using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E7GuildWarRecorder.Database;
using E7GuildWarRecorder.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace E7GuildWarRecorder.Pages.Matches
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public List<Match>? Matches { get; set; }
        public List<Hero>? Heroes { get; set; }
        [BindProperty(SupportsGet = true)]
        public int Defense1Id { get; set; }
        [BindProperty(SupportsGet = true)]
        public int Defense2Id { get; set; }
        [BindProperty(SupportsGet = true)]
        public int Defense3Id { get; set; }

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            Heroes = _db.Hero
            .OrderBy(hero => hero.Name)
            .ToList();

            IQueryable<Match> query = _db.Match.Select(m => m);

            // !!! Refactor
            if (Defense1Id != 0)
            {
                query = query.Where(m => Defense1Id == m.Defense1Id || Defense1Id == m.Defense2Id || Defense1Id == m.Defense3Id);
            }

            if (Defense2Id != 0)
            {
                query = query.Where(m => Defense2Id == m.Defense1Id || Defense2Id == m.Defense2Id || Defense2Id == m.Defense3Id);
            }

            if (Defense3Id != 0)
            {
                query = query.Where(m => Defense3Id == m.Defense1Id || Defense3Id == m.Defense2Id || Defense3Id == m.Defense3Id);
            }

            Matches = query
                .OrderByDescending(Match => Match.CreatedAt)
                .ToList();
        }
    }
}
