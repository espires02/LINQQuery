namespace LINQ
{
    class famousPeople
    {
        public string Name { get; set; }
        public int? BirthYear { get; set; } = null;
        public int? DeathYear { get; set; } = null;
    }
    class Program {
        static void Main(string[] args)
        {
            IList<famousPeople> stemPeople = new List<famousPeople>() {
                new famousPeople() { Name= "Michael Faraday", BirthYear=1791,DeathYear=1867 },
                new famousPeople() { Name= "James Clerk Maxwell", BirthYear=1831,DeathYear=1879 },
                new famousPeople() { Name= "Marie Skłodowska Curie", BirthYear=1867,DeathYear=1934 },
                new famousPeople() { Name= "Katherine Johnson", BirthYear=1918,DeathYear=2020 },
                new famousPeople() { Name= "Jane C. Wright", BirthYear=1919,DeathYear=2013 },
                new famousPeople() { Name = "Tu YouYou", BirthYear= 1930 },
                new famousPeople() { Name = "Françoise Barré-Sinoussi", BirthYear=1947 },
                new famousPeople() {Name = "Lydia Villa-Komaroff", BirthYear=1947},
                new famousPeople() {Name = "Mae C. Jemison", BirthYear=1956},
                new famousPeople() {Name = "Stephen Hawking", BirthYear=1942,DeathYear=2018 },
                new famousPeople() {Name = "Tim Berners-Lee", BirthYear=1955 },
                new famousPeople() {Name = "Terence Tao", BirthYear=1975 },
                new famousPeople() {Name = "Florence Nightingale", BirthYear=1820,DeathYear=1910 },
                new famousPeople() {Name = "George Washington Carver", DeathYear=1943 },
                new famousPeople() {Name = "Frances Allen", BirthYear=1932,DeathYear=2020 },
                new famousPeople() {Name = "Bill Gates", BirthYear=1955 }
            };

            var twentiethCentury = from s in stemPeople where s.BirthYear >= 1900 select s;

            string[] names = (from n in twentiethCentury select n.Name).ToArray();
            Console.WriteLine("The people on the list born after 1900 are: ");
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

            var multL = from l in stemPeople where l.Name.Contains("ll") select l;
            string[] lname = (from l in multL select l.Name).ToArray();
            Console.WriteLine("The people with two lowercase l's are: ");
            foreach (var name in lname)
            {
                Console.WriteLine(name);
            }

            var aftFifty = from a in stemPeople where a.BirthYear > 1950 select a;
            string[] aName = (from a in aftFifty select a.Name).ToArray();
            Console.WriteLine($"The number of people on the list born after 1950 is: {aName.Count()}");

            var bCount = from b in stemPeople where b.BirthYear > 1920 where b.BirthYear < 2000 select b;
            string[] count = (from b in bCount select b.Name).ToArray();
            Console.WriteLine("The people born between 1920 and 2000 are: ");
            foreach (var c in count)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine($"The number of people on the list born between 1920 and 2000 is: {bCount.Count()}");

            var sorting = from o in stemPeople orderby o.BirthYear ascending select o;
            string[] sorts = (from o in sorting select o.Name).ToArray();
            Console.WriteLine("List sorted by birthyear: ");
            foreach (var s in sorts)
            {
                Console.WriteLine(s);
            }

            var dYear = from d in stemPeople where d.DeathYear > 1960 where d.DeathYear < 2015 orderby d.Name ascending select d;
            string[] death = (from d in dYear select d.Name).ToArray();
            Console.WriteLine("People who died between 1960 and 2015: ");
            foreach (var d in death)
            {
                Console.WriteLine(d);
            }
        }
    }
}