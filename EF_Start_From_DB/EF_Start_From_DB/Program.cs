using EF_Start_From_DB.Models;

class Program
{
    static void Main(string[] args)
    {
        //CREATE
        using (TestDbContext db = new TestDbContext())
        {
            User user = db.Users.FirstOrDefault();
            if (user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }
            User user1 = new User {Name = "Anastasia", Age = 20};
            User user2 = new User {Name = "Andrew", Age = 21};

            /*db.Add(user1);
            db.Add(user2);*/
            db.AddRange(user1,user2);
            db.SaveChanges();

        }
        //GET-READ
        using(TestDbContext context = new TestDbContext())
        {
            Console.WriteLine("Output:");
            var list = context.Users.ToList();
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Id}-{item.Name}-{item.Age}");
            }
        }
        //UPDATE
        using(TestDbContext db = new TestDbContext())
        {
            User user = db.Users.FirstOrDefault();
            if (user != null)
            {
                user.Name = "Bob";
                user.Age = 25;

                //db.Users.Update(user);
                
                db.SaveChanges();
            }

            Console.WriteLine("Updated output:");
            var list = db.Users.ToList();
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Id}-{item.Name}-{item.Age}");
            }
            
        }
        //DELETE
        using (TestDbContext db = new TestDbContext())
        {
            User user = db.Users.FirstOrDefault();
            if (user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }
            Console.WriteLine("Output after removing:");
            var list = db.Users.ToList();
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Id}-{item.Name}-{item.Age}");
            }

        }
        
        
    }
}