using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
namespace Employ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           List<Employee> remove, employees;
       string[] parts;
        string command, path, json;
         bool inloop;
        employees = new List<Employee>();
            inloop = true;
            while (inloop)
            {
                Console.WriteLine("Enter command below(or \"help\" for list of commands");
                command = Console.ReadLine();
                parts = command.Split(",");
                if (command.Equals("help"))
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
                else if (command.StartsWith("add"))
                {
                    employees.Add(new Employee() { Name = parts[1], Jobtitle = parts[2] });
                }
                else if (command.StartsWith("delete"))
                {
                    remove = new List<Employee>();
                    foreach (var e in employees)
                    {
                        if (e.Name == parts[1])
                        {
                            remove.Add(e);
                        }
                    }
                    foreach (var e in remove)
                    {
                        employees.Remove(e);
                    }
                }
                else if (command.StartsWith("modify"))
                {
                    foreach (var e in employees)
                    {
                        if (e.Name == parts[1])
                        {
                            e.Name = parts[2];
                            e.Jobtitle = parts[3];
                        }
                    }
                }
                else if (command.Equals("printout"))
                {
                    foreach (var e in employees)
                    {
                        Console.WriteLine(e.Name + "," + e.Jobtitle);
                    }
                }
                else if (command.Equals("exit"))
                {
                    inloop = false;
                }
                else if (command.StartsWith("write"))
                {
                    json = JsonConvert.SerializeObject(employees);
                    System.IO.File.WriteAllText(path, json);
                }
                else if (command.StartsWith("load"))
                {
                    using (StreamReader r = new StreamReader(path))
                    {
                        json = r.ReadToEnd();
                        employees = JsonConvert.DeserializeObject<List<Employee>>(json);
                    }
                }
                else if (command.StartsWith("set"))
                {
                    path = @"" + parts[1];
                }
            }
        }
    }
    class Employee
    {
        public string Name, Jobtitle;
    }

}
