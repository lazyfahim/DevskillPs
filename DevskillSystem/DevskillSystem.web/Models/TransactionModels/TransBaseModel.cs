using System;
using Autofac;
using DevSkillSystem.FrameWork;

namespace DevskillSystem.web.Models.TransactionModels
{
    public class TransBaseModel:IDisposable
    {
        internal ITransactionService _service;

        public TransBaseModel(ITransactionService service)
        {
            _service = service;
        }

        public TransBaseModel()
        {
            _service = Startup.AutofacContainer.Resolve<ITransactionService>();
        }
        public void Dispose()
        {
            _service.Dispose();
        }
    }
}