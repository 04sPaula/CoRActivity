using Atividade_CoR.Handles;
using Atividade_CoR.Models;

INSSDescount iNSSDescount = new INSSDescount(7.5m, 0, 1302);
INSSDescount iNSSDescount2 = new INSSDescount(9m, 1302.01m, 2571.29m);
INSSDescount iNSSDescount3 = new INSSDescount(12, 2571.3m, 3856.94m);
INSSDescount iNSSDescount4 = new INSSDescount(14, 3856.95m, 7507.49m);

iNSSDescount3.Next = iNSSDescount4;
iNSSDescount2.Next = iNSSDescount3;
iNSSDescount.Next = iNSSDescount2;

IRRFDescount iRRFDescount = new IRRFDescount(0, 0, 1903.98m);
IRRFDescount iRRFDescount2 = new IRRFDescount(7.5m, 1903.99m, 2826.65m);
IRRFDescount iRRFDescount3 = new IRRFDescount(15, 2826.66m, 3751.05m);
IRRFDescount iRRFDescount4 = new IRRFDescount(22.5m, 3751.05m, 4664.68m);
IRRFDescount iRRFDescount5 = new IRRFDescount(27.5m, 4664.69m, decimal.MaxValue);

iRRFDescount4.Next = iRRFDescount5;
iRRFDescount3.Next = iRRFDescount4;
iRRFDescount2.Next = iRRFDescount3;
iRRFDescount.Next = iRRFDescount2;

Console.Write("Informe o seu salário bruto: R$");
decimal brutalWage = Convert.ToDecimal(Console.ReadLine());
Console.Write("Informe a sua quantidade de dependentes: ");
int dependents = Convert.ToInt32(Console.ReadLine());

Wage wage = new Wage(brutalWage);

iNSSDescount.Apply(wage);
iRRFDescount.Apply(wage);

if (dependents > 0)
{
    wage.IRRFDescount -= dependents * 182.29m;

    if (wage.IRRFDescount < 0)
    {
        wage.IRRFDescount = 0;
    }
}

Console.Write($"Salário bruto: R${wage.Value:N2} \nSalário líquido: ");
Console.Write($"R${wage.Value - wage.INSSDescount - wage.IRRFDescount:N2}");
