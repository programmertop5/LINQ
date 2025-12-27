using CompanyLINQ;

namespace DZ20
{
    internal class Program
    {
        /*1*/
        static void Main(string[] args)
        {
            Phone[] phones = new Phone[]
            {
                new Phone("iPhone 13", "Apple", 20000, new DateTime(2022, 4, 23)),
                new Phone("Galaxy M22", "Samsung", 28000, new DateTime(2021, 7, 12)),
                new Phone("OnePlus 12", "OnePlus", 15500, new DateTime(2024, 2, 1)),
                new Phone("Xiaomi 13", "Xiaomi", 22000, new DateTime(2024, 3, 10)),
                new Phone("Galaxy A54", "Samsung", 13000, new DateTime(2021, 3, 15)),
                new Phone("Pixel 7a", "Google", 20000, new DateTime(2023, 5, 11)),
            };

            Console.WriteLine("Phones");
            /*1*/
            int totalCount = phones.Count();
            Console.WriteLine($"1. Total number of phones: {totalCount}");

            /*2*/
            int countBigger100 =
                (from p in phones
                 where p.Price > 100
                 select p).Count();
            Console.WriteLine($"2. Number of phones with price > 100: {countBigger100}");

            /*3*/
            int countInRange =
                (from p in phones
                 where p.Price >= 400 && p.Price <= 700
                 select p).Count();
            Console.WriteLine($"3. Number of phones with price 400–700: {countInRange}");

            /*4*/
            int countByManufacturer =
                (from p in phones
                 where p.Manufacturer == "Apple"
                 select p).Count();
            Console.WriteLine($"4. Number of phones by a specific manufacturer: {countByManufacturer}");

            /*5*/
            Phone cheapestPhone =
                (from p in phones
                 orderby p.Price
                 select p).First();

            Console.WriteLine($"5. Cheapest phone:\n   {cheapestPhone}\n");

            /*6*/
            Phone mostExpensivePhone =
                (from p in phones
                 orderby p.Price descending
                 select p).First();

            Console.WriteLine($"6. Most expensive phone:\n   {mostExpensivePhone}\n");

            /*7*/
            Phone oldestPhone =
                (from p in phones
                 orderby p.ReleaseDate
                 select p).First();

            Console.WriteLine($"7. Oldest phone:\n   {oldestPhone}\n");

            /*8*/
            Phone newestPhone =
                (from p in phones
                 orderby p.ReleaseDate descending
                 select p).First();

            Console.WriteLine($"8. Newest phone:\n   {newestPhone}\n");

            /*2*/
            Company[] firms = new Company[]
            {
                new Company("Food Shop", new DateTime(2019, 3, 17), "Marketing",
                            "John White", 150, "London"),

                new Company("Solutions", new DateTime(2019, 3, 10), "IT",
                            "Sarah Black", 250, "New York"),

                new Company("Food Market", new DateTime(2021, 8, 20), "Retail",
                            "Michael Green", 80, "London"),

                new Company("Shop pro", new DateTime(2018, 1, 5), "Marketing",
                            "Emma White", 120, "Paris"),

                new Company("IT technologies", new DateTime(2017, 9, 25), "IT",
                            "Anna Johnson", 175, "Madrid"),
            };

            Console.WriteLine("Companies");
            /*1*/
            Console.WriteLine(" 1. All companies\n");
            var allFirms =
                from f in firms
                select f;

            foreach (var firm in allFirms)
            {
                Console.WriteLine(firm);
                Console.WriteLine();
            }

            /*2*/
            Console.WriteLine("\n2. Companies with the word 'Food' in the name \n");
            var foodFirms =
                from c in firms
                where c.Name.Contains("Food")
                select c;

            foreach (var firm in foodFirms)
            {
                Console.WriteLine(firm);
                Console.WriteLine();
            }

            /*3*/
            Console.WriteLine("\n 3. Companies in the marketing industry \n");
            var marketingCompanies =
                from c in firms
                where c.BusinessProfile == "Marketing"
                select c;

            foreach (var company in marketingCompanies)
            {
                Console.WriteLine(company);
                Console.WriteLine();
            }

            /*4*/
            Console.WriteLine("\n4. Companies in Marketing or IT\n");
            var marketingOrIT =
                from c in firms
                where c.BusinessProfile == "Marketing" || c.BusinessProfile == "IT"
                select c;

            foreach (var company in marketingOrIT)
            {
                Console.WriteLine(company);
                Console.WriteLine();
            }

            /*5*/
            Console.WriteLine("\n5. Companies with more than 100 employees");
            var largeCompanies =
                from c in firms
                where c.EmployeesCount > 100
                select c;

            foreach (var company in largeCompanies)
            {
                Console.WriteLine(company);
                Console.WriteLine();
            }

            /*6*/
            Console.WriteLine("\n6. Companies with 100–300 employees\n");
            var companies100Employees =
                from c in firms
                where c.EmployeesCount >= 100 && c.EmployeesCount <= 300
                select c;

            foreach (var company in companies100Employees)
            {
                Console.WriteLine(company);
                Console.WriteLine();
            }

            /*7*/
            Console.WriteLine("\n7. Companies located in London\n");
            var londonCompanies =
                from c in firms
                where c.Address == "London"
                select c;

            foreach (var company in londonCompanies)
            {
                Console.WriteLine(company);
                Console.WriteLine();
            }

            /*8*/
            Console.WriteLine("\n8. Companies with director White\n");
            var whiteDirectors =
                from c in firms
                where c.DirectorNSP.Contains("White")
                select c;

            foreach (var company in whiteDirectors)
            {
                Console.WriteLine(company);
                Console.WriteLine();
            }

            /*9*/
            Console.WriteLine("\n9. Companies older than 2 years\n");
            DateTime twoYearsAgo = DateTime.Now.AddYears(-2);

            var oldCompanies =
                from c in firms
                where c.FoundedDate < twoYearsAgo
                select c;

            foreach (var company in oldCompanies)
            {
                Console.WriteLine(company);
                Console.WriteLine();
            }

            /*10*/
            Console.WriteLine("\n10. Companies that are exactly 123 days old\n");
            DateTime exactDate = DateTime.Now.AddDays(-123);

            var companies123Days =
                from c in firms
                where c.FoundedDate.Date == exactDate.Date
                select c;

            foreach (var company in companies123Days)
            {
                Console.WriteLine(company);
                Console.WriteLine();
            }

            /*11*/
            Console.WriteLine("\n11. Director Black and company name contains White\n");
            var blackAndWhite =
                from c in firms
                where c.DirectorNSP.Contains("Black") && c.Name.Contains("White")
                select c;

            foreach (var company in blackAndWhite)
            {
                Console.WriteLine(company);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
