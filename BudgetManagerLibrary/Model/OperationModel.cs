using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary.Model
{
    public class OperationModel
    {
        public int Id { get; set; }
        public decimal ValueOfMoney { get; set; }
        public decimal Amount { get; set; }
        public string NameOfChange { get; set; }
        public string Note { get; set; }
        public string FullName
        {
            get { return NameOfChange; }
        }
        public OperationModel()
        {

        }
        public OperationModel(string valueOfMoney, string nameOfChange, string note)
        {
            NameOfChange = nameOfChange;
            Note = note;

            decimal amountOfMoney = 0;
            decimal.TryParse(valueOfMoney, out amountOfMoney);
            ValueOfMoney = amountOfMoney;
        }
    }
}
