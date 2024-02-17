using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Order.Persistence.DTO;
using System.Net;

namespace Order.WPF.Model
{
    class OrderModel : IOrderModel
    {
        private readonly HttpClient _client;
        public OrderModel(string baseAddress)
        {
           
            _client = new HttpClient { BaseAddress = new Uri(baseAddress) };
        }
        


        
        public async Task<IEnumerable<PanaszDTO>> LoadOrders()
        {
            HttpResponseMessage res = await _client.GetAsync("api/Orders/OrdersList");

            if (res.IsSuccessStatusCode)
            {
                return await res.Content.ReadAsAsync<IEnumerable<PanaszDTO>>();
            }

            throw new NetworkException("Service returned response: " + res.StatusCode);
        }
        public async Task<Boolean> SendAccomplishedOrder(PanaszDTO newData)
        {
            HttpResponseMessage response = await _client.PostAsJsonAsync("api/Orders", newData);

            return response.IsSuccessStatusCode;
        }

        
    }
}
