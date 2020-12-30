using System;
using System.Collections.Generic;
using System.Linq;

namespace Employ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Readme read = new Readme();
            read.Execute();
        }
    }
    class Readme
    {
        public List<Employee> employees;
        public void Execute()
        {
            employees = new List<Employee>();
            inloop = true;
            while (inloop)
            {
                Console.WriteLine("Enter command below(or \"help\" for list of commands");
                command = Console.ReadLine();
                if (command.Equals("help"))
                {
                    Console.WriteLine("Enter \"exit\" to exit program");
                    Console.WriteLine("Enter \"add,*name*,*jobtitle*\" to add employee");
                    Console.WriteLine("Enter \"delete,*name*\" to delete employee");
                    Console.WriteLine("Enter \"modify,*name*,*newname*,*newjobtitle*\" to modify employee");
                    Console.WriteLine("Enter \"printout\" to printout employees");
                } else if (command.StartsWith("add"))
                {
                    parts = command.Split(",");
                    employees.Add(new Employee() { Name = parts[1], Jobtitle = parts[2] });
                } else if (command.StartsWith("delete"))
                {
                    parts = command.Split(",");
                    remove = new List<Employee>();
                    foreach(var e in employees)
                    {
                        if(e.Name == parts[1])
                        {
                            remove.Add(e);
                        }
                    }
                    foreach(var e in remove)
                    {
                        employees.Remove(e);
                    }
                    
                    

                } else if (command.StartsWith("modify"))
                {
                    parts = command.Split(",");
                    foreach(var e in employees)
                    {
                        if(e.Name == parts[1])
                        {
                            e.Name = parts[2];
                            e.Jobtitle = parts[3];
                        }
                    }
                } else if (command.Equals("printout"))
                {
                    foreach(var e in employees)
                    {
                        Console.WriteLine(e.Name + "," + e.Jobtitle);
                    }
                } else if (command.Equals("exit"))
                {
                    inloop = false;
                }
            }
        }
        private List<Employee> remove;
        private string[] parts;
        private string command;
        private bool inloop; 
    }
    class Employee
    {
        public string Name, Jobtitle;
    }

}
