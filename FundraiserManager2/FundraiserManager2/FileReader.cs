using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FundraiserManager2
{
    class FileReader
    {
        public string ReadFile(string filename)
        {
            string documentContent = File.ReadAllText(filename);
            return documentContent;
        }
    }
}
