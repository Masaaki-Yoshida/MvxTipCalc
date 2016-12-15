
namespace MvxTipCalc.Core.Services
{
    public interface ICalculation
    {
        double TipAmount(double subTotal, double generosity);
    }
}