using System.Runtime.InteropServices;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string dotNetVersion = Environment.Version.ToString();
            string os = RuntimeInformation.OSDescription;
            var cpu = RuntimeInformation.ProcessArchitecture;

            Console.WriteLine("Runtime Info:");
            Console.WriteLine("DotNet Version: " + dotNetVersion);
            Console.WriteLine("OS: " + os);
            Console.WriteLine("CPU: " + cpu);

            
            string runtime = RuntimeInformation.FrameworkDescription;

            
            switch (runtime)
            {
                case string r when r.Contains(".NET Core"):
                    Console.WriteLine("Modern .NET Runtime");
                    break;

                case string r when r.Contains(".NET"):
                    Console.WriteLine("Modern .NET Runtime");
                    break;

                default:
                    Console.WriteLine("Legacy Runtime");
                    break;
            }

        }
    }
}
