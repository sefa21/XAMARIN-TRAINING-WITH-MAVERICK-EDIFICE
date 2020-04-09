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

                
                NEWUSER.Name = utility.Console.userdetails("User`s Name:");
                    
                
               NEWUSER.Job = utility.Console.userdetails("User`s Job Description:");


                NEWUSER.Age = int.Parse(utility.Console.userdetails("User`s Age:"));


                NEWUSER.Phone = int.Parse(utility.Console.userdetails("User`s Contact:"));

                
                NEWUSER.Location = utility.Console.userdetails("User`s Location:");

                
               NEWUSER.Address = utility.Console.userdetails("User`s Adress:");


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
      private string name;
      private string jobdescription;
      private int age;
      private string location;
      private string address;
      private int phone;


        public int Phone
        {
            set
            {
                phone = value;
                

            }

          

        }

        public string Job
        {
            set
            {
                jobdescription = value;
            }
        }
        
        public int Age
        {
            set
            {
                age = value;
            }
        }
       

        public string Location
        {
            set
            {
                location = value;
            }
        }

        public string Address
        {
            set
            {
                address = value;
            }
        }


        public string Name
        {
            set
            {
                name = value;
            }
        }

    }
     
}
