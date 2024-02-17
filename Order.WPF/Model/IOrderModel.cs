using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Order.Persistence.DTO;

namespace Order.WPF.Model
{
    public interface IOrderModel
    {
        Task<IEnumerable<PanaszDTO>> LoadOrders();
        Task<Boolean> SendAccomplishedOrder(PanaszDTO data);
    }
}
