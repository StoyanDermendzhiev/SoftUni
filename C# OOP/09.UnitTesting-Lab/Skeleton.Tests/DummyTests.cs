using NUnit.Framework;

[TestFixture]
public class DummyTests
{
    private Dummy dummy;
    private Dummy deadDummy;

    private const int health = 10;
    private const int experience = 10;
    private const int attackedPoints = 3;

    [SetUp]
    public void SetUp()
    {
        dummy = new Dummy(health, experience);
        deadDummy = new Dummy(0, experience);
    }
    
    [Test]
    public void LosesHealth_WhenAttacked()
    {
        dummy.TakeAttack(attackedPoints);

        Assert.That(dummy.Health, Is.EqualTo(health - attackedPoints),
            "Dummy Health doesn't change after taking attack.");
    }

    [Test]
    public void WhenDeadDummyAttacked_ShouldThrowException()
    {
        Assert.That(() =>
        {
            deadDummy.TakeAttack(attackedPoints);
        },
            Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."),
            "Attacked dead Dummy doesn't throw exception.");

    }
    
    [Test]
    public void DeadDummyGiveXP()
    {
        Assert.That(deadDummy.GiveExperience(), Is.EqualTo(experience),
            "Dead Dummy doesn't give experience.");
    }

    [Test]
    public void AliveDummyCouldNotGiveXP()
    {
        Assert.That(() =>
            {
                dummy.GiveExperience();
            },
            Throws.InvalidOperationException.With.Message.EqualTo("Target is not dead."),
            "Alive Dummy is giving XP.");

    }
}
