namespace OOP
{
    public partial class Program
    {
        class Samurai : Human
        {
            public Samurai(string name, int strength, int intelligence,int dexterity )
                :base(name, strength, intelligence, dexterity)
            {
                Health = 200;
                
            }  
            public override int Attack(Human target) 
            {
                base.Attack(target);
                if (target.Health<50){
                    target.Health = 0;
                }
                return target.Health;
            }
            public void Meditate(Samurai samurai1)
            {
                samurai1.Health = 200;
            }
        }

    }
}
