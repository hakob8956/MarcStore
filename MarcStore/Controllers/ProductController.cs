using MarcStore.Models;
using MarcStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
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
        public IActionResult Product(int productId,string category)
        {
            Product result = repository.Products.FirstOrDefault(i => i.ProductID == productId);

            if (result!=null && category.Equals(result.Category))
            {
                return View(result);
            }
            return NotFound();
            
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
            if (string.IsNullOrEmpty(productName))
                return View(null);

            var product = repository.Products.Where(p =>
            p.Name.ToLower().Replace(" ", string.Empty)
            .Contains(productName.ToLower()
            .Replace(" ", string.Empty))).ToList();
            if (product?.Count <= 0)
            {
                return View(null);
            }
            return View(product);


        }

    }
}
