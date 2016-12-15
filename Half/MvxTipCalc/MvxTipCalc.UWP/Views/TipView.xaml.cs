using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページのアイテム テンプレートについては、http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 を参照してください

namespace MvxTipCalc.UWP.Views
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class TipView : Page
    {
        public TipView()
        {
            this.InitializeComponent();
            subTotal.TextChanged += SubTotal_TextChanged;
            slider.ValueChanged += Slider_ValueChanged;
        }

        private void SubTotal_TextChanged(object sender, TextChangedEventArgs e)
        {
            double subTotalValue = 0;
            if (double.TryParse((sender as TextBox).Text, out subTotalValue)){
                tip.Text = TipAmount(subTotalValue, slider.Value).ToString();
            }
        }

        private void Slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
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
