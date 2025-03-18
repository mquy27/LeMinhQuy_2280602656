using LeMinhQuy_2280602656_Tuan03.Models;

namespace LeMinhQuy_2280602656_Tuan03.Repository
{
    public interface IHomeRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
    }
}
