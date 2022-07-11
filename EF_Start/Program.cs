using EF_Start.Models;
using Microsoft.Identity.Client;

class Program
{
    static void Main(string[] args)
    {
        using (EF_Start.AppContext context = new EF_Start.AppContext())
        {
            context.Users.Add(new User() {Name = "Anastasia", Age = 20});
            context.SaveChanges();
            
        }

        Console.WriteLine("Ready.");
    }
}