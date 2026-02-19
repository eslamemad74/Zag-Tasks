using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ3
{
    public static class EmployeeRepository
    {
        public static List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee { Id = 1, FirstName = "Salahuddin", LastName = "Ali", Department = "IT", Skills = new List<string> { "C#", "SQL", "Azure" } },
                new Employee { Id = 2, FirstName = "Donia", LastName = "Shaban", Department = "HR", Skills = new List<string> { "Communication", "Recruiting" } },
                new Employee { Id = 3, FirstName = "Sara", LastName = "Hassan", Department = "IT", Skills = new List<string> { "Python", "Docker", "Linux" } },
                new Employee { Id = 4, FirstName = "Alma", LastName = "Saber", Department = "Marketing", Skills = new List<string> { "SEO", "Copywriting" } },
                new Employee { Id = 5, FirstName = "Youssef", LastName = "Mohammad", Department = "IT", Skills = new List<string> { "C#", "Security", "Agile" } },
                new Employee { Id = 6, FirstName = "Omar", LastName = "Khattab", Department = "Sales", Skills = new List<string> { "Negotiation", "CRM" } },
                new Employee { Id = 7, FirstName = "Fatima", LastName = "Zahra", Department = "IT", Skills = new List<string> { "Java", "Spring", "Microservices" } },
                new Employee { Id = 8, FirstName = "Ibrahim", LastName = "Khalil", Department = "Finance", Skills = new List<string> { "Accounting", "Excel", "Audit" } },
                new Employee { Id = 9, FirstName = "Layla", LastName = "Mansour", Department = "HR", Skills = new List<string> { "Training", "Conflict Resolution" } },
                new Employee { Id = 10, FirstName = "Ahmed", LastName = "Zaki", Department = "Marketing", Skills = new List<string> { "Social Media", "Analytics" } },
                new Employee { Id = 11, FirstName = "Hamza", LastName = "Idris", Department = "IT", Skills = new List<string> { "TypeScript", "React", "Node.js" } },
                new Employee { Id = 12, FirstName = "Maryam", LastName = "Yasin", Department = "Sales", Skills = new List<string> { "Public Speaking", "Salesforce" } },
                new Employee { Id = 13, FirstName = "Zaid", LastName = "Nasr", Department = "Finance", Skills = new List<string> { "Taxation", "Reporting" } },
                new Employee { Id = 14, FirstName = "Aisha", LastName = "Siddiqui", Department = "IT", Skills = new List<string> { "C#", "Blazor", "SQL" } },
                new Employee { Id = 15, FirstName = "Mustafa", LastName = "Mahmoud", Department = "IT", Skills = new List<string> { "DevOps", "Kubernetes" } },
                new Employee { Id = 16, FirstName = "Nour", LastName = "El-Din", Department = "Marketing", Skills = new List<string> { "Content Strategy", "Email Marketing" } },
                new Employee { Id = 17, FirstName = "Bilal", LastName = "Habash", Department = "Sales", Skills = new List<string> { "Lead Generation", "Closing" } },
                new Employee { Id = 18, FirstName = "Hafsa", LastName = "Abbas", Department = "HR", Skills = new List<string> { "Payroll", "Onboarding" } },
                new Employee { Id = 19, FirstName = "Tariq", LastName = "Aziz", Department = "IT", Skills = new List<string> { "PHP", "Laravel", "MySQL" } },
                new Employee { Id = 20, FirstName = "Khadija", LastName = "Malik", Department = "Finance", Skills = new List<string> { "Banking", "Risk Assessment" } },
                new Employee { Id = 21, FirstName = "Zubair", LastName = "Hamid", Department = "IT", Skills = new List<string> { "C++", "Embedded Systems" } },
                new Employee { Id = 22, FirstName = "Yasmin", LastName = "Farouk", Department = "Marketing", Skills = new List<string> { "Graphic Design", "Branding" } },
                new Employee { Id = 23, FirstName = "Anas", LastName = "Malek", Department = "Sales", Skills = new List<string> { "Cold Calling", "Networking" } },
                new Employee { Id = 24, FirstName = "Safa", LastName = "Karim", Department = "HR", Skills = new List<string> { "HRIS", "Compliance" } },
                new Employee { Id = 25, FirstName = "Hassan", LastName = "Rizwan", Department = "IT", Skills = new List<string> { "C#", "Unit Testing", "TDD" } },
                new Employee { Id = 26, FirstName = "Sumayya", LastName = "Bashir", Department = "Finance", Skills = new List<string> { "Budgeting", "Forecasting" } },
                new Employee { Id = 27, FirstName = "Usman", LastName = "Ghani", Department = "IT", Skills = new List<string> { "Go", "Cloud Native" } },
                new Employee { Id = 28, FirstName = "Amira", LastName = "Talat", Department = "Marketing", Skills = new List<string> { "PPC", "Market Research" } },
                new Employee { Id = 29, FirstName = "Yahya", LastName = "Zakaria", Department = "Sales", Skills = new List<string> { "Account Management" } },
                new Employee { Id = 30, FirstName = "Hala", LastName = "Amer", Department = "HR", Skills = new List<string> { "Interviewing", "Employee Relations" } },
                new Employee { Id = 31, FirstName = "Sulaiman", LastName = "Dawood", Department = "IT", Skills = new List<string> { "Ruby", "Rails" } },
                new Employee { Id = 32, FirstName = "Muna", LastName = "Fadel", Department = "Finance", Skills = new List<string> { "SAP", "ERP" } },
                new Employee { Id = 33, FirstName = "Khalid", LastName = "Waleed", Department = "IT", Skills = new List<string> { "AWS", "Terraform" } },
                new Employee { Id = 34, FirstName = "Asma", LastName = "Bibi", Department = "Marketing", Skills = new List<string> { "Events", "PR" } },
                new Employee { Id = 35, FirstName = "Idris", LastName = "Musa", Department = "Sales", Skills = new List<string> { "B2B Sales" } },
                new Employee { Id = 36, FirstName = "Ruqayya", LastName = "Iman", Department = "HR", Skills = new List<string> { "Talent Management" } },
                new Employee { Id = 37, FirstName = "Faisal", LastName = "Qureshi", Department = "IT", Skills = new List<string> { "Python", "Data Science" } },
                new Employee { Id = 38, FirstName = "Salma", LastName = "Eissa", Department = "Finance", Skills = new List<string> { "Auditing", "Compliance" } },
                new Employee { Id = 39, FirstName = "Abdurrahman", LastName = "Wahid", Department = "IT", Skills = new List<string> { "Angular", "Firebase" } },
                new Employee { Id = 40, FirstName = "Jana", LastName = "Salem", Department = "Marketing", Skills = new List<string> { "UI/UX", "Figma" } },
                new Employee { Id = 41, FirstName = "Harun", LastName = "Rashid", Department = "Sales", Skills = new List<string> { "Strategy", "Operations" } },
                new Employee { Id = 42, FirstName = "Hanan", LastName = "Ashrawi", Department = "HR", Skills = new List<string> { "Policy Writing" } },
                new Employee { Id = 43, FirstName = "Karim", LastName = "Bensalem", Department = "IT", Skills = new List<string> { "Swift", "iOS Development" } },
                new Employee { Id = 44, FirstName = "Basma", LastName = "Said", Department = "Finance", Skills = new List<string> { "VBA", "Macros" } },
                new Employee { Id = 45, FirstName = "Saad", LastName = "Jabbar", Department = "IT", Skills = new List<string> { "Rust", "Systems Design" } },
                new Employee { Id = 46, FirstName = "Lubna", LastName = "Azmi", Department = "Marketing", Skills = new List<string> { "Affiliate Marketing" } },
                new Employee { Id = 47, FirstName = "Mahmoud", LastName = "Abbas", Department = "Sales", Skills = new List<string> { "Direct Sales" } },
                new Employee { Id = 48, FirstName = "Dina", LastName = "Hegazi", Department = "HR", Skills = new List<string> { "Culture Building" } },
                new Employee { Id = 49, FirstName = "Qasim", LastName = "Amin", Department = "IT", Skills = new List<string> { "Kotlin", "Android" } },
            };
        }
    }
}