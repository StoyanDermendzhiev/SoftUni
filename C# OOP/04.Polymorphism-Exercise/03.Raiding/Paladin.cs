namespace _03.Raiding
{
    public class Paladin : BaseHero
    {
        private const int paladinPower = 100;

        public Paladin(string name)
            : base(name, paladinPower)
        {
        }

        public override string CastAbility()
        {
            return $"{nameof(Paladin)} - {Name} healed for {paladinPower}";
        }
    }
}
