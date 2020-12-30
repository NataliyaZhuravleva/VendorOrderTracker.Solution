using System.Collections.Generic;


namespace VendorOrderTracker.Models
{
  public class Order
  {
    public int Id { get; }
    public string Title { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
    public string Date { get; set; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string title, string description, float price, string date)
    {
      Title = Title;
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

  }
}