namespace Packt.Shared
{


    public class Person
    {
        public string? Name;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public WondersOfTheAncientWorld Bucketlist;
        public DateTime DataOfBirth;
        public List<Person> Children = new List<Person>();
        public const string Species = "Homo Sapien";
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;
        public Person()
        {
            Name = "Unkn";
            Instantiated = DateTime.Now;
        }
        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
           
          
        }
        public (string, int) GetFruit()
            {
                return ("Apples", 5);
            }
    }
     
}
namespace Packt.Shared
{


    public class BankAccount
    {
        public string? AccountName;
        public decimal Balance;
        public static decimal InterestRate;

    }
}








