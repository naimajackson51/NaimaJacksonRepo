using System.Collections.Generic;
using System.Xml.Serialization;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Domain.Abstracts
{
  [XmlInclude(typeof(BeautySupply))]
  [XmlInclude(typeof(Salon))]
  [XmlInclude(typeof(HairImpo))]
  public class Store
  {
    public int StoreId { get; set; }
    public string Name { get; set; }
    public List<Order> Orders { get; set; }
    public List<Product> Products { get; set; }

    public Store()
    {
      Orders = new List<Order>();
      Products = new List<Product>();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return Name;
    }
  }
}
