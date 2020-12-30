using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
namespace Employ2
{
    class ReadWrite
    {
        public string path,json;
        public List<Employee> emps;
        public void Write()
        {
            json = JsonConvert.SerializeObject(emps);
            System.IO.File.WriteAllText(path, json);
        }
        public void Read() 
        {
            using (StreamReader r = new StreamReader(path))
            {
                json = r.ReadToEnd();
                emps = JsonConvert.DeserializeObject<List<Employee>>(json);
            }
        }

    }
}
