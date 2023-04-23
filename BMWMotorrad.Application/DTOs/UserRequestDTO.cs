using BMWMotorrad.Domain.Shared;

namespace BMWMotorrad.Application.DTOs;

public class UserRequestDTO
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Contact { get; set; }
    public string Address { get; set; }
    public DateTime JoinDate { get; set; }
    public UserRole Role { get; set; }
}