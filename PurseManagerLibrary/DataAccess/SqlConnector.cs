using System.Data.SqlClient;
using System.Data;
using PurseManagerLibrary.Model;
using Dapper;

namespace PurseManagerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        /// <summary>
        /// Save a new change to the database
        /// </summary>
        public OperationModel CreateChange(OperationModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("OperationsHistoryDB")))
            {
                var p = new DynamicParameters();
                p.Add("@NameOfOperations", model.NameOfChange);
                p.Add("@ValueToChange", model.ValueOfMoney);
                p.Add("@AmountToChange", model.Amount);
                p.Add("@Notes", model.Note);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.HistoryOfOperations", p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@Id");
                return model;
            }
        }

        public ExpenseCategoryModel CreateChange(ExpenseCategoryModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("OperationsHistoryDB")))
            {
                var p = new DynamicParameters();
                p.Add("@NameOfCategory", model.ExpenseList);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.ExpenseList", p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@Id");
                return model;
            }
        }

        public IncomeCategoryModel CreateChange(IncomeCategoryModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString("OperationsHistoryDB")))
            {
                var p = new DynamicParameters();
                p.Add("@NameOfCategory", model.IncomeList);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.IncomeList", p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@Id");
                return model;
            }
        }
    }
}
