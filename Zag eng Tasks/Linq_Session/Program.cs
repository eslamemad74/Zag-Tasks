using System;
using System.Collections.Generic;
using LINQ3;

namespace csharp_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = EmployeeRepository.GetEmployees();
            // (Data Sorting)
            // order by in both query syntax and fluent syntax
            // Then By
            //var orderedEmployees = employees.OrderBy(x => x.FirstName.Length)
            //                                    .ThenBy(x => x.Id)
            //                                .Select(x => new { FullName = x.FirstName + ' ' + x.LastName });

            //var orderedEmployeesQ = from employee in employees
            //                        orderby employee.FirstName.Length, employee.Id descending
            //                        select employee.FirstName + ' ' + employee.LastName;

            //EmployeeRepository.Print("Print Sorted Employees by firdt name length", orderedEmployeesQ);






            // (Data Partioning)
            // skip - skip while - skipLast
            // take - take while - takeLast
            // chnuc 

            //var partition0 = employees.SkipWhile(emp => emp.Skills.Count < 3);
            //EmployeeRepository.Print($"Print from employee num #1 to emmployee {employees.Count - 10}", partition0);

            //var partition1 = employees.TakeLast(10);
            //EmployeeRepository.Print($"Print lat 10 elemnts", partition1);


            //var partition2 = employees.Chunk(10).ToList();
            //for(int i = 0; i < partition2.Count; i++)
            //{
            //    EmployeeRepository.Print($"Chunck number {i + 1}", partition2[i]);
            //    Console.WriteLine("====================================================");
            //}


            // pagination logic // page size = 50/5 = 10 seceond page = 6-10

            //var page2 = employees.Paginate(page: 2, size: 5);

            //EmployeeRepository.Print("Page 2", page2);


            // (Quantifiers)
            // any - all - contain

            //var isEmployeeExist = Employee.IsExist(employees);
            //Console.WriteLine(isEmployeeExist);


            //var groupByDepartment = employees.GroupBy(e => e.Department)
            //                        .            Select(g => new { 
            //                                         Department = g.Key,
            //                                         TotalEmployees = g.Count()
            //                                     });

            //EmployeeRepository.Print($"Grouped Data", groupByDepartment);

            //var groupByDepartmentQ = (from employee in employees
            //                         group employee by employee.Department into deptGroup
            //                         select new
            //                         {
            //                             Department = deptGroup.Key,
            //                             TotalEmployees = deptGroup.Count()
            //                         }).Distinct();

            //EmployeeRepository.Print($"Grouped Data", groupByDepartmentQ);



            // ================ Quiz Time =================
            // Get all IT employees who know C# and return only their full name and skills
            var result = employees
                            .Where(e => e.Department == "IT" && e.Skills.Contains("C#"))
                            .Select(e1 => new
                            {
                               FullName= e1.FirstName + " " + e1.LastName,
                               Skills = string.Join(" ", e1.Skills)
                            });

            foreach (var emp in result)
            {
                Console.WriteLine($"Name: {emp.FullName}, Skills: {emp.Skills}");
            }

            Console.WriteLine("=================================================");
            //List employees grouped by department, showing department name and number of employees in each”
            var query = employees
                                .GroupBy(e => e.Department)
                                .Select(g => new
                                {
                                  DepartmentName = g.Key,
                                  EmployeesCount = g.Count()
                                });
            foreach (var item in query)
            {
                Console.WriteLine($"Department: {item.DepartmentName}, Count: {item.EmployeesCount}");
            }

            Console.WriteLine("=================================================");
            // Get all unique skills across all employees
            var uniqueSkills = employees
                                   .SelectMany (e => e.Skills)
                                   .Distinct();
            foreach (var skill in uniqueSkills)
            {
                Console.WriteLine(skill);
            }

        }
    }

}