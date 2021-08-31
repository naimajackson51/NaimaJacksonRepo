using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Domain.Interfaces;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{
  /// <summary>
  /// 
  /// </summary>
  public class OrderRepository : IRepository<Order>
  {
    private const string _path = @"/home/naima/revature/NaimaJacksonRepo/data/orders.xml";
    private static readonly FileAdapter _fileAdapter = new FileAdapter();



    public OrderRepository()
    {
      if (_fileAdapter.ReadFromFile<Order>(_path) == null)
      {
        _fileAdapter.WriteToFile<Order>(_path, new List<Order>());
      }
    }

    /// <summary>


    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>

    public bool Insert(Order entry)
    {
      _fileAdapter.WriteToFile<Order>(_path, new List<Order> { entry });

      return true;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public List<Order> Select()
    {
      return _fileAdapter.ReadFromFile<Order>(_path);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Order Update()
    {

    }

    public bool Delete()
    {
      bool result = true;
      if (_fileAdapter.ReadFromFile<Order>(_path) != null)
      {
        _fileAdapter.WriteToFile<Order>(_path, null);
        result = true;
      }
      else
      {
        result = false;
      }
      return result;

    }
  }
}