namespace Q4
{

    class User
    {
        public string Name;
    }

    struct UserSnapshot
    {
        public string Name;
    }

   internal class Program
    {
        static void Main(string[] args)
        {
            User u1 = new User();
            u1.Name = "Eslam";

            UserSnapshot s1 = new UserSnapshot();
            s1.Name = "Eslam";

            
            Modify(u1, s1);

            Console.WriteLine("After call:");
            Console.WriteLine("User Name: " + u1.Name);
            Console.WriteLine("Snapshot Name: " + s1.Name);

            Console.WriteLine();

            
            ModifyByRef(ref u1, ref s1);

            Console.WriteLine("After ref call:");
            Console.WriteLine("User Name: " + u1.Name);
            Console.WriteLine("Snapshot Name: " + s1.Name);
        }

        static void Modify(User user, UserSnapshot snapshot)
        {
            user.Name = "Ahmed";
            snapshot.Name = "Ahmed";
        }

        static void ModifyByRef(ref User user, ref UserSnapshot snapshot)
        {
            user.Name = "sama";
            snapshot.Name = "sama";
        }
    }
}