using System;
using UIKit;

namespace MvxTipCalc.iOS.Views
{
    public partial class TipView : UIViewController
    {
        public TipView() : base("TipView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            subTotal.EditingChanged += SubTotal_EditingChanged;
            slider.ValueChanged += Slider_ValueChanged;

            subTotal.ShouldReturn += (textField) =>
            {
                subTotal.ResignFirstResponder();
                return true;
            };
            //���O�^�b�v
            var subTotalGesture = new UITapGestureRecognizer(() =>
            {
                this.subTotal.ResignFirstResponder();
            });
            View.AddGestureRecognizer(subTotalGesture);
        }

        private void SubTotal_EditingChanged(object sender, EventArgs e)
        {
            double subTotalValue = 0;
            if (double.TryParse((sender as UITextField).Text, out subTotalValue))
            {
                tip.Text = TipAmount(subTotalValue, slider.Value).ToString();
            }
        }

        private void Slider_ValueChanged(object sender, EventArgs e)
        {
            int subTotalValue = 0;
            if (int.TryParse(subTotal.Text, out subTotalValue))
            {
                tip.Text = TipAmount(subTotalValue, slider.Value).ToString();
            }
        }

        public double TipAmount(double subTotal, double generosity)
        {
            return subTotal * generosity / 100.0;
        }

    }
}