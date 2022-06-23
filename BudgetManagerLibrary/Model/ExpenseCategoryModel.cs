namespace BudgetManagerLibrary.Model
{
    public class ExpenseCategoryModel
    {
        public int Id { get; set; }
        public string ExpenseCategory { get; set; }

        public ExpenseCategoryModel(string expenseCategory)
        {
            ExpenseCategory = expenseCategory;
        }
    }
}
