using Atividade_CoR.Models;

namespace Atividade_CoR.Handles
{
    public class IRRFDescount : BaseHandle
    {
        public IRRFDescount(decimal percentual, decimal minValue, decimal maxValue)
        {
            this.percentual = percentual;
            this.minValue = minValue;
            this.maxValue = maxValue;
        }

        public override void Apply(Wage wage)
        {
            if (wage.Value >= minValue && Next != null)
            {
                wage.IRRFDescount += (maxValue - minValue) * (percentual/100);
                Next.Apply(wage);
            } else
            {
                wage.IRRFDescount += (wage.Value - minValue) * (percentual/100);
            }
        }
    }
}