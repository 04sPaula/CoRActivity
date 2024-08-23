using System.Transactions;

namespace Atividade_CoR.Models
{
    public class Wage
    {
        public decimal Value { get; set; }
        public decimal INSSDescount { get; set; }
        public decimal IRRFDescount { get; set; }

        public Wage (decimal value)
        {
            Value = value;
        }
    }
}