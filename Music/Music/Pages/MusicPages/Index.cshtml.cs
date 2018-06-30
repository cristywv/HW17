using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Music.Model;


namespace Music.Pages.MusicPages
{
    public class IndexModel : PageModel
    {
        private ApplicationDbContext _db;
        [TempData]
        public string afterAddMessage { get; set; }
        public string someData { get; set; }
        public IndexModel(ApplicationDbContext db)

        {
            _db = db;
        }

        public IEnumerable<Songs> myConnections { get; set; }
       
        public async Task OnGetAsync()
        {
            myConnections = await _db.MusicItems.ToListAsync();
        }
        public async Task<IActionResult> OnPostDelete(int id)
        {
            var theConnection = _db.MusicItems.Find(id);
            _db.MusicItems.Remove(theConnection);
            await _db.SaveChangesAsync();
            afterAddMessage = "Deleted Successfully!";
            return RedirectToPage();

        }
    }
}