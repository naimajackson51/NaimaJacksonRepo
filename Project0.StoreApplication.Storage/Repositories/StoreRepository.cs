using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Interfaces;
using Project0.StoreApplication.Storage.Adapters;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Storage.Repositories
{
  /// <summary>
  /// 
  /// </summary>
  public class StoreRepository : IRepository<Store>
  {
    private const string _path = @"/home/naima/revature/NaimaJacksonRepo/data/stores.xml";
    private static readonly FileAdapter _fileAdapter = new FileAdapter();

    public StoreRepository()
    {
      if (_fileAdapter.ReadFromFile<Store>(_path) == null)
      {
        _fileAdapter.WriteToFile<Store>(_path, new List<Store>());
      }
    }

    /// <summary>


    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>

    public bool Insert(Store entry)
    {
      _fileAdapter.WriteToFile<Store>(_path, new List<Store> { entry });

      return true;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public List<Store> Select()
    {
      return _fileAdapter.ReadFromFile<Store>(_path);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Store Update();

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>

    public bool Delete()
    {
      bool result = true;
      if (_fileAdapter.ReadFromFile<Customer>(_path) != null)
      {
        _fileAdapter.WriteToFile<Customer>(_path, null);
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


