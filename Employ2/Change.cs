using System;
using System.Collections.Generic;
using System.Text;

namespace Employ2
{
    class Change
    {
        public void AddEmployee(string[] partsin, List<Employee> empsin)
        {
            empsin.Add(new Employee() { Name = partsin[1], Jobtitle = partsin[2] });
        }
        public void ModifyEmployee(string[] partsin, List<Employee> empsin)
        {
            foreach (var e in empsin)
            {
                if (e.Name == partsin[1])
                {
                    e.Name = partsin[2];
                    e.Jobtitle = partsin[3];
                }
            }
        }
    }
}
