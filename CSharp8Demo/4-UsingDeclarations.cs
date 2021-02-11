using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp8Demo
{
    public static class UsingDeclarations
    {
        public static int ConvertFiles()
        {
            int output = 0;
            using var inputFile = new StreamReader("TestFile.txt");
            using var outputFile = new StreamWriter("OutputFile.txt");
            string line;
            while ((line = inputFile.ReadLine()) != null)
            {
                outputFile.WriteLine(line);
                output++;
            }
            //using (var inputFile = new StreamReader("TestFile.txt"))
            //{
            //    using (var outputFile = new StreamWriter("OutputFile.txt"))
            //    {
            //        string line;
            //        while((line=inputFile.ReadLine())!=null)
            //        {
            //            outputFile.WriteLine(line);
            //            output++;
            //        }
            //    }
            //}
            return output;
        }
    }
}
