using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FundraiserManager2
{
    public static class FIleWriter
    {
        public static void WriteRecordToFile(string FileName, string RecordName)
        {
            File.WriteAllText(FileName, RecordName + Environment.NewLine);
        }

        public static void AddRecordToFile(string FileName, string RecordToAdd)
        {
            File.AppendAllText(FileName, RecordToAdd + Environment.NewLine);
        }

        public static void WriteAllLinesToFile(string FileName, string[] Lines)
        {
            File.WriteAllLines(FileName, Lines);
        }
    }
}
