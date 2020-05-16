using System;
using System.Collections.Generic;
using System.Linq;
using DevSkillSystem.FrameWork;

namespace DevskillSystem.web.Models.TransactionModels
{
    public class TransModel:TransBaseModel
    {
        public TransModel(ITransactionService service)
            :base(service)
        {
            
        }

        public TransModel()
        {
            Transactions = GetAll();
            TotalIncome = Transactions.Where(t => t.TrxType == TrxType.Income)
                .Select(t => t.Amount).Sum();
            TotalExpense = Transactions.Where(t => t.TrxType == TrxType.Expense)
                .Select(t => t.Amount).Sum();
        }
        
        public IList<Transaction> Transactions { get;private set; }
        public double TotalIncome { get; private set; }
        public double TotalExpense { get; private set; }

        public double TotalBalance
        {
            get { return TotalIncome - TotalExpense; }
        }

        private IList<Transaction> GetAll()
        {
            return _service.GetAll();
        }

        public Transaction Get(int Id)
        {
            Console.WriteLine();
            return _service.GetTransaction(Id);
        }

        public void Delete(int Id)
        {
            _service.Delete(Id);
        }
    }
}