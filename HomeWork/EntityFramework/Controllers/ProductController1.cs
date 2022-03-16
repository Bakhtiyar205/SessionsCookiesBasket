using EntityFramework.Data;
using EntityFramework.Models;
using EntityFramework.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Controllers
{
    public class ProductController1 : Controller
    {
        private readonly AppDbContext _context;
        public ProductController1(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            Settings settings = await _context.Settings.FirstOrDefaultAsync();
            ViewBag.ProductCount = _context.Products.Where(p=>p.IsDeleted == false).Count();
            List<Product> products = await _context.Products
               .Include(m => m.Category)
               .Include(m => m.Images)
               .OrderByDescending(m => m.Id)
               .Skip(1)
               .Take(settings.HomeProductTake)
               .ToListAsync();
            return View(products);
        }

        public async Task<IActionResult> LoadMore(int skip)
        {
            Settings settings = await _context.Settings.FirstOrDefaultAsync();
            List<Product> products = await _context.Products
               .Include(m => m.Category)
               .Include(m => m.Images)
               .OrderByDescending(m => m.Id)
               .Skip(skip)
               .Take(settings.LoadTable)
               .ToListAsync();

            return PartialView("_ProductsPartialView", products);
        }

        public async Task<IActionResult> AddBasket(int? id)
        {
            if (id is null) BadRequest();

            Product dbProduct = await _context.Products.FindAsync(id);

            if (dbProduct == null) return BadRequest();

            List<BasketVM> basket;

            if(Request.Cookies["basket"] != null)
            {
                basket = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
            }
            else
            {
                basket = new List<BasketVM>();
            }

            var existProduct = basket.Find(m => m.Id == dbProduct.Id);

            if(existProduct == null)
            {
            basket.Add(new BasketVM
            {
                Id = dbProduct.Id,
                Count=1
            });
            }
            else
            {
                existProduct.Count ++;
            }


            Response.Cookies.Append("basket", JsonConvert.SerializeObject(basket));

            return RedirectToAction("Index", "ProductController1");
        }

        public IActionResult Test()
        {
            return Json(JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]));
        }
    }
}
