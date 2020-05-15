using System.ComponentModel.DataAnnotations;
using DevSkillSystem.FrameWork;
using Microsoft.AspNetCore.Mvc;

namespace DevskillSystem.web.Models.TransactionModels
{
    public class TransEditModel:TransBaseModel
    {
        public TransEditModel(int Id):base()
        {
            var trans = _service.GetTransaction(Id);
            this.Id = trans.Id;
            this.Name = trans.Name;
            this.Amount = trans.Amount;
            this.TrxType = trans.TrxType;
        }

        public TransEditModel()
        {
            
        }

        public TransEditModel(ITransactionService service):base(service)
        {
            
        }
        [HiddenInput]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public TrxType TrxType { get; set; }

        public void Edit()
        {
            var trans = new Transaction()
            {
                Id =  this.Id,
                Amount = this.Amount,
                Name = this.Name,
                TrxType = this.TrxType
            };
            _service.Edit(trans);
        }
    }
}