using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace classesForBD
{

    public enum Type
    {
        Integer,
        Real,
        Char,
        String,
        HtmlFile,
        StringInvl
    }
    class Column
    {
        public Column() { }
        public Column(string name, Type type)
        {
            Name = name;
            Type = type;
        }
        public string Name { get; set; }
        public Type Type { get; set; }
        static public bool ValidationofStringInvl(string v)
        {
            string[] t = v.Replace(" ", "").Split(',');
            if (t.Length == 2 && String.Compare(t[1], t[2]) > 0)
                return true;
            else
                return false;
        }

        public bool ValidationOfType(string value)
        {
            return Type switch
            {
                Type.Integer => Int32.TryParse(value, out _),
                Type.Real => Double.TryParse(value, out _),
                Type.Char => Char.TryParse(value, out _),
                Type.String => true,
                Type.HtmlFile => value.ToLower().EndsWith(".html") && File.Exists(value),
                Type.StringInvl => Column.ValidationofStringInvl(value),
                _ => false
            };
        }
    }
}
