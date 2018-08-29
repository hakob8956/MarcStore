using Microsoft.AspNetCore.Mvc;
using MarcStore.Models.ViewModels;
using MarcStore.Models;

namespace MarcStore.Components
{
    public class LoginViewComponent:ViewComponent
    {


         
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
