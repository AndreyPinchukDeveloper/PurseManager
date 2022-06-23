using BudgetManagerLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BudgetManagerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string ModelsFile = "OperationModel.csv";       

        public ExpenseCategoryModel CreateChange(ExpenseCategoryModel model)
        {
            throw new NotImplementedException();
        }

        public IncomeCategoryModel CreateChange(IncomeCategoryModel model)
        {
            throw new NotImplementedException();
        }

        public OperationModel CreateChange(OperationModel model)
        {
            // Load text file
            // Convert the text to List<MoneyModel>
            List<OperationModel> models = ModelsFile.FullFilePath().LoadFile().ConvertToMoneyModel();

            // Find the max ID
            int currentId = 0 + 1;

            if (models.Count > 0)
            {
                currentId = models.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            // ADD the new record with the new ID (max + 1)
            models.Add(model);

            // Convert the money to list<string>
            // Save the list<string> to the text file
            models.SaveToModelFile(ModelsFile);

            return model;
        }
    }
}
