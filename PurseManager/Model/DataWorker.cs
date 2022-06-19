using PurseManager.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurseManager.Model
{
    public static class DataWorker
    {
        public static string CreateCategory(string name)
        {
            string result = "Already exist";

            using (ApplicationContext db = new ApplicationContext())//check if already exist
            {
                bool checkIsExist = db.OperationModel.Any(element => element.FullName == name);
                if (!checkIsExist)
                {
                    OperationModel newMoneyModel = new OperationModel { NameOfChange = name };//use new class instead of MoneyModel
                    db.OperationModel.Add(newMoneyModel);
                    db.SaveChanges();
                    result = "done";
                }
                return result;
            }
        }
        //TODO-create change of budget
        public static string CreateChangeOfBudget(string name, decimal value, string note)
        {
            string result = "Already exist";

            using (ApplicationContext db = new ApplicationContext())//check if already exist
            {
                OperationModel newMoneyModel = new OperationModel
                {
                    ValueOfMoney = value,
                    NameOfChange = name,
                    Note = note,
                };

                db.OperationModel.Add(newMoneyModel);
                db.SaveChanges();
                result = "done";
                return result;
            }
        }
        //TODO - remove any changes
        public static string RemoveCategory(OperationModel moneyModel)//use new class instead of MoneyModel
        {
            string result = "Chosen category doesn't exist";
            using (ApplicationContext db = new ApplicationContext())
            {
                db.OperationModel.Remove(moneyModel);
                db.SaveChanges();
                result = "The category " + moneyModel.NameOfChange + " has deleted.";
            }
            return result;
        }
        //TODO - opportunity to correct any changes

    }
}
