namespace _05.BirthdayCelebrations.Contracts
{
    public interface ICitizen : IIdentifiable, IBirthable
    {
        string Name { get; }

        int Age { get; }
    }
}
