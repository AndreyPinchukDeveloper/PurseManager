using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurseManagerLibrary.Model
{
    public class ExpenseCategoryModel
    {
        public int Id { get; set; }
        public List<string> ExpenseList { get; set; }
    }
}
