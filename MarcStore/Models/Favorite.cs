using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MarcStore.Models
{
    public class Favorite
    {
        [Key]
        public int FavoriteID { get; set; }
        
        public  int ProductID{ get; set; }
        public string UserID { get; set; }
        public bool Loved { get; set; }

    }
}
