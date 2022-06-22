using System.Data.SqlClient;
using System.Data;
using BudgetManagerLibrary.Model;
using Dapper;

namespace BudgetManagerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        /// <summary>
        /// Save a new change to the database
        /// </summary>
        public OperationModel CreateChange(OperationModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("BudgetManagerData")))
            {
                var p = new DynamicParameters();
                p.Add("@NameOfOperations", model.NameOfChange);
                p.Add("@ValueToChange", model.ValueOfMoney);
                p.Add("@AmountToChange", model.Amount);
                p.Add("@Notes", model.Note);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spHistoryOfOperations", p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@Id");
                return model;
            }
        }

        public ExpenseCategoryModel CreateChange(ExpenseCategoryModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("BudgetManagerData")))
            {
                var p = new DynamicParameters();
                p.Add("@NameOfExpense", model.ExpenseList);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spExpenseList", p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@Id");
                return model;
            }
        }

        public IncomeCategoryModel CreateChange(IncomeCategoryModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("BudgetManagerData")))
            {
                var p = new DynamicParameters();
                p.Add("@NameOfIncome", model.IncomeList);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spIncomeList", p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@Id");
                return model;
            }
        }
    }
}
