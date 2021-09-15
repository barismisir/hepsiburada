using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace hepsiburadalast.Models
{
    public class ProductList
    {
        // using System.Xml.Serialization;
        // XmlSerializer serializer = new XmlSerializer(typeof(Result));
        // using (StringReader reader = new StringReader(xml))
        // {
        //    var test = (Result)serializer.Deserialize(reader);
        // }

        [XmlRoot(ElementName = "DeactivationReasons")]
        public class DeactivationReasons
        {

            [XmlElement(ElementName = "DeactivationReason")]
            public string DeactivationReason { get; set; }
        }

        [XmlRoot(ElementName = "BuyboxOrder")]
        public class BuyboxOrder
        {

            [XmlAttribute(AttributeName = "nil")]
            public bool Nil { get; set; }
        }

        [XmlRoot(ElementName = "Listing")]
        public class Listing
        {

            [XmlElement(ElementName = "UniqueIdentifier")]
            public object UniqueIdentifier { get; set; }

            [XmlElement(ElementName = "HepsiburadaSku")]
            public string HepsiburadaSku { get; set; }

            [XmlElement(ElementName = "MerchantSku")]
            public string MerchantSku { get; set; }

            [XmlElement(ElementName = "Price")]
            public double Price { get; set; }

            [XmlElement(ElementName = "AvailableStock")]
            public int AvailableStock { get; set; }

            [XmlElement(ElementName = "DispatchTime")]
            public int DispatchTime { get; set; }

            [XmlElement(ElementName = "CargoCompany1")]
            public string CargoCompany1 { get; set; }

            [XmlElement(ElementName = "CargoCompany2")]
            public object CargoCompany2 { get; set; }

            [XmlElement(ElementName = "CargoCompany3")]
            public object CargoCompany3 { get; set; }

            [XmlElement(ElementName = "ShippingAddressLabel")]
            public string ShippingAddressLabel { get; set; }

            [XmlElement(ElementName = "ClaimAddressLabel")]
            public string ClaimAddressLabel { get; set; }

            [XmlElement(ElementName = "MaximumPurchasableQuantity")]
            public int MaximumPurchasableQuantity { get; set; }

            [XmlElement(ElementName = "MinimumPurchasableQuantity")]
            public int MinimumPurchasableQuantity { get; set; }

            [XmlElement(ElementName = "Pricings")]
            public object Pricings { get; set; }

            [XmlElement(ElementName = "IsSalable")]
            public bool IsSalable { get; set; }

            [XmlElement(ElementName = "CustomizableProperties")]
            public object CustomizableProperties { get; set; }

            [XmlElement(ElementName = "DeactivationReasons")]
            public DeactivationReasons DeactivationReasons { get; set; }

            [XmlElement(ElementName = "IsSuspended")]
            public bool IsSuspended { get; set; }

            [XmlElement(ElementName = "IsLocked")]
            public bool IsLocked { get; set; }

            [XmlElement(ElementName = "LockReasons")]
            public object LockReasons { get; set; }

            [XmlElement(ElementName = "IsFrozen")]
            public bool IsFrozen { get; set; }

            [XmlElement(ElementName = "CommissionRate")]
            public int CommissionRate { get; set; }

            [XmlElement(ElementName = "BuyboxOrder")]
            public BuyboxOrder BuyboxOrder { get; set; }

            [XmlElement(ElementName = "AvailableWarehouses")]
            public object AvailableWarehouses { get; set; }

            [XmlElement(ElementName = "IsFulfilledByHB")]
            public bool IsFulfilledByHB { get; set; }
        }

        [XmlRoot(ElementName = "Listings")]
        public class Listings
        {

            [XmlElement(ElementName = "Listing")]
            public List<Listing> Listing { get; set; }
        }

        [XmlRoot(ElementName = "Result")]
        public class Result
        {

            [XmlElement(ElementName = "TotalCount")]
            public int TotalCount { get; set; }

            [XmlElement(ElementName = "Limit")]
            public int Limit { get; set; }

            [XmlElement(ElementName = "Offset")]
            public int Offset { get; set; }

            [XmlElement(ElementName = "Listings")]
            public Listings Listings { get; set; }

            [XmlAttribute(AttributeName = "xsi")]
            public string Xsi { get; set; }

            [XmlAttribute(AttributeName = "xsd")]
            public string Xsd { get; set; }

            [XmlText]
            public string Text { get; set; }
        }


    }
}
