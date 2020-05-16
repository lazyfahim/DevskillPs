using System;
using System.ComponentModel.DataAnnotations;
using DevskillSystem.data;

namespace DevSkillSystem.FrameWork
{
    public class Transaction:IEntity<int>
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public double Amount { get; set; }
        public TrxType TrxType { get; set; }
        private DateTime _insertTime;

        public DateTime InsertTime
        {
            get => _insertTime;
            set => _insertTime = DateTime.Now;
        }
    }

    public enum TrxType
    {
        Income,
        Expense
    }
}