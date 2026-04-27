namespace EntityFrameworkCore;

public class Order
{
    public int Id { get; set; }

    public decimal Amount { get; set; }

    // Foreign Key
    public int UserId { get; set; }

    // Navigation Property
    public User User { get; set; }
}