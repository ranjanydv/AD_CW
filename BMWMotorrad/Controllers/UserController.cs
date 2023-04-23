using BMWMotorrad.Application.Common.Interface;
using BMWMotorrad.Application.DTOs;
using BMWMotorrad.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BMWMotorrad.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserDetails _userDetails;

    public UserController(IUserDetails userDetails)
    {
        _userDetails = userDetails;
    }

    [HttpGet(Name = "user")]
    public async Task<List<User>> GetAllEmployeeDetails()
    {
        var data = await _userDetails.GetAllUserAsync();
        return data;
    }

    [HttpPost(Name = "user")]
    public async Task<User> AddEmployeeDetails(UserRequestDTO user)
    {
        var data = await _userDetails.AddUserDetails(user);
        return data;
    }
}