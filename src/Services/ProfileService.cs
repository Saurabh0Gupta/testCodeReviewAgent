namespace MyApp.Services;

  public class ProfileService
  {
      private readonly List<UserProfileModel> _profiles = new();

      public UserProfileModel? GetById(int id)
          => _profiles.FirstOrDefault(p => p.Id == id);

      public List<UserProfileModel> GetAll()
          => _profiles.ToList();

      public void Add(UserProfileModel profile)
          => _profiles.Add(profile);

      public bool Delete(int id)
      {
          var profile = GetById(id);
          if (profile is null) return false;
          _profiles.Remove(profile);
          return true;
      }
  }