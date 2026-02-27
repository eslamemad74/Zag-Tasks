using System.Text.RegularExpressions;
using System.Xml;
using Task_6_linq;

namespace Task_6_linq
{
    //Q2 , Q3 and Q4
    record Product(int Id, string Name, decimal Price, string Category);

    //Q6
    //record Employee(int Id,string Name, decimal Salary, string Department);

    //Questions 6 and 8, comment on one of them until you use the other.
    //Q8 and 12
    record Employee(string Name, decimal Salary, string Department);

    //Q11 and 12
    record Course(string Title, List<string> Students);
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q1();
            //Q2();
            //Q3();
            //Q4();
            //Q5();
            //Q6();
            //Q7();
            //Q8();
            //Q9();
            //Q10();
            //Q11();
            //Q12();


        }

        static void Q1()
        {
            
            List<int> numbers = new List<int> { 3, 18, 7, 42, 10, 5, 29, 14, 6, 100 };

            var querySyntax =
                from n in numbers
                where n % 2 == 0 && n > 10
                orderby n descending
                select n;

            var fluentSyntax = numbers
                                  .Where(n => n % 2 == 0 && n > 10)
                                  .OrderByDescending(n => n);

            foreach (var n in querySyntax)
            {
                Console.WriteLine(n);
            }
            foreach (var n in fluentSyntax)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("=================================================================");
        }
        static void Q2()
        {
            //first => بيرجع اول عنصر 
            //first or default => بيرجع اول عنصر ولو مش موجوده بيرجع null
            //last => بيرجع اخر عنصر 
            //last or default => بيرجع اخر عنصر ولو مش موجوده بيرجع null
            //first => بيرجع العنصر اللي ل واحده فقط  
            //first or default => لو مفيش عنص ف ليست لوحده بيرجع null
            //element at => بيرجع العنصر اللي ف البوزيشن ده



            List<Product> products = new()
            {
                 new(1,"Laptop",1200m,"Electronics"),
                 new(2,"Phone",800m,"Electronics"),
                 new(3,"Desk",350m,"Furniture"),
                 new(4,"Chair",150m,"Furniture"),
                 new(5,"Headphones",200m,"Electronics"),
            };

            // 1. Get the first Electronics product
            var firstElectronics = products.First(p => p.Category == "Electronics");
            Console.WriteLine(firstElectronics.Name);

            // 2. Get the last product with Price > 1000 (use OrDefault — handle null)
            var lastExpensive = products.LastOrDefault(p => p.Price > 1000);

            if (lastExpensive != null)
                Console.WriteLine(lastExpensive.Name);
            else
                Console.WriteLine("No product with price > 1000");

            // 3.Get the single Furniture item with Price > 300(what if > 1 match ?)
            try
            {
                var singleFurniture = products.Single(p =>
                    p.Category == "Furniture" && p.Price > 300);

                Console.WriteLine(singleFurniture.Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // 4. Get the element at index 3
            try
            {
                var element = products.ElementAt(3);
                Console.WriteLine(element.Name);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Index out of range");
            }
        }
        static void Q3()
        {
            List<Product> products = new()
            {
                 new(1,"Laptop",1200m,"Electronics"),
                 new(2,"Phone",800m,"Electronics"),
                 new(3,"Desk",350m,"Furniture"),
                 new(4,"Chair",150m,"Furniture"),
                 new(5,"Headphones",200m,"Electronics"),
            };
            //1.Are ALL products priced above 100 ?
            bool allAbove100 = products.All(p => p.Price > 100);
            Console.WriteLine($"1. All products priced above 100? {allAbove100}");


            // 2. Is THERE ANY product in the "Gaming" category?
            bool anyGaming = products.Any(p => p.Category == "Gaming");
            Console.WriteLine($"2. Any product in Gaming category? {anyGaming}");


            // 3. Does the collection CONTAIN a product named "Chair"?
            var chairProduct = new Product(4, "Chair", 150m, "Furniture");

            bool containsChair = products.Contains(chairProduct);
            Console.WriteLine($"3. Collection contains 'Chair' product? {containsChair}");


            // 4. Are ALL Electronics products priced above 500?
            bool allElectronicsAbove500 = products
                .Where(p => p.Category == "Electronics")
                .All(p => p.Price > 500);

            Console.WriteLine($"4. All Electronics priced above 500? {allElectronicsAbove500}");


            // 5. Is there ANY product cheaper than 200?
            bool anyCheaperThan200 = products.Any(p => p.Price < 200);
            Console.WriteLine($"5. Any product cheaper than 200? {anyCheaperThan200}");
        }
        static void Q4()
        {

            List<Product> products = new()
            {
                 new(1,"Laptop",1200m,"Electronics"),
                 new(2,"Phone",800m,"Electronics"),
                 new(3,"Desk",350m,"Furniture"),
                 new(4,"Chair",150m,"Furniture"),
                 new(5,"Headphones",200m,"Electronics"),
            };
            Product[] productsArray = products.ToArray();
            Console.WriteLine("1. Converted to Array");

            Dictionary<int, Product> productsDictionary = products.ToDictionary(p => p.Id);
            Console.WriteLine("2. Converted to Dictionary keyed by Id");

            HashSet<string> productNames = products.Select(p => p.Name).ToHashSet();
            Console.WriteLine("3. Converted to HashSet of product Names");

            ILookup<string, Product> productsLookup = products.ToLookup(p => p.Category);
            Console.WriteLine("4. Converted to Lookup keyed by Category");

            
            Console.WriteLine("Electronics products:");
            foreach (var p in productsLookup["Electronics"])
            {
                Console.WriteLine(p.Name);
            }

            //ToDictionary:كل Key لازم يكون UNIQUE
            //لو حصل تكرار في الـ Key  بيرمي Exception

            //ToLookup: بيسمح بتكرار الـ Keys
            //كل Key بيبقى مرتبط بمجموعة(Collection) من العناصر
            //مبيرميش Exception مع التكرار

            //⟢ What exception does ToDictionary throw if keys are duplicated? ArgumentException
            //⟢ How does ToLookup handle duplicate keys differently ? بتجمع العناصر اللي ليها نفس ال key
        }
        static void Q5()
        {
            List<string> orders = new()
            {
                "ORD-001",
                "ORD-002",
                "ORD-003",
                "ORD-004",
                "ORD-005",
                "ORD-006",
                "ORD-007"
            };

            var page1 = orders.Take(3);

            Console.WriteLine("Page 1:");
            foreach (var order in page1)
            {
                Console.WriteLine(order);
            }

            var page2 = orders.Skip(3).Take(3);

            Console.WriteLine("\nPage 2:");
            foreach (var order in page2)
            {
                Console.WriteLine(order);
            }

            var lastTwoOrders = orders.TakeLast(2);

            Console.WriteLine("\nLast 2 Orders:");
            foreach (var order in lastTwoOrders)
            {
                Console.WriteLine(order);
            }

            var withoutFirstAndLast = orders
                                        .Skip(1)
                                        .SkipLast(1);

            Console.WriteLine("\nWithout first and last:");
            foreach (var order in withoutFirstAndLast)
            {
                Console.WriteLine(order);
            }

           
        }
        static void Q6()
        {
           /* List<Employee> employees = new()
            {
                new(1, "Ali", 9000m, "Engineering"),
                new(2, "Nada", 9500m, "Engineering"),
                new(3, "Omar", 7000m, "HR"),
                new(4, "Mona", 6000m, "Marketing"),
                new(5, "Hassan", 8000m, "Engineering"),
            };

            var anonymousProjection = employees
                                        .Select(e => new
                                        {
                                           FullName = e.Name.ToUpper(),
                                           e.Salary
                                        });

            Console.WriteLine("1) Anonymous Projection:");
            foreach (var e in anonymousProjection)
            {
                Console.WriteLine($"{e.FullName} - {e.Salary}");
            }

            var formattedStrings = employees
                                        .Select(e => $"{e.Name} works in {e.Department} — EGP {e.Salary:N0}");

            Console.WriteLine("\n2) Formatted Strings:");
            foreach (var s in formattedStrings)
            {
                Console.WriteLine(s);
            }

            var rankedEmployees = employees
                                        .OrderByDescending(e => e.Salary)
                                        .Select((e, index) => new
                                        {
                                           Rank = index + 1,
                                           e.Name,
                                           e.Salary
                                        });

            Console.WriteLine("\n3) Ranked Employees:");
            foreach (var e in rankedEmployees)
            {
                Console.WriteLine($"Rank={e.Rank}, Name={e.Name}, Salary={e.Salary}");
            }

            var employeesWithLevel = employees
                                            .Select(e => new
                                            {
                                               e.Name,
                                               e.Salary,
                                               SeniorityLevel =
                                               e.Salary >= 9000 ? "Senior" :
                                               e.Salary >= 7000 ? "Mid" :
                                               "Junior"
                                            });

            Console.WriteLine("\n4) Seniority Levels:");
            foreach (var e in employeesWithLevel)
            {
                Console.WriteLine($"{e.Name} - {e.Salary} - {e.SeniorityLevel}");
            }
           */
        }
        static void Q7()
        {
            List<int> scores = new List<int> { 88, 92, 75, 60, 55, 80, 91, 45 };

            var takenScores = scores.TakeWhile(score => score >= 70).ToList();

            var skippedScores = scores.SkipWhile(score => score >= 70).ToList();

            /*
             TakeWhile و SkipWhile:
             - لازم ترتيب العناصر
             - أول ما الشرط ميتحققش يشتغلو 
             Where:
             -بيعدي ع كل العناصر 
             -الترتيب مش مهم 
             - بيرجع أي عنصر الشرط متحقق عليه
            */
        }
        static void Q8()
        {
            List<Employee> employees = new()
            {
               new("Ali",9000m ,"Engineering"),
               new("Sara",8500m ,"Engineering"),
               new("Omar",6000m ,"HR"),
               new("Mona",6200m,"HR"),
               new("Yara",7000m,"Marketing"),
               new("Karim",7500m,"Marketing"),
               new("Nada",9500m,"Engineering"),
            };

            var grouped = employees
                                .GroupBy(e => e.Department)
                                .Select(g => new
                                {
                                    Department = g.Key,
                                    Count = g.Count(),
                                    AvgSalary = g.Average(e => e.Salary)
                                });

            foreach (var g in grouped)
            {
                Console.WriteLine($"{g.Department} → Count: {g.Count}, Avg: {g.AvgSalary}");
            }

            var highestBudgetDept = employees
                                        .GroupBy(e => e.Department)
                                        .Select(g => new
                                        {
                                           Department = g.Key,
                                           TotalSalary = g.Sum(e => e.Salary)
                                        })
                                        .OrderByDescending(g => g.TotalSalary)
                                        .First();
                Console.WriteLine(
                $"Highest Budget Department: {highestBudgetDept.Department} " +
                $"with Total = {highestBudgetDept.TotalSalary}"
                );

            var orderedGroups = employees
                                        .GroupBy(e => e.Department);
            foreach (var group in orderedGroups)
            {
                Console.WriteLine($"\nDepartment: {group.Key}");

                foreach (var emp in group.OrderByDescending(e => e.Salary))
                {
                    Console.WriteLine($"- {emp.Name}: {emp.Salary}");
                }
            }
        }
        static void Q9()
        {
            // (Q1) output => 3 , 4 , 5 , 10 where is deferred execution => الفلتره هتشتغل مع تنفيذ الكود جوا ال for loop

            //Q2
            // output => 3 , 4 , 5 , 10 .tolist  => بتنفذ الفلتره ف وقتها ع طول
            List<int> nums = new() { 1, 2, 3, 4, 5 };

            var query = nums.Where(n => n > 2).ToList();
            nums.Add(20);

            foreach (var n in query)
                Console.Write(n + " ");

            //Q3
            //.ToList() 
            //.ToArray()y
            // aggregate => .Count() / .Sum() / .Average() / .First() / .Any() / .All()
        }
        static void Q10()
        {
            List<string> words = new()
            {
            "apple",
            "fig",
            "banana",
            "kiwi",
            "grape",
            "mango",
            "pear",
            "plum"
            };

            var longWords = words.Where(w => w.Length > 4);

            Console.WriteLine(string.Join(", ", longWords));

            var evenIndexWords = words.Where((w, index) => index % 2 == 0);

            Console.WriteLine(string.Join(", ", evenIndexWords));

            var combinedFilter = words
                                    .Where((w, index) => w.Length > 4 && index % 2 == 0);
             Console.WriteLine(string.Join(", ", combinedFilter));

            int mangoIndex = longWords.ToList().IndexOf("mango");

            Console.WriteLine($"Index of mango = {mangoIndex}");
        }
        static void Q11()
        {
            List<Course> courses = new()
            {
                new("C# Basics",new() { "Ali", "Sara", "Omar" }),
                new("LINQ Mastery",new() { "Sara", "Mona", "Ali" }),
                new("ASP.NET Core",new() { "Yara", "Omar", "Karim" }),
            };

            var allStudents = courses
                                    .SelectMany(c => c.Students);
            Console.WriteLine(string.Join(", ", allStudents));

            var distinctStudents = courses
                                        .SelectMany(c => c.Students)
                                        .Distinct();
            Console.WriteLine(string.Join(", ", distinctStudents));

            var multiCourseStudents = courses
                                            .SelectMany(c => c.Students)
                                            .GroupBy(s => s)
                                            .Where(g => g.Count() > 1)
                                            .Select(g => g.Key);
            Console.WriteLine(string.Join(", ", multiCourseStudents));

            var enrollments = courses
                                    .SelectMany(
                                    course => course.Students,
                                    (course, student) => new
                                    {
                                       CourseName = course.Title,
                                       StudentName = student
                                    });

            foreach (var e in enrollments)
            {
                Console.WriteLine($"{e.StudentName} enrolled in {e.CourseName}");
            }
        }
        static void Q12()
        {
            List<Employee> employees = new()
            {
               new("Ali",9000m ,"Engineering"),
               new("Sara",8500m ,"Engineering"),
               new("Omar",6000m ,"HR"),
               new("Mona",6200m,"HR"),
               new("Yara",7000m,"Marketing"),
               new("Karim",7500m,"Marketing"),
               new("Nada",9500m,"Engineering"),
            };

            List<Course> courses = new()
            {
                new("C# Basics",new() { "Ali", "Sara", "Omar" }),
                new("LINQ Mastery",new() { "Sara", "Mona", "Ali" }),
                new("ASP.NET Core",new() { "Yara", "Omar", "Karim" }),
            };

            //q1
            var top2PerDept = employees
                                    .GroupBy(e => e.Department) // Deferred
                                    .SelectMany(g => g
                                    .OrderByDescending(e => e.Salary) // Deferred
                                    .Take(2)                        // Deferred
                                    );
            Console.WriteLine("Top 2 per department:");
            foreach (var e in top2PerDept)
            {
                Console.WriteLine($"{e.Name} - {e.Department} - {e.Salary}");
            }

            //q2
            var courseDict = courses
                                   .Where(c => c.Students.Count > 2) 
                                   .ToDictionary(c => c.Title, c => c.Students.Count); // Immediate
            Console.WriteLine("\nCourse Dictionary (>2 students):");
            foreach (var kvp in courseDict)
            {
                Console.WriteLine($"{kvp.Key} → {kvp.Value}");
            }

            //q3
            // Any employee in Engineering earns less than 8000?
            bool anyEngLow = employees
                .Where(e => e.Department == "Engineering") // Deferred
                .Any(e => e.Salary < 8000);               // Immediate
            Console.WriteLine($"\nAny Engineering < 8000? {anyEngLow}");

            // All HR employees earn > 5500?
            bool allHRHigh = employees
                .Where(e => e.Department == "HR") // Deferred
                .All(e => e.Salary > 5500);       // Immediate

            Console.WriteLine($"All HR > 5500? {allHRHigh}");

            //q4
            var top2WithRank = employees
                                    .GroupBy(e => e.Department)
                                    .SelectMany(g => g         // Deferred
                                    .OrderByDescending(e => e.Salary)
                                    .Select((e, index) => new
                                    {
                                         Rank = index + 1,
                                         e.Name,
                                         e.Department,
                                         e.Salary,
                                         SeniorityLevel = e.Salary >= 9000 ? "Senior" :
                                         e.Salary >= 7000 ? "Mid" :
                                          "Junior"
                                    })
                                    );

            Console.WriteLine("\nTop 2 per dept with Rank & Seniority:");
            foreach (var e in top2WithRank)
            {
                Console.WriteLine($"{e.Rank} - {e.Name} - {e.Department} - {e.Salary} - {e.SeniorityLevel}");
            }
            
            


        }

    }
}
