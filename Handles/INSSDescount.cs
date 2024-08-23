using Atividade_CoR.Models;

namespace Atividade_CoR.Handles
{
    public class INSSDescount : BaseHandle
    {
        public INSSDescount(decimal percentual, decimal minValue, decimal maxValue)
        {
             this.percentual = percentual;
             this.minValue = minValue;
             this.maxValue = maxValue;
        }

        public override void Apply(Wage wage) 
        {
            if (wage.Value >= minValue)
            {
                if (wage.Value >= maxValue && Next != null)
                {
                    wage.INSSDescount += (maxValue - minValue) * (percentual/100);
                    Next.Apply(wage);
                } else
                {
                    wage.INSSDescount += (maxValue - minValue) * (percentual/100);
                }
            }
        }
    }
}

