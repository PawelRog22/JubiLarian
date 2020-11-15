using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JubiLarian.Models;
using JubiLarian.Models.Helper;
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

        public List<NewProduct> ProductList { get; set; }

        public async Task OnGet()
        {
            List<Product> products = new List<Product>();
            List<Producent> producents = new List<Producent>();
            List<NewProduct> newModelProduct = new List<NewProduct>(); 
            products = await _context.Product.ToListAsync();
            producents = await _context.Producent.ToListAsync();
            bool statusMsg;
            foreach (var element in products)
            {
                if (element.Quantity > 0)
                    statusMsg = true;
                else
                    statusMsg = false;
                newModelProduct.Add( new NewProduct
                {
                    NumerProduct = element.Id,
                    Name = element.Name,
                    Producent = producents[element.IdProducent-1].Name,
                    IsAvailable = statusMsg,
                    Price = element.Price
                });
            }
            ProductList = newModelProduct;

        }
    }
}
