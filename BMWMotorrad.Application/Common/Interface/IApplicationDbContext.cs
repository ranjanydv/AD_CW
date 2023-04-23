using BMWMotorrad.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BMWMotorrad.Application.Common.Interface;

public interface IApplicationDBContext
{
    DbSet<User> Users { get; set; }
    // DbSet<Department> Department { get; set; }
    // DbSet<SalaryOrBonus> SalaryOrBonus { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}