public class EmailService {
    public bool IsValidEmail(string email)
        => email.Contains("@") && email.Contains(".");
}