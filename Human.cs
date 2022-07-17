namespace OOP
{
    class Human
    {
        public string Name {get; set;} 
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }
        public int Health { get; set; }

      
        public Human(string name = "", int str = 0, int intel = 0, int dex = 0, int hp = 0)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            Health = hp;
        }
        public virtual int Attack (Human target )
        {
            int dmg = Strength * 3;
            target.Health -= dmg;
            System.Console.WriteLine
            ($"{Name} attacked {target.Name} for {dmg} damage");
            return target.Health;
        }
    }
}