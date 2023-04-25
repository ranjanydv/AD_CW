using BMWMotorrad.Application.Common.Interface;
using BMWMotorrad.Application.DTOs;
using BMWMotorrad.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BMWMotorrad.Controllers;

[ApiController]
[Route("/api/v1/")]
public class UserController : ControllerBase
{
    private readonly IUserDetails _userDetails;

    public UserController(IUserDetails userDetails)
    {
        _userDetails = userDetails;
    }

    [HttpGet("user")]
    public async Task<List<User>> GetAllEmployeeDetails()
    {
        var data = await _userDetails.GetAllUserAsync();
        return data;
    }

    [HttpPost("user")]
    public async Task<User> AddUserDetails(UserRequestDTO user)
    {
        var data = await _userDetails.AddUserDetails(user);
        return data;
    }
}