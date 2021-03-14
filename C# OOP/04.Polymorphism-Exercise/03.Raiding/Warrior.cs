namespace _03.Raiding
{
    public class Warrior : BaseHero
    {
        private const int warriorPower = 100;

        public Warrior(string name) 
            : base(name, warriorPower)
        {
        }

        public override string CastAbility()
        {
            return $"{nameof(Warrior)} - {Name} hit for {warriorPower} damage";

        }
    }
}
