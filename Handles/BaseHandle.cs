using Atividade_CoR.Models;

namespace Atividade_CoR.Handles
{
    public abstract class BaseHandle
    {
        public BaseHandle? Next { get; set; }
        public decimal percentual, minValue, maxValue;
        
        public abstract void Apply(Wage wage);
    }
}