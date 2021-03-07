using _05.BirthdayCelebrations.Contracts;

namespace _05.BirthdayCelebrations
{
    interface IRobot : IIdentifiable
    {
        string Model { get; }
    }
}
