using BMWMotorrad.Application.Common.Interface;

namespace BMWMotorrad.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now
    {
        get => DateTime.UtcNow;
        set => throw new NotImplementedException();
    }
    
}

// public class DateTimeService : IDateTime
// {
//     public DateTime Now => DateTime.UtcNow;
// }