using _04.BorderControl.Contracts;

namespace _04.BorderControl.Models
{
    interface IRobot : IIdentifiable
    {
        string Model { get; }
    }
}
