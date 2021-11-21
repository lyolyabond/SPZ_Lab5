using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;

namespace SPZ_Lab5.Model
{
    static class Serialization
    {
        public static string Path { get; } = "file.json";
        static public void Serialize()
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<Student>));
             using (FileStream file = new FileStream(Path, FileMode.Create))
            {
                jsonFormatter.WriteObject(file, Storage.Students);
            }
        }
        static public List<Student> Deserialize()
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<Student>));
            using (FileStream file = new FileStream(Path, FileMode.Open))
            {
                return jsonFormatter.ReadObject(file) as List<Student>;
            }
        }
    }
}
