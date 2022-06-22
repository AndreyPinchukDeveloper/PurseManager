using BudgetManagerLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary.DataAccess
{
    public interface IDataConnection
    {
        ExpenseCategoryModel CreateChange(ExpenseCategoryModel model);
        IncomeCategoryModel CreateChange(IncomeCategoryModel model);
        OperationModel CreateChange(OperationModel model);

    }
}
