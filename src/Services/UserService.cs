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
  }