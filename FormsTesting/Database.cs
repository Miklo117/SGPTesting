using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsTesting
{
    class Database
    {
        public Database()
        {
            TestClasses = GenerateDummyList(150);
        }
        public List<TestClass> TestClasses { get; set; }
        static public List<TestClass> GenerateDummyList(int limit)
        {
            string[] names = new string[]{"Suranne Marks",
"Ava-May Mckenzie",
"Jaidon Beach",
"Burhan Barrera",
"Brendon Hirst",
"Eleni Hagan",
"Kalvin Daly",
"Pearce Gill",
"Marisa Crawford",
"Aiysha Proctor",
"Abid Ball",
"Haydn Mcgregor",
"Dylan Banks",
"Luna Quintana",
"Paloma Cleveland",
"Taliah Farrow",
"Noa Tanner",
"Hamza Corrigan",
"Reanne Harrington",
"Darrell Stanley",
"Amayah Armitage",
"Weronika Hibbert",
"Ishika Brock",
"Norma Churchill",
"Alaina Mcphee",
"Josiah Kumar",
"Astrid Singleton",
"Eliot Dyer",
"Izabela Holmes",
"Usman Munro",
"Harlen Diaz",
"Corbin Scott",
"Aleeza Mack",
"Imaani Marin",
"Elisabeth Padilla",
"Clement Lugo",
"Ted Ireland",
"Elysha Amos",
"Sunil Hogan",
"Lyra Wall",
"Nafeesa Jordan",
"Cinar Bernal",
"Shakir Dennis",
"Issa Rubio",
"Eshaan Burn",
"Ariah Horton",
"Karim Harwood",
"Ria Rangel",
"Rita Esparza",
"Carrie Bonilla",
"Mahad Boone",
"Asiyah Fowler",
"Magnus Compton",
"Ewen Mooney",
"Sahar Rankin",
"Martin Haley",
"Kerry Hughes",
"Aleah Mcnally",
"Annalise Clegg",
"Montel Barry",
"Maxine Partridge",
"Maddox Maxwell",
"Aston Dillon",
"Cairon Wang",
"Ammaarah Ruiz",
"Essa Calhoun",
"Layton Burrows",
"Tammy Garcia",
"Kaylum Bullock",
"Bobbi Gibbs",
"Kiri Travers",
"Leila Kelly",
"Aya James",
"Leticia Carney",
"Phoenix Emery",
"Sophie Branch",
"Hiba Wainwright",
"Abbi West",
"Minnie Alexander",
"Shamima Lowry",
"Fionnuala Grey",
"Raihan Mcloughlin",
"Dafydd Franklin",
"Allen Baird",
"Parker Penn",
"Drake Hoffman",
"Jaydn Werner",
"Lily-Mae Bell",
"Zephaniah Fritz",
"Siana Pratt",
"Sophia-Rose Greaves",
"Usaamah Allison",
"Elsa Guevara",
"Dani Sampson",
"Christiana Jimenez",
"Lillie-Rose Love",
"April Rogers",
"Courteney Clayton",
"Grayson Browne",
"Jody Eastwood" };
            List<TestClass> list = new List<TestClass>();
            for (int i = 0; i < limit; i++)
            {
                TestClass x = new TestClass()
                {
                    Id = Guid.NewGuid(),
                    Number = i+1,
                    Value = new Random(Guid.NewGuid().GetHashCode()).Next(10),
                    Name = names[new Random(Guid.NewGuid().GetHashCode()).Next(100)],
                    Bar = new Random(Guid.NewGuid().GetHashCode()).Next(100),
                    Foo = new Random(Guid.NewGuid().GetHashCode()).Next(100)
                };
                list.Add(x);
            }

            return list;
        }
    }
}
