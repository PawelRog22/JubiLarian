using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using JubiLarian.Models;

namespace JubiLarian.Pages.Managment
{
    public class CreateProducentModel : PageModel
    {
        private readonly JubiLarian.Models.AppDBContext _context;

        public CreateProducentModel(JubiLarian.Models.AppDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Producent Producent { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Producent.Add(Producent);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
