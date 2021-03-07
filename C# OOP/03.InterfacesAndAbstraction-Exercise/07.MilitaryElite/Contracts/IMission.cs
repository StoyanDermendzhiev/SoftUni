using _07.MilitaryElite.Enums;

namespace _07.MilitaryElite.Contracts
{
    public interface IMission
    {
        string CodeName { get; }

        MissionState MissionState { get; }

        void CompleteMission();
    }
}
