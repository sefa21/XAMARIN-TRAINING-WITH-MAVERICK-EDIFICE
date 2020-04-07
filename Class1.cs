using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utility

{
    class Console
    {
        static public string userdetails(string question)
        {
            System.Console.Write(question);
            return System.Console.ReadLine();
        }

    }
}
