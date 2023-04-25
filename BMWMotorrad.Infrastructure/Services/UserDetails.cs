using BMWMotorrad.Application.Common.Interface;
using BMWMotorrad.Application.DTOs;
using BMWMotorrad.Domain.Entities;

namespace BMWMotorrad.Infrastructure.Services;

public class UserDetails : IUserDetails
{
    private readonly IApplicationDBContext _dbContext;

    public UserDetails(IApplicationDBContext dBContext)
    {
        _dbContext = dBContext;
    }

    public async Task<User> AddUserDetails(UserRequestDTO user)
    {
        var userDetails = new User()
        {
            Name = user.Name,
            Email = user.Email,
            Password = user.Password,
            Contact = user.Contact,
            Address = user.Address,
            // JoinDate = user.JoinDate,
            // Role = user.Role
        };
        await _dbContext.Users.AddAsync(userDetails);
        await _dbContext.SaveChangesAsync(default(CancellationToken));
        return userDetails;
    }

    public async Task<List<User>> GetAllUserAsync()
    {
        var data = _dbContext.Users.Select(e => new User()
        {
            Id = e.Id,
            Name = e.Name,
            Email = e.Email,
            Address = e.Address,
            Contact = e.Contact,
            Role = e.Role,
            JoinDate = e.JoinDate,
            Created = e.Created,
            LastModified = e.LastModified,
            LastRental = e.LastRental,
            NumOfRentals = e.NumOfRentals,
            TimesDamaged = e.TimesDamaged,
            DamageCost = e.DamageCost,
            IsEmailConfirmed = e.IsEmailConfirmed
            
        }).ToList();
        return data;
    }
    // public Task<List<User>> GetAllUserAsync()
    // {
    //     throw new NotImplementedException();
    // }
    //
    // public Task<User> AddUserDetails(UserRequestDTO user)
    // {
    //     throw new NotImplementedException();
    // }
}