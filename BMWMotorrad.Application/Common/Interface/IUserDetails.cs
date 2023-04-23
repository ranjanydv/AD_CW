using BMWMotorrad.Application.DTOs;
using BMWMotorrad.Domain.Entities;

namespace BMWMotorrad.Application.Common.Interface;

public interface IUserDetails
{
    Task<List<User>> GetAllUserAsync();
    Task<User> AddUserDetails(UserRequestDTO user);
}