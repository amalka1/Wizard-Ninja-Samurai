namespace OOP
{
    public partial class Program
    {
        class Ninja : Human
        {
            public Ninja(string name, int strength, int intelligence, int health)
            :base ( name, strength, intelligence, health)
            {
                Dexterity = 175;
            }
            public override int Attack (Human target)
            {
                target.Health -= (Dexterity * 5);
                return target.Health;
            }
            public void Steal (Human target)
            {
                target.Health -= 5;
                Health +=5;
            }
        }

    }
}
