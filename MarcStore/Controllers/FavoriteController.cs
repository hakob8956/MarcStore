//using System.Linq;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Microsoft.AspNetCore.Authorization;
//using MarcStore.Models;
//using MarcStore.Models.ViewModels;
//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using System.Threading.Tasks;

//namespace MarcStore.Controllers
//{
//    [Authorize]
//    public class FavoriteController : Controller
//    {
//        private IProductRepository _repProduc;
//        private IFavorite _repository;
//        private UserManager<User> _userManager;
//        private Favorite _favorite;
//        private List<Product> _product;
//        private ApplicationDbContext context;

//        private Task<User> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

//        public FavoriteController(IFavorite repository, IProductRepository productRepository, UserManager<User> userManager, ApplicationDbContext context)
//        {
//            _repository = repository;
//            _userManager = userManager;
//            _repProduc = productRepository;
//            this.context = context;
//        }
//        public async Task<IActionResult> Index()
//        {
//            var user = await GetCurrentUserAsync();
//            var userId = user.Id;
//            var collection = _repository.Favorites.Where(i => i.UserID == userId);

//            foreach (var item in collection)
//            {
//                var a = _repProduc.Products.Where(i => i.ProductID == item.ProductID);
//                foreach (var product in a )
//                {
//                    _product.Add(product);
//                }
//            }
//            return View(_product);

//        }
//        [HttpPost]
//        public async Task<IActionResult> AddFavorite(int productId)
//        {
//            _favorite = new Favorite();
//            var product = _repProduc.Products.FirstOrDefault(i => i.ProductID == productId);
//            var user = await GetCurrentUserAsync();
//            var userId = user?.Id;
//            if (product != null & user != null)
//            {
//                _favorite.ProductID = product.ProductID;
//                _favorite.UserID = user.Id;
//                _favorite.Loved = true;
//                context.Favorites.Add(_favorite);
//                await context.SaveChangesAsync();
//            }
//            else
//            {
//                ModelState.AddModelError("", "Error");
//            }

//            return RedirectToAction("List", "Product");
//        }
//    }
//}
