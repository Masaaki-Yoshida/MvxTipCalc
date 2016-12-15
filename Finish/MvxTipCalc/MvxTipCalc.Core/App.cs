using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvxTipCalc.Core.Services;
using MvxTipCalc.Core.ViewModels;

namespace MvxTipCalc.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.RegisterType<ICalculation, Calculation>();
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<TipViewModel>());
        }
    }
}
