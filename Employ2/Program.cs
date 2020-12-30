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
            Readme read = new Readme();
            read.Execute();
        }
    }
    class Readme
    {
        public List<Employee> employees;
        public Help help;
        public ReadWrite rws;
        public Remover remove;
        public Change change;
        public void Execute()
        {
            employees = new List<Employee>();
            inloop = true;
            help = new Help();
            rws = new ReadWrite();
            remove = new Remover();
            change = new Change();
            while (inloop)
            {
                Console.WriteLine("Enter command below(or \"help\" for list of commands");
                command = Console.ReadLine();
                parts = command.Split(",");
                if (command.Equals("help"))
                {
                    help.PrintHelp();
                } else if (command.StartsWith("add"))
                {
                    change.AddEmployee(parts, employees);
                } else if (command.StartsWith("delete"))
                {
                    remove.RemoveEmployee(parts, employees);
                } else if (command.StartsWith("modify"))
                {
                    change.ModifyEmployee(parts, employees);
                } else if (command.Equals("printout"))
                {
                    help.PrintEmployees(employees);
                } else if (command.Equals("exit"))
                {
                    inloop = false;
                } else if (command.StartsWith("write"))
                {
                    rws.emps = employees;
                    rws.Write();
                    employees = rws.emps;
                } else if (command.StartsWith("load"))
                {
                    rws.emps = employees;
                    rws.Read();
                    employees = rws.emps;
                } else if (command.StartsWith("setpath"))
                {
                    rws.emps = employees;
                    rws.path = @"" + parts[1];
                    rws.Read();
                    employees = rws.emps;
                }
            }
        }
        private string[] parts;
        private string command;
        private bool inloop; 
    }
    

}
