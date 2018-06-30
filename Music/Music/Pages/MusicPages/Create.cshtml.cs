using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Music.Model;

namespace Music.Pages.MusicPages
{
    public class CreateModel : PageModel
    {
        private ApplicationDbContext _db;
        [TempData]
        public string afterAddMessage { get; set; }
        public string someData { get; set; }
        public CreateModel(ApplicationDbContext db)

        {
            _db = db;
        }
       
        [BindProperty]
        public Songs Song { get; set; }

        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            } else
            {
                _db.MusicItems.Add(Song);
                await _db.SaveChangesAsync();
                afterAddMessage = "New connection made!";
                return RedirectToPage("Index"); 
            }
        }
    }
}