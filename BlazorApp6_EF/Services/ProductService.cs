using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorApp6_EF.Models;
using BlazorApp6_EF.Repositories;
using BlazorApp6_EF.IRepositories;
using BlazorApp6_EF.Models;
using BlazorApp6_EF.Services;

namespace BlazorApp6_EF.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _repository;

        public OrderService(IRepository<Order> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Order>> GetOrders()
        {
            return await _repository.GetAll();
        }

        public async Task<Order> GetOrder(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task AddOrder(Order Order)
        {
            await _repository.Add(Order);
        }

        public async Task UpdateOrder(Order Order)
        {
            await _repository.Update(Order);
        }

        public async Task DeleteOrder(int id)
        {
            await _repository.Delete(id);
        }
    }
}
