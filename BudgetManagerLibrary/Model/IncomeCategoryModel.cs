namespace BudgetManagerLibrary.Model
{
    public class IncomeCategoryModel
    {
        public int Id { get; set; }
        public string IncomeCategory { get; set; }

        public IncomeCategoryModel(string incomeCategory)
        {
            IncomeCategory = incomeCategory;
        }
    }
}
