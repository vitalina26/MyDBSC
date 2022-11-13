using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesForBD
{
    class DB
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public List<Table> Tables { get; set; } = new();
        public DB(string name, string path)
        {
            Name = name;
            Path = path;
        }
        public DB() { }
        public DB(DB database)
        {
            Name = database.Name;
            Path = database.Path;
        }
    }
}
