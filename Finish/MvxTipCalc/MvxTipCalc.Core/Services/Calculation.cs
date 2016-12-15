
namespace MvxTipCalc.Core.Services
{
    public class Calculation : ICalculation
    {
        public double TipAmount(double subTotal, double generosity)
        {
            return subTotal * generosity / 100.0;
        }
    }
}
