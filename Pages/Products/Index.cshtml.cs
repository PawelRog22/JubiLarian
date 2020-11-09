using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JubiLarian.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace JubiLarian.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly AppDBContext _context;

        public IndexModel(AppDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Producent> Producents { get; set; }
        public IEnumerable<ProductType> Types { get; set; }

        public async Task OnGet()
        {
            Products = await _context.Product.ToListAsync();
            Producents = await _context.Producent.ToListAsync();
            Types = await _context.Type.ToListAsync();
        }
    }
}
