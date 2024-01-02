using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using finals_Janda_AIT1.Data.Model;
using finals_Janda_AIT1.Data;

namespace finals_Janda_AIT1.Pages
{
    public class CreditsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public Credit Credit { get; set; }

        public CreditsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }                       
            Credit.Created = DateTime.Now;

            _context.Credits.Add(Credit);
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Successfully added to DB";

            return RedirectToPage("./Credits");
        }
    }
}
