using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E7GuildWarRecorder.Database;
using E7GuildWarRecorder.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E7GuildWarRecorder.Pages.Record
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public List<Hero>? Heroes { get; set; }
        [BindProperty]
        public Match Match { get; set; }

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            Heroes = _db.Hero
                .OrderBy(hero => hero.Name)
                .ToList();
        }

        public async Task<IActionResult> OnPost()
        {
            Console.WriteLine("Hello");
            Console.WriteLine(Match.Defense1);
            await _db.Match.AddAsync(Match);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
