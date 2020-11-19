using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JubiLarian.Models;

namespace JubiLarian.Pages.Products
{
    public class EditProductModel : PageModel
    {
        private readonly JubiLarian.Models.AppDBContext _context;

        public EditProductModel(JubiLarian.Models.AppDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Product Product { get; set; }
        public List<Producent> Producents { get; set; }
        public List<ProductType> Types { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Product.FirstOrDefaultAsync(m => m.Id == id);
            Producents = await _context.Producent.ToListAsync();
            Types = await _context.Type.ToListAsync();

            if (Product == null || Producents == null || Types == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(Product.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.Id == id);
        }
    }
}
