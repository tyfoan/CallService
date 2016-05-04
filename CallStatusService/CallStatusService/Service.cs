using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallStatusService
{
    class Service
    {
        private string _previousFilePath;
        private string _presentFilePath;
        public Service(string previousFilePath, string presentFilePath)
        {
            _presentFilePath = presentFilePath;
            _previousFilePath = previousFilePath;
        }

        public void Method()
        {
            //try
            //{
            //    using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            //    {
            //        string line;
            //        while ((line = sr.ReadLine()) != null)
            //        {
            //            Console.WriteLine(line);
            //        }
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            string fileA, fileB, fileC;
            fileA = _previousFilePath;
            fileB = _presentFilePath;
            fileC = "result.txt";

            string alphaFilePath = fileA;

            List<string> alphaFileContent = new List<string>();

            using (FileStream fs = new FileStream(alphaFilePath, FileMode.Open))
            using (StreamReader rdr = new StreamReader(fs))
            {
                while (!rdr.EndOfStream)
                {
                    alphaFileContent.Add(rdr.ReadLine());
                }
            }

            string betaFilePath = fileB;

            StringBuilder sb = new StringBuilder();


            using (FileStream fs = new FileStream(betaFilePath, FileMode.Open))
            using (StreamReader rdr = new StreamReader(fs))
            {
                while (!rdr.EndOfStream)
                {
                    string[] betaFileLine = rdr.ReadLine().Split(Convert.ToChar(","));

                    if (!alphaFileContent.Contains(betaFileLine[0]))
                    {
                        sb.AppendLine(String.Format("{0}", betaFileLine[0]));
                    }
                }
            }

            using (FileStream fs = new FileStream(fileC, FileMode.Create))
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.Write(sb.ToString());
            }
        }

    }
}
