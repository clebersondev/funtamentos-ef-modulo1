namespace BlogEF.Models;
public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string Email { get; set; } = String.Empty;
    public string PasswordHash { get; set; } = String.Empty;
    public string Bio { get; set; } = String.Empty;
    public string Image { get; set; } = String.Empty;
    public string Slug { get; set; } = String.Empty;
}