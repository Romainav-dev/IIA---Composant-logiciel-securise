namespace BlazorApp1.Components;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; } // Stockez les mots de passe en clair (faille)
}