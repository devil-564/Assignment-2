using ClosedXML.Excel;

namespace Temp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var FileName = @"C:\Book.xlsx";

            using (var workbook = new XLWorkbook(FileName))
            {
                int counter = 0;
                string CheckPoint;
                string CheckPoint1;

                Dictionary<string, string> dict1 = new Dictionary<string, string>();
                Dictionary<string, string> dict2 = new Dictionary<string, string>();
                Dictionary<string, string> Result = new Dictionary<string, string>();

                var sheet1 = workbook.Worksheet(1);
                var sheet2 = workbook.Worksheet(2);

                for(int i = 1; i < 313; i++)
                {
                    string name = $"B{i}";
                    string pass = $"C{i}";

                    dict1[sheet1.Cell(name).Value.ToString()] = sheet1.Cell(pass).Value.ToString();
                }

                for (int i = 1; i < 343; i++)
                {
                    string name = $"B{i}";
                    string pass = $"C{i}";

                    dict2[sheet2.Cell(name).Value.ToString()] = sheet2.Cell(pass).Value.ToString();
                }

                foreach(var i in dict1)
                {
                    string name = i.Key;
                    string pass = i.Value;

                    if(dict2.ContainsKey(name) && dict2[name] != pass)
                    {
                        Result.Add(name, dict2[name]);
                    }
                }


                Console.WriteLine("Total Number of People whose password is changed => " + Result.Count+"\n");


                foreach (var i in Result) 
                {
                    Console.WriteLine($"UserName - {i.Key}, \nNew Password - {i.Value} \n");
                }
            }
        }
    }
}
