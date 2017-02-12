using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotDogs.Mobile.Models;

namespace HotDogs.Mobile.Services
{
    public class StoresApiService : BaseHttpProvider, IStoresApiService
    {
        public StoresApiService()
        {
            _baseUrl = "http://192.168.1.14:3000/api/";
        }

        public async Task<List<Store>> GetAllStores()
        {
            return await Get<List<Store>>("Stores");
        }

        public async Task<Store> GetStoreById(int id)
        {
            return await Get<Store>($"Stores/{id}");
        }
    }
}
