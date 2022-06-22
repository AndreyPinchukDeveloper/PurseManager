using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary.Model
{
    public class ExpenseCategoryModel
    {
        public int Id { get; set; }
        public List<string> ExpenseList { get; set; }
    }
}
