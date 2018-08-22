using System.Collections.Generic;


namespace MarcStore.Models
{
    public interface IOrderRepository
    {
        IEnumerable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}
