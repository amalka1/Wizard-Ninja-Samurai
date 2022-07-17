namespace OOP
{
     class Wizzard : Human
    {
        public Wizzard(string name, int strength, int dex)
        :base (name, strength, dex)
        {
            Health = 50;
            Intelligence = 25;
        }
        
        public override int Attack (Human target)
        {
            int damage = 5 * Intelligence;
            target.Health -= damage;
            Health += damage;
            return target.Health;
        }
        public void Heal (Human target)
        {
            target.Health += (Intelligence*10);
        }
    }
}