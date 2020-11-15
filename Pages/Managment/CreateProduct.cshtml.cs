using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using JubiLarian.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace JubiLarian.Pages.Managment
{
    public class CreateProductModel : PageModel
    {
        private readonly JubiLarian.Models.AppDBContext _context;

        public CreateProductModel(JubiLarian.Models.AppDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGet()
        {
            Producents = await _context.Producent.ToListAsync();
            if(Producents == null)
            {
                return NotFound();
            }

            Types = await _context.Type.ToListAsync();
            if(Types == null)
            {
                return NotFound();
            }

            return Page();
        }

        [BindProperty]
        public Product Product { get; set; }
        public List<Producent> Producents { get; set; }
        public List<ProductType> Types { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Product.Add(Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
