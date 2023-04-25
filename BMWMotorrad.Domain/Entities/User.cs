using System.ComponentModel.DataAnnotations;
using BMWMotorrad.Domain.Shared;

namespace BMWMotorrad.Domain.Entities;

public class User : BaseEntity
{
    public Guid Id { get; set; } = new Guid();
    [Required] public string Name { get; set; }
    [Required] public string Email { get; set; }
    [Required] public string Password { get; set; }

    [Required] [MaxLength(10)] public string Contact { get; set; }
    [Required] public string Address { get; set; }
    public DateTime LastRental { get; set; }
    public int NumOfRentals { get; set; } = 0;
    public int TimesDamaged { get; set; } = 0;
    public double DamageCost { get; set; } = 0.0;
    public DateTime JoinDate { get; set; } = DateTime.UtcNow;
    public UserRole Role { get; set; } = UserRole.User;
    public bool IsEmailConfirmed { get; set; } = false;
}