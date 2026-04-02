  namespace MyApp.Models;

  public class OrderModel
  {
      public int Id { get; set; }
      public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
  }