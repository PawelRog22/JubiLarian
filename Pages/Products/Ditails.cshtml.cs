using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JubiLarian.Models;
using JubiLarian.Models.Helper;

namespace JubiLarian.Pages.Products
{
    public class DitalsModel : PageModel
    {
        private readonly JubiLarian.Models.AppDBContext _context;

        public DitalsModel(JubiLarian.Models.AppDBContext context)
        {
            _context = context;
        }

        public AllDetailsInfo ProductDitails { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product product = await _context.Product.FirstOrDefaultAsync(p => p.Id == id);
            ProductType type = await _context.Type.FirstOrDefaultAsync(t => t.Id == product.IdType);
            Producent producent = await _context.Producent.FirstOrDefaultAsync(p => p.Id == product.IdProducent);

            if (product == null)
                return NotFound();
            if (type == null)
                return NotFound();
            if (producent == null)
                return NotFound();

            ProductDitails = new AllDetailsInfo()
            {
                ProductNumber = product.Id,
                ProductName = product.Name,
                TypeProduct = type.Name,
                Description = product.Description,
                Destinayion = type.Destiny,
                Producent = producent.Name,
                Address = producent.Address,
                Quantity = product.Quantity,
                Price = product.Price
            };


            return Page();
        }
    }
}
