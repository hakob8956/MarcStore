using MarcStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using System.Web;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Text.RegularExpressions;
using System;

namespace MarcStore.Controllers
{

    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private IProductRepository repository;
        public const int ImageMinimumBytes = 512;

        public AdminController(IProductRepository repository)
        {
            this.repository = repository;
        }
        public ViewResult Index() => View(repository.Products);
        public ViewResult Edit(int productId) =>
            View(repository.Products.FirstOrDefault(p => p.ProductID == productId));

        public static bool IsImage(IFormFile postedFile)
        {

            //-------------------------------------------
            //  Check the image mime types
            //-------------------------------------------
            if (postedFile.ContentType.ToLower() != "image/jpg" &&
                        postedFile.ContentType.ToLower() != "image/jpeg" &&
                        postedFile.ContentType.ToLower() != "image/pjpeg" &&
                        postedFile.ContentType.ToLower() != "image/gif" &&
                        postedFile.ContentType.ToLower() != "image/x-png" &&
                        postedFile.ContentType.ToLower() != "image/png")
            {
                return false;
            }

            //-------------------------------------------
            //  Check the image extension
            //-------------------------------------------
            if (Path.GetExtension(postedFile.FileName).ToLower() != ".jpg"
                && Path.GetExtension(postedFile.FileName).ToLower() != ".png"
                && Path.GetExtension(postedFile.FileName).ToLower() != ".gif"
                && Path.GetExtension(postedFile.FileName).ToLower() != ".jpeg")
            {
                return false;
            }

            //-------------------------------------------
            //  Attempt to read the file and check the first bytes
            //-------------------------------------------
            try
            {
                if (!postedFile.OpenReadStream().CanRead)
                {
                    return false;
                }

                if (postedFile.Length < ImageMinimumBytes)
                {
                    return false;
                }

                byte[] buffer = new byte[512];
                postedFile.OpenReadStream().Read(buffer, 0, 512);
                string content = System.Text.Encoding.UTF8.GetString(buffer);
                if (Regex.IsMatch(content, @"<script|<html|<head|<title|<body|<pre|<table|<a\s+href|<img|<plaintext|<cross\-domain\-policy",
                    RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Multiline))
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        [HttpPost]
        public IActionResult DeleteImage(int productId)
        {
            Product product = repository.Products.FirstOrDefault(i => i.ProductID == productId);
            if (product != null)
            {
                product.ImageData = null;
                product.ImageMimeType = null;
                repository.SaveProduct(product);
            }
            return View("Edit",productId);
        }
        [HttpPost]
        public IActionResult Edit(Product product, IFormFile image = null)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    if (IsImage(image))
                    {
                        product.ImageMimeType = image.ContentType;
                        product.ImageData = new byte[image.Length];
                        image.OpenReadStream().Read(product.ImageData, 0, (int)image.Length);
                    }
                    else
                    {
                        TempData["error"] = $"It's not image";
                        return View(product);
                    }

                }
                repository.SaveProduct(product);
                TempData["message"] = $"{product.Name} has been saved";
                return RedirectToAction("Index");
            }
            else
            {
                return View(product);
            }
        }

        public IActionResult Menu() => View();
        public ViewResult Create() => View("Edit", new Product());

        [HttpPost]
        public IActionResult Delete(int productId)
        {
            Product deletedProduct = repository.DeleteProduct(productId);
            if (deletedProduct != null)
                TempData["message"] = $"{ deletedProduct.Name} was deleted";
            else
                TempData["message"] = $"{ deletedProduct.Name} was'nt deleted";

            return RedirectToAction("Index");
        }
    }
}
