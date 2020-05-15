using System.Collections.Generic;
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
            
        }

        public IList<Transaction> GetAll()
        {
            return _service.GetAll();
        }

        public Transaction Get(int Id)
        {
            return _service.GetTransaction(Id);
        }

        public void Delete(int Id)
        {
            _service.Delete(Id);
        }
    }
}