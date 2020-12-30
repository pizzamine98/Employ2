using System;
using System.Collections.Generic;
using System.Text;

namespace Employ2
{
    class Remover
    {
        public void RemoveEmployee(string[] partsin, List<Employee> empsin)
        {
            List<Employee> remove = new List<Employee>();
            foreach (var e in empsin)
            {
                if (e.Name == partsin[1])
                {
                    remove.Add(e);
                }
            }
            foreach (var e in remove)
            {
                empsin.Remove(e);
            }
        }
    }
}
