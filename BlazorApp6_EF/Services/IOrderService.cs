using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorApp6_EF.Models;

namespace BlazorApp6_EF.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetOrders();
        Task<Order> GetOrder(int id);
        Task AddOrder(Order Order);
        Task UpdateOrder(Order Order);
        Task DeleteOrder(int id);
    }
}
