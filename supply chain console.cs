using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REGISTRATION_APP
{
    class Program
    {
        static void Main(string[] args)
        {

            var users = new List<user>();

            var adding = true;
            while (adding)
            {

                var NEWUSER = new user();

                
                NEWUSER.name = utility.Console.userdetails("User`s Name:");
                    
                
               NEWUSER.jobdescription = utility.Console.userdetails("User`s Job Description:");


                NEWUSER.age = int.Parse(utility.Console.userdetails("User`s Age:"));


                NEWUSER.phone = int.Parse(utility.Console.userdetails("User`s Contact:"));

                
                NEWUSER.location = utility.Console.userdetails("User`s Location:");

                
                NEWUSER.address = utility.Console.userdetails("User`s Adress:");


                 users.Add(NEWUSER);
         
                Console.WriteLine("Add another User Y/N");
                if(Console.ReadLine() != "Y")
                {
                    adding = false;
                }

                foreach(var user in users)
                {
                    Console.WriteLine("User`s Name: {0} , User`s Role in Supply Chain: {1} , User`s Age:{2} , User`s Contact: {3} ,User`s Location: {4} , User`s Address: {5}", user.name, user.jobdescription, user.age, user.phone, user.location, user.address);
                   
                    
                                  
                        

                }
               
            }
             


        }
    }



    class user
    {
      public string name;
      public string jobdescription;
      public int age;
      public string location;
      public string address;
      public int phone;
        
       

    }
     
}
