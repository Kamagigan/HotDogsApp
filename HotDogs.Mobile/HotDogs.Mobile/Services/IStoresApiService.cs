using HotDogs.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotDogs.Mobile.Services
{
    public interface IStoresApiService
    {
        Task<List<Store>> GetAllStores();

        Task<Store> GetStoreById(int id);
    }
}
