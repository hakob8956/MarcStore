using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcStore.Models
{
    public interface IFavorite
    {
        IEnumerable<Favorite> Favorites { get; }
        void SaveFavorite(Favorite favorite);
    }
}
