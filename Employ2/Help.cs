using System;
using System.Collections.Generic;
using System.Text;

namespace Employ2
{
    class Help
    {
        public void PrintHelp()
        {
            Console.WriteLine("Enter \"exit\" to exit program");
            Console.WriteLine("Enter \"add,*name*,*jobtitle*\" to add employee");
            Console.WriteLine("Enter \"delete,*name*\" to delete employee");
            Console.WriteLine("Enter \"modify,*name*,*newname*,*newjobtitle*\" to modify employee");
            Console.WriteLine("Enter \"printout\" to printout employees");
            Console.WriteLine("Enter \"write\" to write file");
            Console.WriteLine("Enter \"load\" to load file");
            Console.WriteLine("Enter \"setpath,*filepath*\" to set filepath ");
        }
        public void PrintEmployees(List<Employee> empsin)
        {
            foreach (var e in empsin)
            {
                Console.WriteLine(e.Name + "," + e.Jobtitle);
            }
        }
    }
}
