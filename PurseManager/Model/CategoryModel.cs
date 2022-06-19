using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurseManager.Model
{
    public class CategoryModel
    {
        private int count { get; set; }
        //private int 

        public List<string> listOfExpenditures = new List<string>
        {
            "Auto",
            "Medicine",
            "Sport",
            "Family"
        };

        public List<string> listOfReciepts = new List<string>
        {
            "Salary",
            "Dividends",
            "Illegal market :)"
        };

        public List<OperationModel> GetRecieptList(int total, List<string> list, int length)
        {
            List<OperationModel> result = new List<OperationModel>();
            count = list.Count - 1;
            for (int i = 0; i < total; i++)
            {
                result.Add(GetReciept((i + 1), list, length));
                count--;
            }
            return result;
        }

        private OperationModel GetReciept(int id, List<string> data, int length)
        {
            OperationModel result = new OperationModel();
            result.NameOfChange = GetItemOfList(data);
            return result;
        }

        private string GetItemOfList(List<string> data)
        {
            return data[count];
        }
    }
}
