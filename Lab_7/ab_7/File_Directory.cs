using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ab_7
{
    class File_Directory
    {
        public string name;
        public string fullName;

        public File_Directory(string name, string fullName)
        {
            this.name = name;
            this.fullName = fullName;
        }
        public override string ToString()
        {
            return name;
        }

    }
}
