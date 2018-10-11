using System;
using System.Collections.Generic;
using System.Linq;

namespace InClassAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                try
                {

                    
                    db.Database.EnsureDeleted();
                    db.Database.EnsureCreated();

                    if(!db.Students.Any())
                    {
                        List<Student> students = new List<Student>()
                        {
                            new Student()
                            {
                                FirstName = "Laith",
                                LastName = "Alfaloujeh",
                                PhoneNumber = "806-123-4565",
                                Email = "laith@wtamu.com",
                                Role = "Freshman"
                            },
                            new Student()
                            {
                                FirstName = "Mekkala",
                                LastName = "Bourape",
                                PhoneNumber = "806-123-4567",
                                Email = "mekkala@wtamu.com",
                                Role = "Sophomore"
                            },
                            new Student()
                            {
                                FirstName = "Charles",
                                LastName = "Coufal",
                                PhoneNumber = "806-367-3979",
                                Email = "charles@wtamu.com",
                                Role = "Junior"
                            },
                            new Student()
                            {
                                FirstName = "John",
                                LastName = "Cunningham",
                                PhoneNumber = "806-456-7890",
                                Email = "john@wtamu.com",
                                Role = "Senior"
                            },
                            new Student()
                            {
                                FirstName = "Michael",
                                LastName = "Hayes",
                                PhoneNumber = "806-220-4567",
                                Email = "micheal@wtamu.com",
                                Role = "Freshman"
                            },
                            new Student()
                            {
                                FirstName = "Aaron",
                                LastName = "Hebert",
                                PhoneNumber = "806-345-1234",
                                Email = "aaron@wtamu.com",
                                Role = "Sophomore"
                            },
                            new Student()
                            {
                                FirstName = "Yi Fu",
                                LastName = "Ji",
                                PhoneNumber = "567-345-1234",
                                Email = "yifu@wtamu.com",
                                Role = "Junior"
                            },
                            new Student()
                            {
                                FirstName = "Todd",
                                LastName = "Kile",
                                PhoneNumber = "804-334-2345",
                                Email = "todd@wtamu.com",
                                Role = "Senior"
                            },
                            new Student()
                            {
                                FirstName = "Mara",
                                LastName = "Kinoff",
                                PhoneNumber = "806-123-3945",
                                Email = "mara@wtamu.com",
                                Role = "Freshman"
                            },
                            new Student()
                            {
                                FirstName = "Cesareo",
                                LastName = "Lona",
                                PhoneNumber = "940-234-8473",
                                Email = "cesareo@wtamu.com",
                                Role = "Sophomore"
                            },
                            new Student()
                            {
                                FirstName = "Michael",
                                LastName = "Matthews",
                                PhoneNumber = "940-234-9385",
                                Email = "mattews@wtamu.com",
                                Role = "Junior"
                            },
                            new Student()
                            {
                                FirstName = "Mason",
                                LastName = "McCollum",
                                PhoneNumber = "940-958-5845",
                                Email = "mason@wtamu.com",
                                Role = "Senior"
                            },
                            new Student()
                            {
                                FirstName = "Alexander",
                                LastName = "McDonald",
                                PhoneNumber = "940-034-1234",
                                Email = "alexander@wtamu.com",
                                Role = "Freshman"
                            },
                            new Student()
                            {
                                FirstName = "Phelps",
                                LastName = "Merrell",
                                PhoneNumber = "940-123-0394",
                                Email = "phelps@wtamu.com",
                                Role = "Sophomore"
                            },
                            new Student()
                            {
                                FirstName = "Quan",
                                LastName = "Nguyen",
                                PhoneNumber = "803-583-3945",
                                Email = "quan@wtamu.com",
                                Role = "Junior"
                            },
                            new Student()
                            {
                                FirstName = "Alexander",
                                LastName = "Roder",
                                PhoneNumber = "805-239-3894",
                                Email = "roder@wtamu.com",
                                Role = "Senior"
                            },
                            new Student()
                            {
                                FirstName = "Amy",
                                LastName = "Saysourinyosack",
                                PhoneNumber = "802-834-4835",
                                Email = "amy@wtamu.com",
                                Role = "Freshman"
                            },
                            new Student()
                            {
                                FirstName = "Claudia",
                                LastName = "Silva",
                                PhoneNumber = "804-345-9873",
                                Email = "claudia@wtamu.com",
                                Role = "Sophomore"
                            },
                            new Student()
                            {
                                FirstName = "Gabriela",
                                LastName = "Valenzuela",
                                PhoneNumber = "806-321-2345",
                                Email = "gabriela@wtamu.com",
                                Role = "Junior"
                            },
                            new Student()
                            {
                                FirstName = "Kayla",
                                LastName = "Washington",
                                PhoneNumber = "804-123-9837",
                                Email = "kayla@wtamu.com",
                                Role = "Senior"
                            },
                            new Student()
                            {
                                FirstName = "Matthew",
                                LastName = "Webb",
                                PhoneNumber = "803-987-1284",
                                Email = "webb@wtamu.com",
                                Role = "Freshman"
                            },
                            new Student()
                            {
                                FirstName = "Cory",
                                LastName = "Williams",
                                PhoneNumber = "738-384-2874",
                                Email = "cory@wtamu.com",
                                Role = "Sophomore"
                            },
                                            
                        };

                        db.Students.AddRange(students);  

                        db.SaveChanges();                                              

                    }
                    
                
                    
                }
                catch(Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
        }
    }
}