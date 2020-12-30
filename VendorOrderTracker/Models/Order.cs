using System.Collections.Generic;


namespace VendorOrderTracker.Models
{
  public class Order
  {
    public int Id { get; }
    public string Description { get; set; }
    public float Price { get; set; }
    public string Date { get; set; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string description, float price, string date)
    {
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
    }
  }
}