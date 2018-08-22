//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.AspNetCore.Identity;

//namespace MarcStore.Models
//{
//    public class EFFavoriteRepository : IFavorite
//    {
//        private ApplicationDbContext context;

//        public EFFavoriteRepository(ApplicationDbContext context)
//        {
//            this.context = context;
//        }

//        public IEnumerable<Favorite> Favorites => context.Favorites;


//        public void SaveFavorite(Favorite favorite)
//        {
//            context.AttachRange(favorite);
//            ////context.AttachRange(order.Lines.Select(l => l.Product));
//            if (favorite.FavoriteID == 0)
//            {
//                context.Favorites.Add(favorite);
//            }
//            context.SaveChanges();
//        }
//    }
//}
