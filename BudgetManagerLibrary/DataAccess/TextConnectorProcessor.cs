using BudgetManagerLibrary.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary.DataAccess
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";//reference to App.config
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }

        public static List<OperationModel> ConvertToMoneyModel(this List<string> lines)
        {
            List<OperationModel> output = new List<OperationModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                OperationModel p = new OperationModel();
                p.Id = int.Parse(cols[0]);
                p.ValueOfMoney = decimal.Parse(cols[1]);
                p.NameOfChange = cols[2];
                p.Note = cols[3];
                p.Amount = decimal.Parse(cols[4]);
                output.Add(p);
            }

            return output;
        }

        public static void SaveToModelFile(this List<OperationModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (OperationModel m in models)
            {
                lines.Add($"{m.Id},{m.ValueOfMoney},{m.NameOfChange},{m.Note},{ m.Amount}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);

        }
    }
}
