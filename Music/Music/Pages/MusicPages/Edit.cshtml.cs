using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Music.Model;

namespace Music.Pages.MusicPages
{
    public class EditModel : PageModel
    {
        private ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Songs Song { set; get; }

        [TempData]
        public string afterAddMessage { set; get; }
        public void OnGet(int id)
        {
            Song = _db.MusicItems.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var connectionInDb = _db.MusicItems.Find(Song.ID);
                connectionInDb.ArtistName = connectionInDb.ArtistName;
                await _db.SaveChangesAsync();
                afterAddMessage = "List item updated successfully!";

                return RedirectToPage("Index");
            }
            else { return RedirectToPage(); }
        }
    }
}