using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hepsiburadalast.Models
{
    public class ProductModel
    {
        public string image { get; set; }
        public string name { get; set; }
        public string uniqueIdentifier { get; set; }
        public string hepsiburadaSku { get; set; }
        public string merchantSku { get; set; }
        public double price { get; set; }
        public int availableStock { get; set; }
        public int dispatchTime { get; set; }
        public string cargoCompany1 { get; set; }
        public string cargoCompany2 { get; set; }
        public string cargoCompany3 { get; set; }
        public string shippingAddressLabel { get; set; }
        public string claimAddressLabel { get; set; }
        public int maximumPurchasableQuantity { get; set; }
        public int minimumPurchasableQuantity { get; set; }
        public List<object> pricings { get; set; }
        public bool isSalable { get; set; }
        public List<CustomizableProperty> customizableProperties { get; set; }
        public List<string> deactivationReasons { get; set; }
        public bool isSuspended { get; set; }
        public bool isLocked { get; set; }
        public List<object> lockReasons { get; set; }
        public bool isFrozen { get; set; }
        public double commissionRate { get; set; }
        public object buyboxOrder { get; set; }
        public List<object> availableWarehouses { get; set; }
        public bool isFulfilledByHB { get; set; }
    }
    public class CustomizableProperty
    {
        public string displayName { get; set; }
        public int displayLength { get; set; }
        public string displayDescription { get; set; }
    }
    public class HBProductList
    {
        public List<ProductModel> listings { get; set; }
        public int totalCount { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }

    }


    public class ProductModelTest1
    {
        public string name { get; set; }
        public string image { get; set; }
        public string hepsiburadaSku { get; set; }

    }

    public class ProductModelTest2
    {
        public string hepsiburadaSku { get; set; }
        public string cargoCompany1 { get; set; }
        public double price { get; set; }
        public int availableStock { get; set; }
    }
}
