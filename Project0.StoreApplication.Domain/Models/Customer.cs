using System.Collections.Generic;

namespace Project0.StoreApplication.Domain.Models
{
  // this is a comment
  /// <summary>
  /// This is an XML Commnet
  /// </summary>
  public class Customer
  {
    public byte CustomerId { get; set; }
    public string Name { get; set; }
    public List<Order> Orders { get; set; }

    public Customer()
    {
      Name = "Demo User";
            Orders = new List<Order>();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return $"{Name} with {Orders.Count} Orders so far";
    }
  }
}