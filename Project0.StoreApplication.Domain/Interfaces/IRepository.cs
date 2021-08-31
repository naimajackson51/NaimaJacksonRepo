using System.Collections.Generic;

namespace Project0.StoreApplication.Domain.Interfaces
{
  /// <summary>
  /// 
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public interface IRepository<T> where T : class
  {
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    bool Delete();

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public bool Insert(T entry);

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public List<T> Select();

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    T Update();
  }
}