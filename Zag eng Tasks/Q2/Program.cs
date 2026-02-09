namespace Q2
{
    internal class Program
    {
       
            
            const double AppVersion = 8.0;

            
            static readonly bool LoginEnabled = true;
            static readonly double LoginMinVersion = 1.0;

            static readonly bool ExportEnabled = false;
            static readonly double ExportMinVersion = 2.0;

            static readonly bool AdminPanelEnabled = true;
            static readonly double AdminPanelMinVersion = 3.0;

            static void Main()
            {
                Console.WriteLine("App Version: " + AppVersion);
                Console.WriteLine();

                
                CheckFeature("Login", LoginEnabled, LoginMinVersion);

                
                CheckFeature("Export", ExportEnabled, ExportMinVersion);

                CheckFeature("AdminPanel", AdminPanelEnabled, AdminPanelMinVersion);
            }

            static void CheckFeature(string name, bool enabled, double minVersion)
            {
                
                if (enabled && AppVersion >= minVersion)
                {
                    Console.WriteLine(name + ": Can Run");
                }
                else
                {
                    Console.WriteLine(name + ": Cannot Run");
                }

                
                string status = (enabled && AppVersion >= minVersion) ? "Enabled": "Disabled";

                Console.WriteLine("Status: " + status);
                Console.WriteLine();
            }
        
    }
}
