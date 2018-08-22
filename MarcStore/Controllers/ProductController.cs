using Microsoft.AspNetCore.Mvc;
using MarcStore.Models;
using System.Linq;
using MarcStore.Models.ViewModels;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace MarcStore.Controllers
{

    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int PageSize = 4;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }
        public IActionResult Product(int productId)
        {
            Product result = repository.Products.FirstOrDefault(i => i.ProductID == productId);

            return View(result);
        }

        public ViewResult List(string category, int page = 1)
            => View(new ProductsListViewModel
            {
                Products = repository.Products
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(p => p.ProductID)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                        repository.Products.Count() :
                        repository.Products.Where(e =>
                            e.Category == category).Count()
                },
                CurrentCategory = category
            });
        public FileContentResult GetImage(int productId)
        {
            Product product = repository.Products.FirstOrDefault(p => p.ProductID == productId);
            if (product != null)
            {
                return File(product.ImageData, product.ImageMimeType);

            }
            else
            {
                return null;
            }
        }

        [HttpPost]
        public IActionResult ProductSearch(string productName)
        {            
            var product = repository.Products.Where(p => 
            p.Name.ToLower().Replace(" ",string.Empty)
            .Contains(productName.ToLower()
            .Replace(" ",string.Empty))).ToList();
            if (product.Count <=0)
            {
                return View(null);
            }
            return View(product);
        }

    }
}
