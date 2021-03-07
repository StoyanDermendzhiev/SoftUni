using System.Collections.Generic;

namespace _07.MilitaryElite.Contracts
{
    interface IEngineer : ISpecialisedSoldier
    {
        IReadOnlyCollection<IRepair> Repairs { get; }

        void AddRepair(IRepair repair);
    }
}
