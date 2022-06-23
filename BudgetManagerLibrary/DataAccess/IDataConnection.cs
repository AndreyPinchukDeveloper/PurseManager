using BudgetManagerLibrary.Model;

namespace BudgetManagerLibrary.DataAccess
{
    public interface IDataConnection
    {
        ExpenseCategoryModel CreateChange(ExpenseCategoryModel model);
        IncomeCategoryModel CreateChange(IncomeCategoryModel model);
        OperationModel CreateChange(OperationModel model);

    }
}
