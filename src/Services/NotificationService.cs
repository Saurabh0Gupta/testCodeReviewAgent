public class NotificationService {
    public bool ValidateEmail(string email)
        => email.Contains("@") && email.Contains(".");  // same logic, different name
}