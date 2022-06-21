using PurseManagerLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurseManagerLibrary.DataAccess
{
    public interface IDataConnection
    {
        ExpenseCategoryModel CreateChange(ExpenseCategoryModel model);
        IncomeCategoryModel CreateChange(IncomeCategoryModel model);
        OperationModel CreateChange(OperationModel model);

    }
}
