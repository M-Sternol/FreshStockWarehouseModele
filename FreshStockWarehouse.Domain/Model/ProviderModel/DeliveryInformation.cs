using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Domain.Model.ProviderModel
{
    public class DeliveryInformation
    {
        public int Id { get; set; }
        public string CategoryDelivery { get; set; }
        public string DeliveryStatus { get; set; }
        public DateTime ScheduledDeliveryDate { get; set; }

        public int ProviderId { get; set; }

        public virtual Providers Providers { get; set; }

    }
}
