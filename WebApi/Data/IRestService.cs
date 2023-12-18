using System.Threading.Tasks;
using Puranu_Elena_Lab11;
using WebApi.Models;

namespace Puranu_Elena_Lab11.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
