using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MarcStore.Models;
namespace MarcStore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IProductRepository repository;

        public NavigationMenuViewComponent(IProductRepository repository)
        {
            this.repository = repository;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View
                (
                repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x)
                );
        }

    }
}