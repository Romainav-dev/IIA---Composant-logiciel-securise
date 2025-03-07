using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Components;

public class UserService
{
    private readonly ApplicationDbContext _context;

    public UserService(ApplicationDbContext context)
    {
        _context = context;
    }

    public bool Register(string username, string password)
    {
        _context.Database.ExecuteSqlRaw($"INSERT INTO Users (Username, Password) VALUES ('{username}', '{password}')");
        _context.SaveChanges();
        return true;
    }

    public User Login(string username, string password)
    {
        return _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
    }
}