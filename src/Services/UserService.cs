public class UserService
{
    private readonly List<UserModel> _users = new();

    public UserModel? GetById(int id)
        => _users.FirstOrDefault(u => u.Id == id);

    public List<UserModel> GetAll()
        => _users.ToList();

    public void Add(UserModel user)
        => _users.Add(user);

    public bool Delete(int id)
    {
        var user = GetById(id);
        if (user is null) return false;
        _users.Remove(user);
        return true;
    }

    public Result<OrderModel> GetOrder(int id)
    {
        var order = _orders.FirstOrDefault(o => o.Id == id);
        return order is null
            ? Result<OrderModel>.Failure("Order not found")
            : Result<OrderModel>.Success(order);
    }

    public ProductModel GetProduct(int id) {
      var product = _products.FirstOrDefault(p => p.Id == id);
      if (product is null) throw new Exception("not found"); // throws instead of Result
      return product;
  }
}