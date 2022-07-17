namespace OOP
{
    public partial class Program
    {
        public static void Main (string[] args)
        {
            var ninja =  new Ninja("Gezim",3 ,4, 5);
            ninja.Attack(ninja);
            var wiz = new Wizzard("John",10,15);
           wiz.Heal(wiz);
            System.Console.WriteLine(ninja.Health+ "\n" + ninja.Name + "\n" + ninja.Strength + "\n" + ninja.Intelligence + "\n" + ninja.Dexterity);
            
        }

    }
}
