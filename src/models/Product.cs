  namespace MyApp.Models;

  public class Product
  {
      public int Id { get; set; }
      public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
  }