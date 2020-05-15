using System;
using System.ComponentModel.DataAnnotations;
using DevSkillSystem.FrameWork;

namespace DevskillSystem.web.Models.TransactionModels
{
    public class TransCreateModel:TransBaseModel
    {
        public TransCreateModel()
        {
            
        }

        public TransCreateModel(ITransactionService service)
            :base(service)
        {
            
        }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public TrxType TrxType { get; set; }

        public void Create()
        {
            var trans = new Transaction()
            {
                Amount = this.Amount,
                Name = this.Name,
                TrxType = this.TrxType
            };
            _service.AddTransaction(trans);
        }
    }
}