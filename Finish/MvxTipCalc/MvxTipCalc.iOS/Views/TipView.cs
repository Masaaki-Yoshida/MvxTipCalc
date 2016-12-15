using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using MvxTipCalc.Core.ViewModels;
using System;
using UIKit;

namespace MvxTipCalc.iOS.Views
{
    public partial class TipView : MvxViewController
    {
        public TipView() : base("TipView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.CreateBinding(tip).To((TipViewModel vm) => vm.Tip).Apply();
            this.CreateBinding(subTotal).To((TipViewModel vm) => vm.SubTotal).Apply();
            this.CreateBinding(slider).To((TipViewModel vm) => vm.Generosity).Apply();

            subTotal.ShouldReturn += (textField) =>
            {
                subTotal.ResignFirstResponder();
                return true;
            };
            var subTotalGesture = new UITapGestureRecognizer(() =>
            {
                this.subTotal.ResignFirstResponder();
            });
            View.AddGestureRecognizer(subTotalGesture);
        }
    }
}