using System.Text;
using System.Threading.Tasks;

namespace classesForBD
{
    class Table
    {
        public Table() { }
        public string Name { get; set; }
        public List<Column> Columns { get; set; } = new();
        public List<Row> Rows { get; set; } = new();
        public Table(string name)
        {
            Name = name;
        }
    }
}
