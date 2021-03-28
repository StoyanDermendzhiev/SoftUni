using NUnit.Framework;

[TestFixture]
public class AxeTests
{
    private Axe axe;
    private Axe brokenAxe;
    private const int attackPoints = 5;
    private const int durabilityPoints = 5;

    private Dummy dummy;
    private const int health = 10;
    private const int experience = 10;

    [SetUp]
    public void SetUp()
    {
        axe = new Axe(attackPoints, durabilityPoints);
        brokenAxe = new Axe(attackPoints, 0);
        dummy = new Dummy(health, experience);
    }

    [Test] 
    public void When_Attack_Should_LosesDurability()
    {
        axe.Attack(dummy);

        Assert.That(axe.DurabilityPoints, Is.EqualTo(durabilityPoints-1), 
            "Axe Durability doesn't change after attack.");
    }

    [Test]
    public void When_AttackWithBrokenAxe_Should_Throw()
    {
        Assert.That(() =>
        {
            brokenAxe.Attack(dummy);
        }, 
            Throws.InvalidOperationException.With.Message.EqualTo("Axe is broken."),
            "Don't throw exception when attack with broken axe.");
    }
}