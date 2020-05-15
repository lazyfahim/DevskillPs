using System;
using System.Collections.Generic;

namespace DevSkillSystem.FrameWork
{
    public class TransactionService:IDisposable, ITransactionService
    {
        ITransactionUnitOfWork _unitOfWork;
        public TransactionService(ITransactionUnitOfWork transactionUnitOfWork)
        {
            _unitOfWork = transactionUnitOfWork;
        }

        public void AddTransaction(Transaction transaction)
        {
            _unitOfWork.TransactionRepository.Add(transaction);
            _unitOfWork.Save();
        }

        public void Edit(Transaction transaction)
        {
            var transactiontoEdit = _unitOfWork.TransactionRepository.GetById(transaction.Id);
            transactiontoEdit.Id = transaction.Id;
            transactiontoEdit.Name = transaction.Name;
            transactiontoEdit.Amount = transaction.Amount;
            transactiontoEdit.TrxType = transaction.TrxType;
            _unitOfWork.Save();
        }

        public void Delete(int Id)
        {
            _unitOfWork.TransactionRepository.Remove(Id);
            _unitOfWork.Save();
        }

        public Transaction GetTransaction(int Id)
        {
            return _unitOfWork.TransactionRepository.GetById(Id);
        }

        public IList<Transaction> GetAll()
        {
            return _unitOfWork.TransactionRepository.GetAll();
        }
        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}