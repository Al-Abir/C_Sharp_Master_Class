namespace EntityFrameworkCore;

public class User
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    // 1 User → Many Orders
    public List<Order> Orders { get; set; } = new();
}