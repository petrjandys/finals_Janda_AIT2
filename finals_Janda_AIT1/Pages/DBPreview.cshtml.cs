using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using finals_Janda_AIT1.Data;
using finals_Janda_AIT1.Data.Model;

namespace finals_Janda_AIT1.Pages
{
    public class DatabaseModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DatabaseModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Credit> Credits { get; set; }

        public void OnGet()
        {
            Credits = _context.Credits.ToList();
        }
    }
}
