using FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseDeliveryModel;
using FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseManagementModel;
using FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseOrderModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Domain.Model.ProviderModel
{
    public class Providers
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FormalTitle { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsActive { get; set; }

        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }

        public ICollection<DeliveryInformation> DeliveryInformation { get; set; }
        public ProviderContactInformation ProviderContactInformation { get; set; }
        public virtual ProviderInformation ProviderInformation { get; set; }
        public virtual ICollection<CompanyAddress> CompanyAddresses { get; set; }

        public virtual ICollection<DeliveryCompany> DeliveryCompanies { get; set; }

        public virtual ICollection<ProviderOrderHistory> OrderHistories { get; set; }
    }
}
